using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using NativeWifi;
using WifiCat.Properties;

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

            if (instProf == Wlan.WlanReasonCode.Success && s)
            {
                MessageBox.Show(Resources.FormInstallNetwork_b_install_network_Click_Network_Installed_successfully_,
                    Resources.FormInstallNetwork_b_install_network_Click_Done, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tb_username.Enabled = false;
                tb_password.Enabled = false;
                cb_wifiinterface.Enabled = false;
                b_install_network.Enabled = false;
                ((WlanClient.WlanInterface)cb_wifiinterface.SelectedItem).DeleteProfile(Properties.Resources.SSID_TO_DELETE);
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}