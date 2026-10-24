namespace CampusConnect;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void SettingsClicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//SettingsPage");
    }
}