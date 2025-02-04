using RecipeSystem;

namespace MAUI_Recipe_App;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        this.Loaded += Home_Loaded;
        this.Appearing += Home_Appearing;
	}

    private async void Home_Loaded(object sender, EventArgs e)
    {
        if(App.LoggedIn == false)
        {
           await Navigation.PushModalAsync(new login());
        }
    }
    private void Home_Appearing(object sender, EventArgs e)
    {
        if (App.LoggedIn)
        {
            BindableLayout.SetItemsSource(DashboardLst, new bizDashboard().GetList(false));
        }
    }
}