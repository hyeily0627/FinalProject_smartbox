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

namespace SmartBox
{
    /// <summary>
    /// Video.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Video : Window
    {
        public Video()
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
