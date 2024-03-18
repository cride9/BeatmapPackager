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
        private void InitializeComponent( ) {
            components = new System.ComponentModel.Container( );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            osuFolderLabel = new Label( );
            osuFolderButton = new Button( );
            ExecuteButton = new Button( );
            cbType = new ComboBox( );
            comboTooltip = new ToolTip( components );
            downloadButton = new Button( );
            progressBar = new ProgressBar( );
            label1 = new Label( );
            SuspendLayout( );
            // 
            // osuFolderLabel
            // 
            osuFolderLabel.Location = new Point( 12, 25 );
            osuFolderLabel.Name = "osuFolderLabel";
            osuFolderLabel.Size = new Size( 210, 14 );
            osuFolderLabel.TabIndex = 1;
            osuFolderLabel.Text = "Choose osu beatmap folder: ";
            // 
            // osuFolderButton
            // 
            osuFolderButton.FlatStyle = FlatStyle.Flat;
            osuFolderButton.Location = new Point( 228, 12 );
            osuFolderButton.Name = "osuFolderButton";
            osuFolderButton.Size = new Size( 155, 41 );
            osuFolderButton.TabIndex = 0;
            osuFolderButton.Text = "Select songs folder";
            osuFolderButton.UseVisualStyleBackColor = true;
            osuFolderButton.Click +=  sourceButtonPress ;
            // 
            // ExecuteButton
            // 
            ExecuteButton.FlatStyle = FlatStyle.Flat;
            ExecuteButton.Location = new Point( 12, 42 );
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size( 104, 39 );
            ExecuteButton.TabIndex = 5;
            ExecuteButton.Text = "Create script";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click +=  executeButtonPress ;
            // 
            // cbType
            // 
            cbType.BackColor = Color.FromArgb(     30,     30,     30 );
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FlatStyle = FlatStyle.Flat;
            cbType.ForeColor = Color.FromArgb(     212,     212,     212 );
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange( new object[ ] { "PowerShell script", "Packager script" } );
            cbType.Location = new Point( 209, 59 );
            cbType.Name = "cbType";
            cbType.Size = new Size( 174, 22 );
            cbType.TabIndex = 6;
            // 
            // downloadButton
            // 
            downloadButton.FlatStyle = FlatStyle.Flat;
            downloadButton.Location = new Point( 122, 42 );
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size( 81, 39 );
            downloadButton.TabIndex = 7;
            downloadButton.Text = "Import from pack";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click +=  OnImport ;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(     25,     25,     25 );
            progressBar.Location = new Point( 12, 101 );
            progressBar.Name = "progressBar";
            progressBar.Size = new Size( 371, 23 );
            progressBar.Step = 1;
            progressBar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point( 12, 84 );
            label1.Name = "label1";
            label1.Size = new Size( 63, 14 );
            label1.TabIndex = 9;
            label1.Text = "Progress";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(     25,     25,     25 );
            ClientSize = new Size( 395, 136 );
            Controls.Add( label1 );
            Controls.Add( progressBar );
            Controls.Add( downloadButton );
            Controls.Add( cbType );
            Controls.Add( ExecuteButton );
            Controls.Add( osuFolderLabel );
            Controls.Add( osuFolderButton );
            Font = new Font( "Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point,   238 );
            ForeColor = Color.FromArgb(     212,     212,     212 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = ( Icon )resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beatmap Packager";
            TopMost = true;
            Load +=  OnLoad ;
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion
        private Label osuFolderLabel;
        private Button osuFolderButton;
        private Button ExecuteButton;
        private ComboBox cbType;
        private ToolTip comboTooltip;
        private Button downloadButton;
        private ProgressBar progressBar;
        private Label label1;
    }
}
