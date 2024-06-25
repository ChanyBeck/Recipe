declare @recipeid int

select top 1 @recipeid = r.recipeid
from Recipe r 
join RecipeIngredient i 
on r.RecipeId = i.RecipeId
order by RecipeStatus desc


exec RecipeIngredientGet @recipeid = @recipeid
