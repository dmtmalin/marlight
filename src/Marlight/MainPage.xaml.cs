using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Marlight.Resources;
using System.IO.IsolatedStorage;

namespace Marlight
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Конструктор
        public MainPage()
        {
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

        private void slWarm_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btnMode_Click(object sender, RoutedEventArgs e)
        {

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