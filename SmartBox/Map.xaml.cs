using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace SmartBox
{
    /// <summary>
    /// map.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Map : Window
    {
        public Map()
        {
            InitializeComponent();
            string currentDirectory = Directory.GetCurrentDirectory();
            string htmlFilePath = System.IO.Path.Combine(currentDirectory, "map.html");
            webBrowser.Navigate(new Uri(htmlFilePath));

            UpdateWebBrowserVersion();
        }
        private void UpdateWebBrowserVersion()
        {
            // IE 11 사용 설정
            int browserVerison = 11001;
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            if (regKey != null)
            {
                regKey.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", browserVerison, RegistryValueKind.DWord);
                regKey.Close();
            }
        }

    }
}
