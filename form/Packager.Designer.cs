namespace BeatmapPackager {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            osuFolderButton = new Button();
            ExecuteButton = new Button();
            cbType = new ComboBox();
            comboTooltip = new ToolTip(components);
            downloadButton = new Button();
            progressBar = new ProgressBar();
            ProgressUpdate = new System.Windows.Forms.Timer(components);
            osuTitle = new Label();
            osuDownloadedItems = new TextBox();
            osuSelectedScriptLabel = new Label();
            osuSelectedSongsFolderLabel = new Label();
            osuDownloadButton = new Button();
            osuExitButton = new Button();
            SuspendLayout();
            // 
            // osuFolderButton
            // 
            osuFolderButton.BackColor = Color.FromArgb(35, 35, 35);
            osuFolderButton.FlatAppearance.BorderSize = 0;
            osuFolderButton.FlatStyle = FlatStyle.Flat;
            osuFolderButton.Font = new Font("Arial", 10F);
            osuFolderButton.Location = new Point(191, 92);
            osuFolderButton.Name = "osuFolderButton";
            osuFolderButton.Size = new Size(141, 27);
            osuFolderButton.TabIndex = 0;
            osuFolderButton.Text = "Select songs folder";
            osuFolderButton.UseVisualStyleBackColor = false;
            osuFolderButton.Click += sourceButtonPress;
            // 
            // ExecuteButton
            // 
            ExecuteButton.BackColor = Color.FromArgb(35, 35, 35);
            ExecuteButton.FlatAppearance.BorderSize = 0;
            ExecuteButton.FlatStyle = FlatStyle.Flat;
            ExecuteButton.Font = new Font("Arial", 10F);
            ExecuteButton.Location = new Point(191, 125);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(141, 27);
            ExecuteButton.TabIndex = 5;
            ExecuteButton.Text = "Create script";
            ExecuteButton.UseVisualStyleBackColor = false;
            ExecuteButton.Click += executeButtonPress;
            // 
            // cbType
            // 
            cbType.BackColor = Color.FromArgb(30, 30, 30);
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FlatStyle = FlatStyle.Flat;
            cbType.Font = new Font("Arial", 10F);
            cbType.ForeColor = Color.White;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "PowerShell script", "Packager script" });
            cbType.Location = new Point(15, 127);
            cbType.Name = "cbType";
            cbType.Size = new Size(141, 24);
            cbType.TabIndex = 6;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = Color.FromArgb(35, 35, 35);
            downloadButton.FlatAppearance.BorderSize = 0;
            downloadButton.FlatStyle = FlatStyle.Flat;
            downloadButton.Font = new Font("Arial", 10F);
            downloadButton.Location = new Point(15, 92);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(141, 27);
            downloadButton.TabIndex = 7;
            downloadButton.Text = "Import from pack";
            downloadButton.UseVisualStyleBackColor = false;
            downloadButton.Click += OnImport;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(25, 25, 25);
            progressBar.Location = new Point(12, 309);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(510, 10);
            progressBar.Step = 1;
            progressBar.TabIndex = 8;
            progressBar.Click += progressBar_Click;
            // 
            // ProgressUpdate
            // 
            ProgressUpdate.Enabled = true;
            ProgressUpdate.Tick += ProgressBarTick;
            // 
            // osuTitle
            // 
            osuTitle.AutoSize = true;
            osuTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            osuTitle.Location = new Point(9, 12);
            osuTitle.Name = "osuTitle";
            osuTitle.Size = new Size(153, 19);
            osuTitle.TabIndex = 9;
            osuTitle.Text = "Beatmap Packager";
            // 
            // osuDownloadedItems
            // 
            osuDownloadedItems.BackColor = Color.FromArgb(35, 35, 35);
            osuDownloadedItems.Font = new Font("Consolas", 8F);
            osuDownloadedItems.ForeColor = Color.White;
            osuDownloadedItems.Location = new Point(12, 202);
            osuDownloadedItems.Multiline = true;
            osuDownloadedItems.Name = "osuDownloadedItems";
            osuDownloadedItems.Size = new Size(510, 101);
            osuDownloadedItems.TabIndex = 13;
            // 
            // osuSelectedScriptLabel
            // 
            osuSelectedScriptLabel.AutoSize = true;
            osuSelectedScriptLabel.Font = new Font("Arial", 9F);
            osuSelectedScriptLabel.Location = new Point(12, 58);
            osuSelectedScriptLabel.Name = "osuSelectedScriptLabel";
            osuSelectedScriptLabel.Size = new Size(137, 15);
            osuSelectedScriptLabel.TabIndex = 14;
            osuSelectedScriptLabel.Text = "Selected Script..............: ";
            // 
            // osuSelectedSongsFolderLabel
            // 
            osuSelectedSongsFolderLabel.AutoSize = true;
            osuSelectedSongsFolderLabel.Font = new Font("Arial", 9F);
            osuSelectedSongsFolderLabel.Location = new Point(12, 43);
            osuSelectedSongsFolderLabel.Name = "osuSelectedSongsFolderLabel";
            osuSelectedSongsFolderLabel.Size = new Size(138, 15);
            osuSelectedSongsFolderLabel.TabIndex = 15;
            osuSelectedSongsFolderLabel.Text = "Selected Songs Folder: ";
            // 
            // osuDownloadButton
            // 
            osuDownloadButton.BackColor = Color.FromArgb(35, 35, 35);
            osuDownloadButton.FlatAppearance.BorderSize = 0;
            osuDownloadButton.FlatStyle = FlatStyle.Flat;
            osuDownloadButton.Font = new Font("Arial", 10F);
            osuDownloadButton.Location = new Point(15, 158);
            osuDownloadButton.Name = "osuDownloadButton";
            osuDownloadButton.Size = new Size(141, 27);
            osuDownloadButton.TabIndex = 16;
            osuDownloadButton.Text = "Start download";
            osuDownloadButton.UseVisualStyleBackColor = false;
            osuDownloadButton.Click += button1_Click;
            // 
            // osuExitButton
            // 
            osuExitButton.FlatAppearance.BorderSize = 0;
            osuExitButton.FlatStyle = FlatStyle.Flat;
            osuExitButton.Font = new Font("Arial", 10F);
            osuExitButton.Location = new Point(498, 12);
            osuExitButton.Name = "osuExitButton";
            osuExitButton.Size = new Size(24, 23);
            osuExitButton.TabIndex = 17;
            osuExitButton.Text = "x";
            osuExitButton.UseVisualStyleBackColor = true;
            osuExitButton.Click += osuExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(534, 330);
            Controls.Add(osuExitButton);
            Controls.Add(osuDownloadButton);
            Controls.Add(osuSelectedSongsFolderLabel);
            Controls.Add(osuSelectedScriptLabel);
            Controls.Add(osuDownloadedItems);
            Controls.Add(osuTitle);
            Controls.Add(progressBar);
            Controls.Add(downloadButton);
            Controls.Add(cbType);
            Controls.Add(ExecuteButton);
            Controls.Add(osuFolderButton);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.FromArgb(212, 212, 212);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beatmap Packager";
            TopMost = true;
            Load += OnLoad;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button osuFolderButton;
        private Button ExecuteButton;
        private ComboBox cbType;
        private ToolTip comboTooltip;
        private Button downloadButton;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer ProgressUpdate;
        private Label osuTitle;
        private Label osuFolderLabel;
        private TextBox osuDownloadedItems;
        private Label osuSelectedScriptLabel;
        private Label osuSelectedSongsFolderLabel;
        private Button osuDownloadButton;
        private Button osuExitButton;
    }
}
