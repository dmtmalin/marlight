using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Coding4Fun.Toolkit.Controls;
using System.IO.IsolatedStorage;

namespace Marlight
{
    public partial class PanoramaPageMode : PhoneApplicationPage
    {
        public PanoramaPageMode()
        {
            InitializeComponent();

            loadTspValue(tspAlarmOn);
            loadTspValue(tspTimerOn);
            loadTspValue(tspTimerOff);        

        }

        private void btnNight_Click(object sender, RoutedEventArgs e)
        {
            cApiSingleton.Instance.PresetNight();
        }

        private void btnMeet_Click(object sender, RoutedEventArgs e)
        {
            cApiSingleton.Instance.PresetMeeting();
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            cApiSingleton.Instance.PresetReading();
        }

        private void btnMode_Click(object sender, RoutedEventArgs e)
        {
            cApiSingleton.Instance.PresetMode();
        }

        private void btnTimer_Click(object sender, RoutedEventArgs e)
        {            
            var hourOn = getByteHour(tspTimerOn);
            var mintOn = getByteMinute(tspTimerOn);

            var hourOff = getByteHour(tspTimerOff);
            var mintOff = getByteMinute(tspTimerOff);

            cApiSingleton.Instance.PresetTimer(hourOn, mintOn, hourOff, mintOff);
            
        }
        
        private byte getByteHour(TimeSpanPicker tsp)
        {
            var val = tsp.Value.Value.Hours;
            var b = Convert.ToByte(val);
            return b;
        }

        private byte getByteMinute(TimeSpanPicker tsp)
        {
            var val = tsp.Value.Value.Minutes;
            var b = Convert.ToByte(val);
            return b;
        }



        private void btnAlarm_Click(object sender, RoutedEventArgs e)
        {
            var hourOn = getByteHour(tspAlarmOn);
            var mintOn = getByteMinute(tspAlarmOn);

            cApiSingleton.Instance.PresetAlarm(hourOn, mintOn);
        }

        private void tsp_ValueChanged(object sender, RoutedPropertyChangedEventArgs<TimeSpan> e)
        {
            if(sender !=  null)
            {
                var tsp = sender as TimeSpanPicker;
                if(tsp != null)
                {
                    var settings = IsolatedStorageSettings.ApplicationSettings;
                    if(settings.Contains(tsp.Name))
                    {
                        settings[tsp.Name] = e.NewValue;
                    }
                    else
                    {
                        settings.Add(tsp.Name, e.NewValue);
                    }
                }
            }           
        }    
    
        private void loadTspValue(TimeSpanPicker tsp)
        {
            var settings = IsolatedStorageSettings.ApplicationSettings;
            if(settings.Contains(tsp.Name))
            {
                tsp.Value = (TimeSpan)settings[tsp.Name];
            }
        }
    }
}