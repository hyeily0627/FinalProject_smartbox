using System.Collections.ObjectModel;

namespace smartboxmaui2;

public partial class MapPage : ContentPage
{

    public MapPage()
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