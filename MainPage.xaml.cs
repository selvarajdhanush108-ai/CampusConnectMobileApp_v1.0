namespace CampusConnect;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private async void OnLoginButtonClicked(object sender,EventArgs e)
	{
		string email = EmailEntry.Text;
		string password = PassEntry.Text;

		if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
		{
			await DisplayAlert("Error","Please enter both email and password","Ok");
			return;
		}
		await DisplayAlert("Success",$"Attempting to login as {email}","OK");
	}
}