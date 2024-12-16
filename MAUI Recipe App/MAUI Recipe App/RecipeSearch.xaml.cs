using System.Data;
using RecipeSystem;

namespace MAUI_Recipe_App;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
	}

	private void SearchRecipe()
	{
		DataTable dt = Recipe.SearchRecipe(RecipeNameTxt.Text);
		RecipeLst.ItemsSource = dt.Rows;
	}

    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipe();
    }
}