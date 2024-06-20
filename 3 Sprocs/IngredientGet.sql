create or alter procedure dbo.IngredientGet(
    @IngredientId int = 0, 
    @All bit = 0, 
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @All = isnull(@All,0), @IngredientId = isnull(@IngredientId,0)

	select i.IngredientId, I.ingredientName
	from Ingredient i 
	where IngredientId = @IngredientId
	or @All = 1
	order by i.ingredientName

	return @return
end
go 
