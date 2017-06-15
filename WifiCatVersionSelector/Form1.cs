#region Licence

// WifiCat - Wifi Cat Version Selector - Form1.cs
// Created 14.06.2017 19:08
// 
// 
// Wifi Configuration Assist Tool
// Copyright (C) 2017 Bennet Becker <bennet@becker-dd.de>
// 
// This program is free software: you can redistribute it and/or modify 
// it under the terms of the GNU Affero General Public License as published by 
// the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License 
// along with this program. If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Using

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Wifi_Cat_Version_Selector.Properties;

#endregion

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
            using (var wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                if (Environment.Is64BitOperatingSystem)
                {
                    wc.DownloadFileAsync(new Uri(Config.URL64), Path.GetTempPath() + "wificat.exe");
                }
                else
                {
                    wc.DownloadFileAsync(new Uri(Config.URL32), Path.GetTempPath() + "wificat.exe");
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