declare @recipeId int
declare @return int
declare @message varchar

select @RecipeId = r.RecipeId
from Recipe r 
where r.RecipeName = 'eggs'
order by r.RecipeId
/*left join MealCourseRecipe mcr 
on mcr.RecipeId = r.RecipeId
left join BookRecipe br 
on br.RecipeId = r.RecipeId
where mcr.MealCourseRecipeId is null 
and br.BookRecipeId is null
order by r.RecipeId*/

select * from Recipe r where r.RecipeId = @RecipeId

exec @return = RecipeDelete @RecipeId = @recipeId, @message = @Message

select @return, @message

select * from Recipe r where r.RecipeId = @RecipeId