namespace smartboxmaui2;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

    private async void BtnCode_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CodeNumberPage());
    }

    private async void BtnInquery_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InquiryPage());
    }

    private async void BtnMap_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MapPage());
    }

    private void BtnCctv_Clicked(object sender, EventArgs e)
    {

    }

    private async void ImgBtnSet_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }

    private async void ImgBtnMyinfo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MyInfoPage());
    }

}