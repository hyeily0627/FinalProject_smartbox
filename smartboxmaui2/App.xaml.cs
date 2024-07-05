namespace smartboxmaui2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            // MainPage를 NavigationPage로 감싸서 설정합니다.
            MainPage = new NavigationPage(new MainPage());

            // 내비게이션 바를 숨깁니다.
            NavigationPage.SetHasNavigationBar(MainPage, false);
        }
    }
}
