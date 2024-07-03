create or alter procedure dbo.RecipeIngredientGet(
    @RecipeIngredientId int = 0 output, 
    @RecipeId int = 0,
    @All bit = 0,
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	select ri.RecipeIngredientId, ri.IngredientId, ri.measurementId, ri.Amount, ri.ingredientSequence
	from RecipeIngredient ri
	where RecipeId = @RecipeId
    order by ri.ingredientSequence

	return @return
end
go 
