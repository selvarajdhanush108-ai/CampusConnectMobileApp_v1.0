namespace CampusConnect;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
	private async void OnSignUpButtonClicked(object sender, EventArgs e)
	{
		string Email = EmailEntry.Text;
		string Phone = PhoneEntry.Text;
		string Pass = PassEntry.Text;
		string ConfPass = PassConfEntry.Text;
		if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Phone) || string.IsNullOrWhiteSpace(Pass))
		{
			await DisplayAlert("Error","Enter all details to create an account","OK");
			return;
		}else if (!Pass.Equals(ConfPass))
		{
			await DisplayAlert("Error", $"Password Mismatch {Pass}:{ConfPass}", "OK");
			return;
		}
		await DisplayAlert("Success",$"Accout created successfully for {Phone}:{Email}","OK");
	}
	private async void OnLoginTapped(object sender,EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}