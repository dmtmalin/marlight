using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Marlight
{
    public partial class PageColor : PhoneApplicationPage
    {       
        public PageColor()
        {
            InitializeComponent();
        }

        private void cpSetLight_ColorChanged(object sender, System.Windows.Media.Color color)
        {
            cApiSingleton.Instance.RGBSetColor(color.R, color.G, color.B);
        }
    }
}