namespace smartboxmaui2;

public partial class InquiryPage : ContentPage
{
	public InquiryPage()
	{
		InitializeComponent();
	}
    private async void BtnSet_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }

    private async void ImgBtnMenu_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }


    private async void BtnMyinfo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MyInfoPage());
    }
}