using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO.Compression;

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

                var dirs = GetDirectories( );

                using ( StreamWriter sw = new( $@"{dirInfo.FullName}\downloadMaps.ps1", false ) ) {

                    sw.WriteLine(
                        $"$downloadDirectory = $PSScriptRoot"
                        );

                    foreach ( var dir in dirs ) {

                        string folderName = dir.Split( @"\" ).Last( );
                        string outputName = $@"{dirInfo.FullName}\{folderName}.osz";
                        string sourceFolder = $@"{folderPath}\{folderName}";

                        if ( !File.Exists( outputName ) ) {

                            string 
                            writeString = $"Invoke-WebRequest -Uri \"https://beatconnect.io/b/{folderName.Split( ' ' )[ 0 ]}/\" -OutFile \"$downloadDirectory\\{folderName}.osz\"\n";
                            writeString += $"Write-Host \"Downloaded: {folderName}\"\n";

                            sw.WriteLine( writeString );
                            PrintMessage( writeString );
                        }
                    }
                }

                Process.Start( "explorer.exe", dirInfo.FullName );
            } catch ( Exception exception ) {

                MessageBox.Show( exception.Message );
            }
        }

        private string[ ] GetDirectories() {

            if ( string.IsNullOrWhiteSpace( folderPath ) )
                throw new Exception( "Please choose the osu \"Songs\" folder first!" );

            string[ ] dirs = Directory.GetDirectories( folderPath );

            if ( dirs.Length <= 0 )
                throw new Exception( "Chosen beatmap directory does not contain any maps" );

            if ( !dirInfo.Exists ) {

                DialogResult result = MessageBox.Show( "Would you like to create the output folder?", "Output folder not found", MessageBoxButtons.YesNo );
                if ( result == DialogResult.Yes )
                    dirInfo.Create( );
                else
                    throw new Exception( "Chosen output folder not found or not created yet!" );

            }

            return dirs;
        }

        private void PrintMessage( string message, bool error = false ) {

            if ( !error ) {
                outputTextbox.ForeColor = Color.FromArgb( 255, 0, 192, 0 );
                outputTextbox.Text += message;
                return;
            }

            outputTextbox.ForeColor = Color.FromArgb( 255, 255, 128, 128 );
            outputTextbox.Text += message;
        }
    }
}
