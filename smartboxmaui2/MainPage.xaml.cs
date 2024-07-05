using Microsoft.Maui.Controls;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace smartboxmaui2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            // 번호 입력을 받는 Entry 컨트롤의 텍스트를 가져옵니다.
            var phoneNumber = PhoneNumberEntry.Text;

            // 전화번호 유효성 검사를 수행합니다.
            if (IsValidPhoneNumber(phoneNumber))
            {
                await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                // 경고창을 표시합니다.
                await DisplayAlert("유효성 검사 실패", "올바른 전화번호 형식이 아닙니다. 010-XXXX-XXXX 형식으로 입력해주세요.", "확인");
            }
        }

        // 전화번호 유효성 검사 함수
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // 전화번호 형식을 검증하는 정규 표현식
            var regex = new Regex(@"^010-\d{4}-\d{4}$");
            return regex.IsMatch(phoneNumber);
        }
    }
}
