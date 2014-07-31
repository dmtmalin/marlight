using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Marlight
{
    public partial class PageSettings : PhoneApplicationPage
    {
        IsolatedStorageSettings settings;
        public PageSettings()
        {
            InitializeComponent();

            settings = IsolatedStorageSettings.ApplicationSettings;

            var ip_port = cSettings.loadSettings(settings);
            tbIP.Text = ip_port.Ip.ToString();
            tbPort.Text = ip_port.Port.ToString();

        }

        private void tbIP_TextChanged(object sender, TextChangedEventArgs e)
        {            
            if(sender != null && !string.IsNullOrEmpty(tbIP.Text))
            {
                cSettings.saveIp(settings, tbIP.Text);
            }
           
        }

        private void tbPort_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender != null)
            {
                var port = 0;
                var text = tbPort.Text;
                if(!string.IsNullOrEmpty(text))
                {
                    port = Convert.ToInt32(text);
                }
                cSettings.savePort(settings, port);                
            }            
        }
    }
}