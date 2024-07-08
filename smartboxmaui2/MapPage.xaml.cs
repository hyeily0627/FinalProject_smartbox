using System.Collections.ObjectModel;

namespace smartboxmaui2;

public partial class MapPage : ContentPage
{

    // 즐겨찾기 목록을 위한 ObservableCollection
    private ObservableCollection<string> favoriteAddresses;

    public MapPage()
	{
		InitializeComponent();

        favoriteAddresses = new ObservableCollection<string>();
        FavoritesListView.ItemsSource = favoriteAddresses;
    }

    private void BtnSerch_Clicked(object sender, EventArgs e)
    {
        string address = AddressEntry.Text;
        if (!string.IsNullOrWhiteSpace(address))
        {
            // 주소 검색 및 지도 업데이트 로직 구현
            DisplayAlert("검색", $"주소 '{address}'로 검색합니다.", "확인");
        }
        else
        {
            DisplayAlert("오류", "주소를 입력하세요.", "확인");
        }
    }

    private void BtnFavorite_Clicked(object sender, EventArgs e)
    {
        string address = AddressEntry.Text;
        if (!string.IsNullOrWhiteSpace(address))
        {
            favoriteAddresses.Add(address);
            DisplayAlert("추가됨", $"주소 '{address}'이(가) 즐겨찾기에 추가되었습니다.", "확인");
            AddressEntry.Text = string.Empty; // 입력 창 비우기
        }
        else
        {
            DisplayAlert("오류", "주소를 입력하세요.", "확인");
        }
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