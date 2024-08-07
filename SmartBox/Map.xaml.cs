﻿using GMap.NET.MapProviders;
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
        }
        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu menuWindow = new Menu();
            menuWindow.Show();
        }

        private void BtnMyinfo_Click(object sender, RoutedEventArgs e)
        {
            Myinfo myInfoWindow = new Myinfo();
            myInfoWindow.Show();
        }

    }
}