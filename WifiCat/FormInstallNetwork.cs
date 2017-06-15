#region Licence

// WifiCat - WifiCat - FormInstallNetwork.cs
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
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using NativeWifi;
using WifiCat.Properties;

#endregion

namespace WifiCat
{
    public partial class FormInstallNetwork : Form
    {
        private WlanClient wlanClient;

        public FormInstallNetwork()
        {
            InitializeComponent();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInstallNetwork_Load(object sender, EventArgs e)
        {
            wlanClient = new WlanClient();
            cb_wifiinterface.DataSource = wlanClient.Interfaces;

            cb_wifiinterface.DisplayMember = "DisplayName";
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
#if (DISALLOW_PASTE)
            if (e.KeyData == (Keys.Control | Keys.V))
            {
                e.Handled = false;
            }
            #endif
            if (e.KeyData == (Keys.Control | Keys.Back))
                tb_username.Text = tb_password.Text.Substring(tb_password.SelectionStart);
            if (e.KeyData == (Keys.Control | Keys.Delete))
            {
                var i = tb_username.SelectionStart;
                tb_username.Text = tb_password.Text.Substring(0, tb_username.SelectionStart);
                tb_username.SelectionStart = i;
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
#if (DISALLOW_PASTE)
            if (e.KeyData == (Keys.Control | Keys.V))
            {
                e.Handled = false;
            }
            #endif
            if (e.KeyData == (Keys.Control | Keys.Back))
                tb_password.Text = tb_password.Text.Substring(tb_password.SelectionStart);
            if (e.KeyData == (Keys.Control | Keys.Delete))
            {
                var i = tb_password.SelectionStart;
                tb_password.Text = tb_password.Text.Substring(0, tb_password.SelectionStart);
                tb_password.SelectionStart = i;
            }
        }

        private void b_install_network_Click(object sender, EventArgs e)
        {
            var name = (from el in XDocument.Parse(Resources.profile).Root.Elements()
                where el.Name.LocalName.Equals("name")
                select el.Value).FirstOrDefault();

            var profileXml =
                Resources.default_eap_userdata.Replace("{USERNAME}", tb_username.Text)
                    .Replace("{PASSWORD}", tb_password.Text).Replace("{SSID}", name);
            var instProf =
                ((WlanClient.WlanInterface) cb_wifiinterface.SelectedItem).SetProfile(Wlan.WlanProfileFlags.AllUser,
                    Resources.profile, true);
            var s = true;
            try
            {
                ((WlanClient.WlanInterface) cb_wifiinterface.SelectedItem).SetProfileEapXmlUserData(
                    Wlan.WlanProfileEapXmlUserDataFlags.Zero,
                    name,
                    profileXml);
            }
            catch (Exception err)
            {
                s = false;
            }
            try
            {
                ((WlanClient.WlanInterface) cb_wifiinterface.SelectedItem).DeleteProfile(Resources.SSID_TO_DELETE);
            }
            catch { }

            if (instProf == Wlan.WlanReasonCode.Success && s)
            {
                MessageBox.Show(Resources.FormInstallNetwork_b_install_network_Click_Network_Installed_successfully_,
                    Resources.FormInstallNetwork_b_install_network_Click_Done, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tb_username.Enabled = false;
                tb_password.Enabled = false;
                cb_wifiinterface.Enabled = false;
                b_install_network.Enabled = false;
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
