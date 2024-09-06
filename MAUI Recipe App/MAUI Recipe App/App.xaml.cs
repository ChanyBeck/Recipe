namespace MAUI_Recipe_App;

public partial class App : Application
{
	public static bool LoggedIn = false;
	public static string ConStringSetting = "Server=.\\SQLExpress;Database=HeartyHearthDB";

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
