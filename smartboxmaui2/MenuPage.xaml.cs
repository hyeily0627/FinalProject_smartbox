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

    private void BtnInquery_Clicked(object sender, EventArgs e)
    {

    }
}