﻿#pragma checksum "c:\Users\admin\Documents\GitHub\marlight\src\Marlight\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "305CF8835B84E870DE0F26973CE532AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Marlight {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.HyperlinkButton btnSettings;
        
        internal System.Windows.Controls.HyperlinkButton btnColor;
        
        internal System.Windows.Controls.HyperlinkButton btnMode;
        
        internal Coding4Fun.Toolkit.Controls.SuperSlider slWarm;
        
        internal Coding4Fun.Toolkit.Controls.SuperSlider slLight;
        
        internal System.Windows.Controls.HyperlinkButton btnRestart;
        
        internal Coding4Fun.Toolkit.Controls.RoundToggleButton btn1;
        
        internal Coding4Fun.Toolkit.Controls.RoundToggleButton btn2;
        
        internal Coding4Fun.Toolkit.Controls.RoundToggleButton btn3;
        
        internal Coding4Fun.Toolkit.Controls.RoundToggleButton btn4;
        
        internal Coding4Fun.Toolkit.Controls.RoundToggleButton btnCheckUncheck;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Marlight;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnSettings = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btnSettings")));
            this.btnColor = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btnColor")));
            this.btnMode = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btnMode")));
            this.slWarm = ((Coding4Fun.Toolkit.Controls.SuperSlider)(this.FindName("slWarm")));
            this.slLight = ((Coding4Fun.Toolkit.Controls.SuperSlider)(this.FindName("slLight")));
            this.btnRestart = ((System.Windows.Controls.HyperlinkButton)(this.FindName("btnRestart")));
            this.btn1 = ((Coding4Fun.Toolkit.Controls.RoundToggleButton)(this.FindName("btn1")));
            this.btn2 = ((Coding4Fun.Toolkit.Controls.RoundToggleButton)(this.FindName("btn2")));
            this.btn3 = ((Coding4Fun.Toolkit.Controls.RoundToggleButton)(this.FindName("btn3")));
            this.btn4 = ((Coding4Fun.Toolkit.Controls.RoundToggleButton)(this.FindName("btn4")));
            this.btnCheckUncheck = ((Coding4Fun.Toolkit.Controls.RoundToggleButton)(this.FindName("btnCheckUncheck")));
        }
    }
}

