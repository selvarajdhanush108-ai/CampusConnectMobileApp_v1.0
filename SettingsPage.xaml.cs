namespace CampusConnect;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
	private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
	private async void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        bool confirmLogout = await DisplayAlert("Confirm Logout", "Are you sure you want to log out?", "Yes", "No");
        if(!confirmLogout)
        {
            return; 
        }
        Preferences.Default.Set("IsLoggedIn", false);
        await Shell.Current.GoToAsync("//MainPage");
    }
}