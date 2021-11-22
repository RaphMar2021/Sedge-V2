using System;
using System.Windows.Forms;
using WindowsApp7;
using System.IO;
using Guna.UI2.WinForms;

namespace CefSharp.Example.Handlers
{
    public class DownloadHandler : IDownloadHandler
    {
        public static bool LaunchedFromDLHandler;

        public static bool DownloadEnded = true;

        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        NotifyIcon icon = new NotifyIcon();

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }

            if (downloadItem.IsValid)
            {
                DownloadEnded = false;
                //Va afficher des infos sur le fichier que Chromium va télécharger
                //Exemple:
                //== File information =================================
                // File URL: ubuntu.org/ubuntu-lts-2004.iso
                // Suggested FileName: ubuntu-lts-2004.iso
                // MimeType: ISO
                //
                Console.WriteLine("== File information ========================");
                Console.WriteLine(" File URL: {0}", downloadItem.Url);
                Console.WriteLine(" Suggested FileName: {0}", downloadItem.SuggestedFileName);
                Console.WriteLine(" MimeType: {0}", downloadItem.MimeType);
                Console.WriteLine(" Content Disposition: {0}", downloadItem.ContentDisposition);
                Console.WriteLine(" Total Size: {0}", downloadItem.TotalBytes);
                Console.WriteLine("============================================");
                //CurrentDownload cd = new CurrentDownload();
                //cd.Show();
                //cd.Hide();
                //cd.label1.Text = downloadItem.SuggestedFileName;
                //cd.label2.Text = downloadItem.MimeType;
                //cd.label3.Text = downloadItem.TotalBytes.ToString();
                LaunchedFromDLHandler = true;
                SipaFramework.SipaNotification toast = new SipaFramework.SipaNotification();
                toast.showAlert("Filename : " + downloadItem.SuggestedFileName, SipaFramework.SipaNotification.enmType.Info, "Sipaa Edge : Download started!", WindowsApp7.My.Resources.Resources.icons8_download_48);
            }

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    //Définit le chemin ou Chromium va télécharger le ficier
                    string DownloadsDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    callback.Continue(
                        Path.Combine(
                            DownloadsDirectoryPath,
                            downloadItem.SuggestedFileName
                        ),
                        showDialog: false
                    );
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);

            if (downloadItem.IsValid)
            {
                //Afficher la progression du téléchargement dans la console
                if (downloadItem.IsInProgress && (downloadItem.PercentComplete != 0))
                {
                    Console.WriteLine(
                        "Current Download Speed: {0} bytes ({1}%)",
                        downloadItem.CurrentSpeed,
                        downloadItem.PercentComplete
                    );
                    //CurrentDownload cd = new CurrentDownload();
                    //cd.label4.Text = downloadItem.CurrentSpeed.ToString();
                    //cd.guna2CircleProgressBar1.Value = downloadItem.PercentComplete;
                }

                if (downloadItem.IsComplete)
                {
                    DownloadEnded = true;
                    Console.WriteLine("The download has been finished !");
                    SipaFramework.SipaNotification toast = new SipaFramework.SipaNotification();
                    toast.showAlert("The download has been finished!", SipaFramework.SipaNotification.enmType.Info, "Sipaa Edge : Download finished!", WindowsApp7.My.Resources.Resources.icons8_download_48);
                }
            }
        }
    }
}
