create or alter procedure dbo.RecipeListGet(@ALL int)  
as 
begin 

    declare @return int

    select r.RecipeId, 'Recipe Name' = r.recipename, 'Status' = r.RecipeStatus, 'User' = concat(u.FirstName, ' ', u.LastName), r.Calories, 'Num Ingredients' = max(i.ingredientSequence)
    from Recipe r 
    join Users u 
    on u.UsersId = r.UsersId
    left join RecipeIngredient i 
    on i.RecipeId = r.RecipeId
    where @All = 1 
    group by r.RecipeName, r.RecipeStatus, u.LastName, u.FirstName, r.Calories, r.RecipeId
    order by r.RecipeStatus desc, r.RecipeName

    return @return
end
go 

