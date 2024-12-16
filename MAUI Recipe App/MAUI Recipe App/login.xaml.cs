
using RecipeSystem; 

namespace MAUI_Recipe_App;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            MessageLbl.Text = "";
            DBManager.SetConnectionString(App.ConStringSetting, true, UserNameTxt.Text, PasswordTxt.Text);
            App.LoggedIn = true;
            await Navigation.PopModalAsync();
        }
        catch (Exception ex)
        {
            MessageLbl.Text = ex.Message;
        }
    }

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}
