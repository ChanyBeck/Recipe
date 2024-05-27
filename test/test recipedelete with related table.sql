declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r 
join MealCourseRecipe mcr 
on mcr.RecipeId = r.RecipeId
join BookRecipe br 
on br.RecipeId = r.RecipeId
order by r.RecipeId

select * from Recipe r where r.RecipeId = @RecipeId

exec RecipeDelete @RecipeId = @rescipeid

select * from Recipe r where r.RecipeId = @RecipeId
