using System.Data;
using RecipeSystem;

namespace MAUI_Recipe_App;

public partial class List : ContentPage
{
	public List()
	{
		InitializeComponent();
		ShowForm();
	}

	private void ShowForm()
	{
		DataTable dt = Recipe.GetList("RecipeGet");
		lstrecipe.ItemsSource = dt.Rows;
	}
}