using System;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO.Compression;
using System.Net;

namespace BeatmapPackager {
    public partial class MainForm : Form {
        public MainForm( ) =>
            InitializeComponent( );

        string folderPath = string.Empty;
        DirectoryInfo dirInfo = new( AppDomain.CurrentDomain.BaseDirectory );

        private void sourceButtonPress( object sender, EventArgs e ) {

            using ( var fbd = new FolderBrowserDialog( ) ) {

                if ( fbd.ShowDialog( ) == DialogResult.OK && !string.IsNullOrWhiteSpace( fbd.SelectedPath ) ) {
                    folderPath = fbd.SelectedPath;
                    osuFolderLabel.Text = folderPath;
                }
            }
        }

        private void executeButtonPress( object sender, EventArgs e ) {

            try {

                var mapDirectories = GetDirectories( );

                switch ( cbType.SelectedIndex ) {
                    case 0:
                        CreatePowershellScript( mapDirectories );
                        break;
                    case 1:
                        CreatePackagerScript( mapDirectories );
                        break;
                }
            }
            catch ( Exception exception ) {

                MessageBox.Show( exception.Message );
            }
        }

        private void CreatePackagerScript( string[ ] dirs ) {

            using ( StreamWriter sw = new( $@"{dirInfo.FullName}\downloadMaps.pack", false ) ) {

                ResizeProgressBar( dirs.Length );
                foreach ( var directory in dirs ) {
                    string folderName = directory.Split( @"\" ).Last( );
                    sw.Write( $"{folderName};" );
                    progressBar.Value++;
                }
            }
            Process.Start( "explorer.exe", dirInfo.FullName );
        }

        private void CreatePowershellScript( string[ ] dirs ) {


            using ( StreamWriter sw = new( $@"{dirInfo.FullName}\downloadMaps.ps1", false ) ) {

                sw.WriteLine( $"$downloadDirectory = Join-Path -Path $PSScriptRoot -ChildPath \"songs\"\n" +
                    $"if (-not (Test-Path -Path $downloadDirectory)) {{\r\n    New-Item -Path $downloadDirectory -ItemType Directory\r\n}}" );

                ResizeProgressBar( dirs.Length );
                foreach ( var dir in dirs ) {

                    string folderName = dir.Split( @"\" ).Last( );
                    string outputName = $@"{dirInfo.FullName}\{folderName}.osz";

                    if ( !File.Exists( outputName ) ) {

                        string
                        writeString = $"Invoke-WebRequest -Uri \"https://beatconnect.io/b/{folderName.Split( ' ' )[ 0 ]}/\" -OutFile \"$downloadDirectory\\{folderName}.osz\"\n";
                        writeString += $"Write-Host \"Downloaded: {folderName}\"\n";

                        sw.WriteLine( writeString );
                    }
                    progressBar.Value++;
                }
            }

            Process.Start( "explorer.exe", dirInfo.FullName );
        }

        private string[ ] GetDirectories( ) {

            if ( string.IsNullOrWhiteSpace( folderPath ) )
                throw new Exception( "Please choose the osu \"Songs\" folder first!" );

            string[ ] dirs = Directory.GetDirectories( folderPath );

            if ( dirs.Length <= 0 )
                throw new Exception( "Chosen beatmap directory does not contain any maps" );

            return dirs;
        }

        private void OnLoad( object sender, EventArgs e ) {

            comboTooltip.SetToolTip( cbType, "PowerShell script: Creates a standalone powershell script (slower)\nPackager script: Creates a packager script that can be imported in that application (faster download)" );
            cbType.SelectedIndex = 0;
        }

        private async Task ReadMapPackFile( string[] mapPack ) {

            var dir = Directory.CreateDirectory( $"{dirInfo.FullName}/songs" );

            foreach ( var item in mapPack ) {

                if ( item == mapPack.Last( ) )
                    continue;

                if ( File.Exists( $"{dirInfo.FullName}/songs/{item}.osz" ) )
                    continue;

                WebClient currentClient = new( );
                currentClient.DownloadFileAsync( new Uri( $"https://beatconnect.io/b/{item.Split(' ').First()}/" ), $"{dirInfo.FullName}/songs/{item}.osz" );
                currentClient.DownloadFileCompleted += DisposeOnComplete;
            }
            Process.Start( "explorer.exe", dir.FullName );
        }

        private void DisposeOnComplete( object? sender, System.ComponentModel.AsyncCompletedEventArgs e ) {
            (sender as WebClient)!.Dispose();
            progressBar.Value++;
        }

        private void OnImport( object sender, EventArgs e ) {

            try {
                using ( var fileDialog = new OpenFileDialog( ) { Multiselect = false } ) {

                    if ( fileDialog.ShowDialog( ) == DialogResult.OK ) {

                        if ( !fileDialog.FileName.Contains( ".pack" ) )
                            throw new Exception( $"Invalid file: {fileDialog.FileName.Split(@"\").Last()}" );

                        using ( StreamReader sr = new( fileDialog.OpenFile() ) ) {
                            var readFile = sr.ReadLine( )!.Split( ';' )!;
                            ResizeProgressBar( readFile.Length - 1 );
                            ReadMapPackFile( readFile ).Wait();
                        }
                    }
                }
            } catch ( Exception ex ) {

                MessageBox.Show( ex.Message );
            }
        }

        private void ResizeProgressBar( int newSize ) {

            progressBar.Maximum = newSize;
            progressBar.Value = 0;
        }
    }
}
