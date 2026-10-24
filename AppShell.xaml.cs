namespace CampusConnect;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SignUpPage),typeof(SignUpPage));
		Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();

		bool isLoggedIn = Preferences.Default.Get("IsLoggedIn", false);
		if (isLoggedIn)
		{
			await Shell.Current.GoToAsync("//HomePage");
		}
	}
}
