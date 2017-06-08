using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi_Cat_Version_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                if (Environment.Is64BitOperatingSystem)
                {
                    wc.DownloadFileAsync(new Uri(Properties.Resources.URL64), Path.GetTempPath() + "wificat.exe");
                }
                else
                {
                    wc.DownloadFileAsync(new Uri(Properties.Resources.URL32), Path.GetTempPath() + "wificat.exe");
                }
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            }
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start(Path.GetTempPath() + "wificat.exe");
            Environment.Exit(0);
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
