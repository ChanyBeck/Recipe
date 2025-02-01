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
		bizRecipe recipe = new();
		var lstrecipe = recipe.Search(RecipeNameTxt.Text);
		RecipeLst.ItemsSource = lstrecipe;
	}

    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipe();
    }

    private void RecipeLst_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		bizRecipe recipe = (bizRecipe)e.Item;

		Navigation.PushAsync(new RecipeDetail(recipe.RecipeId));
    }
}