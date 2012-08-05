using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace YoutubeDownloader
{
    public enum FileType
    {
        flv, mov, avi, mp4, mp3, wmv
    }

    public class Downloader
    {
        public delegate void onSuccessDownload(object sender, DownloadEventArgs e);
        public delegate void onFailedDownload(object sender, DownloadEventArgs e);
        public delegate void onDownloadProgress(object sender, ProgressEventArgs e);

        /// <summary>
        /// Triggers when download is Successful.
        /// </summary>
        public event onSuccessDownload Success;
        /// <summary>
        /// Triggers when download is Failed.
        /// </summary>
        public event onFailedDownload Failed;
        /// <summary>
        /// Triggers when download is going on
        /// </summary>
        public event onDownloadProgress Progress;

        private string _location = string.Empty;
        private string _url = string.Empty;
        private string _name = string.Empty;
        private FileType _type;
        private byte[] downloadedData = null;

        /// <summary>
        /// Contains the youtube url to download
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this._url = value;
            }
        }
        /// <summary>
        /// File type Extension of the file to download
        /// </summary>
        public FileType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        /// <summary>
        /// Contains the downloaded file
        /// </summary>
        public byte[] File
        {
            get
            {
                if (this.downloadedData != null)
                    return this.downloadedData;
                return null;
            }
        }
        /// <summary>
        /// Set the file name of the file
        /// </summary>
        public string FileName
        {
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this._name = value; 
                }
            }
        }

        public Downloader()
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string target = Path + "\\Youtube Downloads\\";
            if (!Directory.Exists(target))
                Directory.CreateDirectory(target);
            _location = target;
        }

        public Downloader(string Url, FileType Type) : this()
        {
            this.Url = Url;
            this.Type = Type;
        }

        /// <summary>
        /// Initiate download from given Url and Type
        /// </summary>
        public void Download() 
        {
            try 
            {
                HttpWebRequest request = WebRequest.Create(new Uri(Url)) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    Stream streamedData = response.GetResponseStream();

                    // downloading by 1KB 
                    byte[] buffer = new byte[1024];

                    int dataLength = (int)response.ContentLength;

                    using (MemoryStream memory = new MemoryStream())
                    {

                        int readData = 0;
                        bool onSuccess = false;
                        // loop until the data has been downloaded
                        while (true)
                        {
                            readData = streamedData.Read(buffer, 0, buffer.Length);

                            if (readData == 0)
                            {
                                // data has been succesfuly downloaded
                                // success
                                onSuccess = true;
                                break;
                            }
                            else
                            {
                                // data is under process
                                memory.Write(buffer, 0, readData);

                                Progress("Download.Download.Progress", new ProgressEventArgs(readData));
                            }
                        }
                        downloadedData = memory.ToArray();
                        if (onSuccess)
                            Success("Downloader.Download.Success", new DownloadEventArgs("Download successful", downloadedData));
                    
                        streamedData.Close();
                    }
                }
            } catch (Exception ex) {
                Failed("Downloader.Download.Failed", new DownloadEventArgs(String.Format("Download failed due to an Exception [ details: {0} ]", ex.Message), null));
            }
        }
        /// <summary>
        /// Get the type selected by user base in Combo box 
        /// </summary>
        /// <param name="selectedText"></param>
        /// <returns></returns>
        public FileType GetType(string selectedText)
        {
            // default type is flv.
            FileType type = FileType.flv;
            string filetype = selectedText;
            switch (filetype)
            {
                case ".flv":
                    type = FileType.flv;
                    break;
                case ".mov":
                    type = FileType.mov;
                    break;
                case ".avi":
                    type = FileType.avi;
                    break;
                case ".mp4":
                    type = FileType.mp4;
                    break;
                case ".mp3":
                    type = FileType.mp3;
                    break;
                case ".wmv":
                    type = FileType.wmv;
                    break;
                default:
                    break;
            }
            return type;
        }
        /// <summary>
        /// Refresh data for next process
        /// </summary>
        public void Refresh()
        {
            this._name = string.Empty;
            this._url = string.Empty;
            this._name = string.Empty;
            this.downloadedData = null;
        }
        /// <summary>
        /// Save data to default location
        /// </summary>
        public bool Save()
        {
            bool flag = false;

            using (FileStream filetoSave = new FileStream(String.Format("{0}{1}.{2}",_location, _name, Type.ToString()), FileMode.Create))
            {
                filetoSave.Write(downloadedData, 0, downloadedData.Length);
                flag = true;
            }
            return flag;
        }
    }

    public class DownloadEventArgs
    {
        private string _message = string.Empty;
        private byte[] _data = null;

        public string Message
        {
            get { return this._message; }
        }

        public byte[] Data
        {
            get { return this._data; }
        }

        public DownloadEventArgs(string Message, byte[] Data)
        {
            this._message = Message;
            this._data = Data;
        }
    }

    public class ProgressEventArgs
    {
        private int _progress = 0;
        public int Progress
        {
            get { return this._progress; }
        }

        public ProgressEventArgs(int progress)
        {
            this._progress = progress;
        }
    }
}
