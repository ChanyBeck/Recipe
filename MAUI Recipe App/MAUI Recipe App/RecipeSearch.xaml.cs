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

    private async void RecipeLst_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		bizRecipe recipe = (bizRecipe)e.Item;

		await Navigation.PushAsync(new RecipeDetail(recipe.RecipeId));
    }

    private async void NewBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RecipeDetail(0));
    }
}