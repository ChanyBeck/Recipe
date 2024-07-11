create or alter procedure dbo.RecipeClone(
    @Recipeid int = null output, 
    @BaseRecipeId int, 
    @message varchar (1000) = '' output 
)
as 
begin
    declare @return int = 0

    insert Recipe(usersId, CuisineId, recipeName, Calories, Datedrafted,DatePublished, DateArchived)
    select r.UsersId, r.CuisineId, concat(r.RecipeName, ' -clone'), r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
    from Recipe r 
    where r.RecipeId = @BaseRecipeId

    select @Recipeid = SCOPE_IDENTITY();

    insert RecipeIngredient(RecipeId, IngredientId, measurementId, Amount, ingredientSequence)
    select @Recipeid, i.IngredientId, i.measurementId, i.Amount, i.ingredientSequence
    from RecipeIngredient i 
    where i.RecipeId = @BaseRecipeId

    insert RecipeDirection(RecipeId, Direction, DirectionSequence)
    select @Recipeid, d.Direction, d.DirectionSequence
    from RecipeDirection d 
    where d.RecipeId = @BaseRecipeId

    return @return 
end
go 


--select * from RecipeDirection
/*
delete RecipeDirection where recipeid = @recipeId
delete RecipeIngredient where RecipeId = @recipeId
delete Recipe where RecipeId = @recipeId
*/