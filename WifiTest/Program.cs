using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWifi;

namespace WifiTest
{
    class Program
    {
        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }
        static void Main(string[] args)
        {
            WlanClient client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                // Lists all networks with WEP security
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    if (network.dot11DefaultCipherAlgorithm == Wlan.Dot11CipherAlgorithm.WEP)
                    {
                        Console.WriteLine("Found WEP network with SSID {0}.", GetStringForSSID(network.dot11Ssid));
                    }
                }

                // Retrieves XML configurations of existing profiles.
                // This can assist you in constructing your own XML configuration
                // (that is, it will give you an example to follow).
                foreach (Wlan.WlanProfileInfo profileInfo in wlanIface.GetProfiles())
                {
                    string name = profileInfo.profileName; // this is typically the network's SSID
                    string xml = wlanIface.GetProfileXml(profileInfo.profileName);
                }
            }
            Console.ReadKey();
        }
    }
}
