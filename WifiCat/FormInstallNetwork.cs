using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WifiCat
{
    public partial class FormInstallNetwork : Form
    {
        private Dictionary<int, int> translateEapDictionary = new Dictionary<int, int>()
        {
            {5,50},{-1,-1},{0,25},{3,47},{4,18},{1,13},{2,21}
        };

        private XDocument xmlDocument;
        private string Ssid;
        private string AnonymousIdentity;

        private int EapMethod;
        private int Phase2Method;

        private string CaCertificate;
        private string UserCertificate;

        private string Domain;

        private bool DisallowPaste;
        private bool RequirePin;

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
            EAPConfig eapConfig = new EAPConfig();
            xmlDocument = new XDocument(
                new XDeclaration("1.0","utf-8", String.Empty),
                new XElement("WLANProfile",
                    new XElement("connectionType", "ESS"),
                    new XElement("connectionMode", "auto"),
                    new XElement("autoSwitch", "false"),
                    new XElement("MSM",
                        new XElement("security",
                            new XElement("authEncryption",
                                new XElement("authentication", "WPA2"),
                                new XElement("encryption", "AES"),
                                new XElement("useOneX", "true"),
                                new XElement("FIPSMode", "false")),
                            new XElement("PMKCacheMode", "disabled"),
                            new XElement("OneX",
                                new XElement("cacheUserData", "true"),
                                new XElement("authMode", "user"),
                                eapConfig))))
                );
           
            XmlDocument xmlConfig = new XmlDataDocument();
            xmlConfig.LoadXml(Properties.Resources.config);
            XmlNodeList config = xmlConfig.GetElementsByTagName("resources");

            foreach (XmlNode node in config[0].ChildNodes)
            {
                if (node.NodeType == XmlNodeType.Element)
                switch (node.Attributes["name"].Value)
                {
                    case "ssid":
                        Ssid = node.InnerText;
                        break;
                    case "anonymous_identity":
                        AnonymousIdentity = node.InnerText;
                        break;
                    case "eap_method":
                        eapConfig.setEapMethod((EAPConfig.EAPMethod)translateEapDictionary[Convert.ToInt32(node.InnerText)]);
                        break;
                    case "phase2_method":
                        break;
                    case "ca_certificate":
                        break;

                }
            }
        }

        internal class EAPConfig
        {
            private XElement xmlElement;

            public EAPConfig()
            {
                xmlElement = new XElement("EAPConfig", new XElement("EAPHostConfig", String.Empty));
            }

            public void setEapMethod(EAPMethod method)
            {
                var type = new XElement("Type", (int) method);
                type.SetAttributeValue("xmlns", "http://www.microsoft.com/provisioning/EapCommon");
                ((XElement)xmlElement.FirstNode).Add(new XElement("EAPMethod", type));
            }

            public enum EAPMethod
            {
                AKA = 50,
                NONE = -1,
                PEAP = 25,
                PWD = 47,
                SIM = 18,
                TLS = 13,
                TTLS = 21
            }
        }
    }
}
