namespace YoutubeDownloader
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.YoutubeLink = new System.Windows.Forms.TextBox();
            this.FileTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDownloadLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.progressPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(225, 152);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Padding = new System.Windows.Forms.Padding(2);
            this.DownloadBtn.Size = new System.Drawing.Size(75, 47);
            this.DownloadBtn.TabIndex = 4;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // YoutubeLink
            // 
            this.YoutubeLink.Location = new System.Drawing.Point(12, 152);
            this.YoutubeLink.Name = "YoutubeLink";
            this.YoutubeLink.Size = new System.Drawing.Size(208, 20);
            this.YoutubeLink.TabIndex = 1;
            this.YoutubeLink.TextChanged += new System.EventHandler(this.YoutubeLink_TextChanged);
            // 
            // FileTypeBox
            // 
            this.FileTypeBox.FormattingEnabled = true;
            this.FileTypeBox.Items.AddRange(new object[] {
            ".flv",
            ".mov",
            ".avi",
            ".mp3",
            ".mp4",
            ".wmv"});
            this.FileTypeBox.Location = new System.Drawing.Point(144, 178);
            this.FileTypeBox.Name = "FileTypeBox";
            this.FileTypeBox.Size = new System.Drawing.Size(75, 21);
            this.FileTypeBox.TabIndex = 3;
            this.FileTypeBox.Text = "File Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Youtube link to download";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YoutubeDownloader.Properties.Resources.youtube;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(20, 54);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(251, 23);
            this.progress.TabIndex = 7;
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.label1);
            this.progressPanel.Controls.Add(this.progress);
            this.progressPanel.Location = new System.Drawing.Point(12, 120);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(288, 92);
            this.progressPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Downloading...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDownloadsToolStripMenuItem,
            this.editDownloadLocationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openDownloadsToolStripMenuItem
            // 
            this.openDownloadsToolStripMenuItem.Name = "openDownloadsToolStripMenuItem";
            this.openDownloadsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openDownloadsToolStripMenuItem.Text = "&Open downloads";
            this.openDownloadsToolStripMenuItem.Click += new System.EventHandler(this.openDownloadsToolStripMenuItem_Click);
            // 
            // editDownloadLocationToolStripMenuItem
            // 
            this.editDownloadLocationToolStripMenuItem.Name = "editDownloadLocationToolStripMenuItem";
            this.editDownloadLocationToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.editDownloadLocationToolStripMenuItem.Text = "&Edit download location";
            this.editDownloadLocationToolStripMenuItem.Click += new System.EventHandler(this.editDownloadLocationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(12, 179);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(126, 20);
            this.FileName.TabIndex = 2;
            this.FileName.TextChanged += new System.EventHandler(this.FileName_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 225);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileTypeBox);
            this.Controls.Add(this.YoutubeLink);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.FileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.TextBox YoutubeLink;
        private System.Windows.Forms.ComboBox FileTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDownloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDownloadLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox FileName;
    }
}

