using System.Collections.ObjectModel;

namespace smartboxmaui2;

public partial class MapPage : ContentPage
{

    // ���ã�� ����� ���� ObservableCollection
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
            // �ּ� �˻� �� ���� ������Ʈ ���� ����
            DisplayAlert("�˻�", $"�ּ� '{address}'�� �˻��մϴ�.", "Ȯ��");
        }
        else
        {
            DisplayAlert("����", "�ּҸ� �Է��ϼ���.", "Ȯ��");
        }
    }

    private void BtnFavorite_Clicked(object sender, EventArgs e)
    {
        string address = AddressEntry.Text;
        if (!string.IsNullOrWhiteSpace(address))
        {
            favoriteAddresses.Add(address);
            DisplayAlert("�߰���", $"�ּ� '{address}'��(��) ���ã�⿡ �߰��Ǿ����ϴ�.", "Ȯ��");
            AddressEntry.Text = string.Empty; // �Է� â ����
        }
        else
        {
            DisplayAlert("����", "�ּҸ� �Է��ϼ���.", "Ȯ��");
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