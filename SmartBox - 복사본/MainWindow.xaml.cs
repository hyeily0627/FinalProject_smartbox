using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PhoneNumberTextBox.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string phoneNumber = PhoneNumberTextBox.Text;

            // 핸드폰 번호 유효성 검사 (010-xxxx-xxxx)
            if (!IsPhoneNumberValid(phoneNumber))
            {
                MessageBox.Show("올바른 핸드폰 번호 형식이 아닙니다.", "경고", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                // 유효한 경우에 수행할 작업 추가
                Menu menu = new Menu();
                menu.ShowDialog();
            }

        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // 길이와 형식을 체크
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^01[0-9]-\d{3,4}-\d{4}$");
        }

        private void BtnMyinfo_Click(object sender, RoutedEventArgs e)
        {
            Myinfo myInfoWindow = new Myinfo();
            myInfoWindow.Show();
        }

    }
}