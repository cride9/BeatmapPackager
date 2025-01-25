using System;
using System.Diagnostics;
using System.Net;
using System.Web;

namespace BeatmapPackager {
    public partial class MainForm : Form
    {
        public MainForm() =>
            InitializeComponent();

        static int progressedSongs = 0;
        string folderPath = string.Empty;
        DirectoryInfo dirInfo = new(AppDomain.CurrentDomain.BaseDirectory);
        List<WebClient> currentDownloads = new();

        private void sourceButtonPress(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {

                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath;
                    if (osuFolderLabel.Text.Length > 0)
                        osuFolderLabel.Text = folderPath;
                }
            }
        }

        private void executeButtonPress(object sender, EventArgs e)
        {

            try
            {

                var mapDirectories = GetDirectories();

                switch (cbType.SelectedIndex)
                {
                    case 0:
                        CreatePowershellScript(mapDirectories);
                        break;
                    case 1:
                        CreatePackagerScript(mapDirectories);
                        break;
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void CreatePackagerScript(string[] dirs)
        {

            using (StreamWriter sw = new($@"{dirInfo.FullName}\downloadMaps.pack", false))
            {

                ResizeProgressBar(dirs.Length);
                foreach (var directory in dirs)
                {
                    string folderName = directory.Split(@"\").Last();
                    sw.Write($"{folderName};");
                    progressBar.Value++;
                }
            }
            Process.Start("explorer.exe", dirInfo.FullName);
        }

        private void CreatePowershellScript(string[] dirs)
        {


            using (StreamWriter sw = new($@"{dirInfo.FullName}\downloadMaps.ps1", false))
            {

                sw.WriteLine($"$downloadDirectory = Join-Path -Path $PSScriptRoot -ChildPath \"songs\"\n" +
                    $"if (-not (Test-Path -Path $downloadDirectory)) {{\r\n    New-Item -Path $downloadDirectory -ItemType Directory\r\n}}");

                ResizeProgressBar(dirs.Length);
                foreach (var dir in dirs)
                {

                    string folderName = dir.Split(@"\").Last();
                    string outputName = $@"{dirInfo.FullName}\{folderName}.osz";

                    if (!File.Exists(outputName))
                    {

                        string
                        writeString = $"Invoke-WebRequest -Uri \"https://beatconnect.io/b/{folderName.Split(' ')[0]}/\" -OutFile \"$downloadDirectory\\{folderName}.osz\"\n";
                        writeString += $"Write-Host \"Downloaded: {folderName}\"\n";

                        sw.WriteLine(writeString);
                    }
                    progressBar.Value++;
                }
            }

            Process.Start("explorer.exe", dirInfo.FullName);
        }

        private string[] GetDirectories()
        {

            if (string.IsNullOrWhiteSpace(folderPath))
                throw new Exception("Please choose the osu \"Songs\" folder first!");

            string[] dirs = Directory.GetDirectories(folderPath);

            if (dirs.Length <= 0)
                throw new Exception("Chosen beatmap directory does not contain any maps");

            return dirs;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            osuDownloadedItems.Text = String.Empty;
            comboTooltip.SetToolTip(cbType, "PowerShell script: Creates a standalone powershell script (slower)\nPackager script: Creates a packager script that can be imported in that application (faster download)");
            cbType.SelectedIndex = 0;
        }

        private Task ReadMapPackFile(string[] mapPack)
        {

            var dir = Directory.CreateDirectory($"{dirInfo.FullName}/songs");
            Process.Start("explorer.exe", dir.FullName);

            foreach (var item in mapPack)
            {

                if (item == mapPack.Last())
                    continue;

                osuDownloadedItems.AppendText(item + Environment.NewLine);

                if (File.Exists($"{dirInfo.FullName}/songs/{item}.osz"))
                {
                    progressedSongs++;
                    continue;
                }

                WebClient currentClient = new();
                Task downloadTask = currentClient.DownloadFileTaskAsync(new Uri($"https://beatconnect.io/b/{item.Split(' ').First()}/"), $"{dirInfo.FullName}/songs/{item}.osz");
                currentClient.DownloadFileCompleted += DisposeOnComplete;

                currentDownloads.Add(currentClient);
                while (currentDownloads.Count >= 5)
                {

                    currentDownloads.RemoveAll(match => !match.IsBusy);
                    continue;
                }
            }

            return Task.CompletedTask;
        }

        private void DisposeOnComplete(object? sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            WebClient current = (sender as WebClient)!;
            currentDownloads.Remove(current);
            current.Dispose();
            progressedSongs++;
        }

        private void OnImport(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog() { Multiselect = false, Filter = "Pack Files (*.pack)|*.pack" })
            {

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    osuSelectedScriptLabel.Text = "Selected Script: " + fileDialog.FileName;
                    using (StreamReader sr = new(fileDialog.OpenFile()))
                    {
                        var readFile = sr.ReadLine()!.Split(';')!;

                        ResizeProgressBar(readFile.Length - 1);
                        Task.Run(() => ReadMapPackFile(readFile));
                    }
                }
            }
        }

        private void ResizeProgressBar(int newSize)
        {

            progressBar.Maximum = newSize;
            progressedSongs = progressBar.Value = 0;
        }

        private void ProgressBarTick(object sender, EventArgs e)
        {

            progressBar.Value = progressedSongs;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
