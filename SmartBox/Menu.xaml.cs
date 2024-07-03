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
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        // 메뉴 항목
        private void Btnsearch_Click(object sender, RoutedEventArgs e)
        {
            Code code = new Code();
            code.ShowDialog();
        }

        private void Btnmap_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map();
            map.ShowDialog();
        }

        private void Btnvideo_Click(object sender, RoutedEventArgs e)
        {
            Video video = new Video();
            video.ShowDialog();
        }


        // 하단 메뉴 함수 
        private void BtnMyinfo_Click(object sender, RoutedEventArgs e)
        {
            Myinfo myInfoWindow = new Myinfo();
            myInfoWindow.Show();
        }

        private void Btnqustion_Click(object sender, RoutedEventArgs e)
        {
            QAndAPage qAndAPage = new QAndAPage();  
            qAndAPage.Show(); 
        }
    }
}
