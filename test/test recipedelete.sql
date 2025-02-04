declare @recipeId int


select top 1 @RecipeId = r.RecipeId
from Recipe r 
left join MealCourseRecipe mcr 
on mcr.RecipeId = r.RecipeId
left join BookRecipe br 
on br.RecipeId = r.RecipeId
where mcr.MealCourseRecipeId is null 
and br.BookRecipeId is null
and r.DatePublished is null
order by r.RecipeId

select * from Recipe r where r.RecipeId = @RecipeId

declare @return int, @message varchar (500)
exec @return = RecipeDelete @RecipeId = @recipeid, @message = @message output 
select @return, @message

select * from Recipe r where r.RecipeId = @RecipeId