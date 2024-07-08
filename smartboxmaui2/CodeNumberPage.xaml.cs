namespace smartboxmaui2;

public partial class CodeNumberPage : ContentPage
{
	public CodeNumberPage()
	{
		InitializeComponent();
	}
    private async void ImgBtnSet_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }

    private async void ImgBtnMenu_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }

    private async void ImgBtnMyinfo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MyInfoPage());
    }
}