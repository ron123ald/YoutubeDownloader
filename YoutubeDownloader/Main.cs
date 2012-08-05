using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace YoutubeDownloader
{
    public partial class Main : Form
    {
        Downloader fileDownloader = null;
        
        /// <summary>
        /// http://www.codeintel.org/2011/03/download-video-from-youtube-use-c-and.html
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            fileDownloader = new Downloader();
            
            fileDownloader.Success += new Downloader.onSuccessDownload(fileDownloader_Success);
            fileDownloader.Failed += new Downloader.onFailedDownload(fileDownloader_Failed);
            fileDownloader.Progress += new Downloader.onDownloadProgress(fileDownloader_Progress);

            this.DownloadBtn.Enabled = false;
            this.FileTypeBox.Enabled = false;
            this.FileName.Enabled = false;
            this.progressPanel.Visible = false;
        }

        void fileDownloader_Progress(object sender, ProgressEventArgs e)
        {
            if (e.Progress <= progress.Maximum)
                this.Invoke((MethodInvoker)(() => { 
                    this.progress.Value = e.Progress;
                    this.progress.Refresh();
                })); 
        }

        void fileDownloader_Failed(object sender, DownloadEventArgs e)
        {
            if (DialogResult.Retry == MessageBox.Show(e.Message, "Download Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                // Retry download
                fileDownloader.Download();

            this.Invoke((MethodInvoker)(() => { this.progressPanel.Visible = false; }));
        }

        void fileDownloader_Success(object sender, DownloadEventArgs e)
        {
            this.Invoke((MethodInvoker)(() => { this.progress.Value = progress.Maximum; }));

            if (DialogResult.OK == MessageBox.Show(e.Message, "Youtube", MessageBoxButtons.OK, MessageBoxIcon.Information))
            {    // save data to disk
                fileDownloader.Save();
                fileDownloader.Refresh();
            }
            this.Invoke((MethodInvoker)(() => { this.progressPanel.Visible = false; }));
        }
        /// <summary>
        /// Execute when user click on Download
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (fileDownloader != null)
	        {
                fileDownloader.Url = this.YoutubeLink.Text;
                fileDownloader.Type = fileDownloader.GetType(this.FileTypeBox.SelectedText);
                fileDownloader.FileName = this.FileName.Text;

                // set this button to disable
                this.DownloadBtn.Enabled = false;
                // show progress
                this.progressPanel.Visible = true;
                // Initiate the download
                fileDownloader.Download();
                // set this button to enable 
                this.DownloadBtn.Enabled = true;
                this.YoutubeLink.Text = string.Empty;
	        }
        }
        /// <summary>
        /// Open Menu file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Edit file location of downloads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editDownloadLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YoutubeLink_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.YoutubeLink.Text))
            {
                FileTypeBox.Enabled = true;
                FileName.Enabled = true;
            }
            else
            {
                FileName.Enabled = false;
                FileTypeBox.Enabled = false;
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.FileName.Text))
                DownloadBtn.Enabled = true;
            else
                DownloadBtn.Enabled = false;
        }
    }
}
