using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWifi
{
    public class WifiManager
    {
        int addNetwork(WifiConfiguration config)
        {
            return 0;
        }

        bool disableNetwork(int NetId)
        {
            return false;
        }

        bool disconnect()
        {
            return false;
        }

        bool enableNetwork(int netId, bool attemptConnect)
        {
            return false;
        }

        List<WifiConfiguration> getConfiguredNetworks()
        {
            return new List<WifiConfiguration>();
        }


    }

    public class WifiConfiguration
    {
    }
}
