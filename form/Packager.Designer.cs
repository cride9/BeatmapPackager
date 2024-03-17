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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            osuFolderLabel = new Label( );
            osuFolderButton = new Button( );
            outputFolderLabel = new Label( );
            outputFolderButton = new Button( );
            outputTextbox = new RichTextBox( );
            ExecuteButton = new Button( );
            SuspendLayout( );
            // 
            // osuFolderLabel
            // 
            osuFolderLabel.AutoSize = true;
            osuFolderLabel.Location = new Point( 12, 25 );
            osuFolderLabel.Name = "osuFolderLabel";
            osuFolderLabel.Size = new Size( 196, 14 );
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
            // outputFolderLabel
            // 
            outputFolderLabel.AutoSize = true;
            outputFolderLabel.Location = new Point( 12, 72 );
            outputFolderLabel.Name = "outputFolderLabel";
            outputFolderLabel.Size = new Size( 210, 14 );
            outputFolderLabel.TabIndex = 3;
            outputFolderLabel.Text = "Choose a destination folder: ";
            // 
            // outputFolderButton
            // 
            outputFolderButton.FlatStyle = FlatStyle.Flat;
            outputFolderButton.Location = new Point( 228, 59 );
            outputFolderButton.Name = "outputFolderButton";
            outputFolderButton.Size = new Size( 155, 41 );
            outputFolderButton.TabIndex = 2;
            outputFolderButton.Text = "Select output folder..";
            outputFolderButton.UseVisualStyleBackColor = true;
            outputFolderButton.Click +=  destinationButtonPress ;
            // 
            // outputTextbox
            // 
            outputTextbox.BackColor = Color.FromArgb(     30,     30,     30 );
            outputTextbox.ForeColor = Color.FromArgb(     255,     128,     128 );
            outputTextbox.Location = new Point( 12, 153 );
            outputTextbox.Name = "outputTextbox";
            outputTextbox.ReadOnly = true;
            outputTextbox.Size = new Size( 371, 189 );
            outputTextbox.TabIndex = 4;
            outputTextbox.Text = "";
            outputTextbox.WordWrap = false;
            // 
            // ExecuteButton
            // 
            ExecuteButton.FlatStyle = FlatStyle.Flat;
            ExecuteButton.Location = new Point( 12, 106 );
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size( 371, 41 );
            ExecuteButton.TabIndex = 5;
            ExecuteButton.Text = "Make beatmap downloader";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click +=  executeButtonPress ;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(     25,     25,     25 );
            ClientSize = new Size( 395, 354 );
            Controls.Add( ExecuteButton );
            Controls.Add( outputTextbox );
            Controls.Add( outputFolderLabel );
            Controls.Add( outputFolderButton );
            Controls.Add( osuFolderLabel );
            Controls.Add( osuFolderButton );
            Font = new Font( "Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point,   238 );
            ForeColor = Color.FromArgb(     212,     212,     212 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = ( Icon )resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Beatmap Packager";
            TopMost = true;
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion
        private Label osuFolderLabel;
        private Button osuFolderButton;
        private Label outputFolderLabel;
        private Button outputFolderButton;
        private RichTextBox outputTextbox;
        private Button ExecuteButton;
    }
}
