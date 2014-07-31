using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;

namespace Marlight
{
    class cSettings
    {
        static bool checkSettings(IsolatedStorageSettings settings)
        {
            var check = false;            
            // txtInput is a TextBox defined in XAML.
            if (settings.Contains("Ip") &&
                settings.Contains("Port"))
            {
                check = true;
            }
            return check;
        }

        static void setSettings(IsolatedStorageSettings settings, string ip, int port)
        {            
            settings.Add("Ip", ip);
            settings.Add("Port", port);
            settings.Save();
        }

        static string getIp(IsolatedStorageSettings settings)
        {            
            return (string)settings["Ip"];
        }

        static int getPort(IsolatedStorageSettings settings)
        {            
            return (int)settings["Port"];
        }

        public static cObjectIpPort loadSettings(IsolatedStorageSettings settings)
        {
            var ip = "localhost";
            var port = 5000;
            var ip_port = new cObjectIpPort(ip, port);
            
            if (checkSettings(settings))
            {
                ip_port.Ip = getIp(settings);
                ip_port.Port = getPort(settings);
            }
            else
            {
                setSettings(settings, ip, port);
            }

            return ip_port;
        }

        public static void saveIp(IsolatedStorageSettings settings, string value)
        {
            settings["Ip"] = value;
            settings.Save();
        }

        public static void savePort(IsolatedStorageSettings settings, int value)
        {
            settings["Port"] = value;
            settings.Save();
        }
    }
}
