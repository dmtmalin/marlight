using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Marlight.Resources;
using Coding4Fun.Toolkit.Controls;

namespace Marlight
{
    public partial class MainPage : PhoneApplicationPage
    {
        private bool RGB;

        // Конструктор
        public MainPage()
        {
            RGB = false;
            InitializeComponent();
            Init();                      

            // Пример кода для локализации ApplicationBar
            //BuildLocalizedApplicationBar();
            
        }

        void Init()
        {
            var settings = IsolatedStorageSettings.ApplicationSettings;
            var ip_port = cSettings.loadSettings(settings);
            cApiSingleton.Instance.Init(ip_port);           
            btnSettings.Content = string.Format("{0}:{1}", ip_port.Ip, ip_port.Port);
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            RGB = true;
            cApiSingleton.Instance.RGBModeOn();
            NavigationService.Navigate(new Uri("/PageColor.xaml", UriKind.Relative));    
               
        }
      

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageSettings.xaml", UriKind.Relative));
            
        }        

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            cApiSingleton.Instance.Close();
            Init();
        }

        private void btnMode_Click(object sender, RoutedEventArgs e)
        {

        }

        private void slWarm_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue > e.OldValue)
                cApiSingleton.Instance.TempWarmer();
            else
                cApiSingleton.Instance.TempColder();
        }     

        private void slLight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(e.NewValue > e.OldValue)
            {
                if (RGB)
                    cApiSingleton.Instance.RGBBrightUp();
                else
                    cApiSingleton.Instance.BrightUp();
            }
            else
            {
                if (RGB)
                    cApiSingleton.Instance.RGBBrightDown();
                else
                    cApiSingleton.Instance.BrightDown();
            }
        }      

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            RGB = false;
            cApiSingleton.Instance.SetDefaultTempAndBright();

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lampManagement(sender, 1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lampManagement(sender, 2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lampManagement(sender, 3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lampManagement(sender, 4);
        }

        void lampManagement(object sender, int num_lump)
        {
            if (sender != null)
            {
                var btn = sender as RoundToggleButton;
                if(btn != null)
                {
                    if ((bool)btn.IsChecked)
                        cApiSingleton.Instance.LampOn(num_lump);
                    else
                    {
                        RGB = false;
                        cApiSingleton.Instance.LampOff(num_lump);
                    }
                }
            }
        }        

        private void btnCheckUncheck_Click(object sender, RoutedEventArgs e)
        {
            var check = (bool)btnCheckUncheck.IsChecked;
            lampCheckUncheck(check);
            if (check)
                cApiSingleton.Instance.AllOn();
            else
            {
                RGB = false;
                cApiSingleton.Instance.AllOff();
            }
               
        }     

        void lampCheckUncheck(bool check)
        {
            btn1.IsChecked = check;
            btn2.IsChecked = check;
            btn3.IsChecked = check;
            btn4.IsChecked = check;
        }

        // Пример кода для сборки локализованной панели ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Установка в качестве ApplicationBar страницы нового экземпляра ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Создание новой кнопки и установка текстового значения равным локализованной строке из AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Создание нового пункта меню с локализованной строкой из AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}