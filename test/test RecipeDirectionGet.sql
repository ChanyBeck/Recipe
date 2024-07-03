declare @recipeId int

select top 1 @recipeId = r.recipeid 
from Recipe r 
join RecipeDirection d 
on r.RecipeId = d.RecipeId
order by d.DirectionSequence

exec RecipeRecipeDirectionGet @recipeId = @recipeId

