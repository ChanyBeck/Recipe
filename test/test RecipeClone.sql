declare
    @recipeId int,     
    @BaseRecipeId int, 
    @i int, 
    @m varchar(1000)

select top 1 @BaseRecipeId = r.RecipeId from Recipe r 

 exec @i = RecipeClone 
    @RecipeId = @recipeId output,
    @BaseRecipeId = @BaseRecipeId,
    @message  = @m output 

select @i, @m 

select r.RecipeName, r.RecipeId, r.RecipeStatus, direction = max(d.DirectionSequence), ingredient =  max(i.ingredientSequence)
from Recipe r 
left join RecipeDirection d 
on r.RecipeId = d.RecipeId
left join RecipeIngredient i 
on i.RecipeId = r.RecipeId
where r.RecipeId = @recipeId
group by r.RecipeName, r.RecipeId, r.RecipeStatus

union 
select r.RecipeName, r.RecipeId, r.RecipeStatus, direction = max(d.DirectionSequence), ingredient =  max(i.ingredientSequence)
from Recipe r 
left join RecipeDirection d 
on r.RecipeId = d.RecipeId
left join RecipeIngredient i 
on i.RecipeId = r.RecipeId
where r.RecipeId = @BaseRecipeId
group by r.RecipeName, r.RecipeId, r.RecipeStatus