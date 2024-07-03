create or alter procedure dbo.RecipeIngredientUpdate(
    @RecipeIngredientId int = 0 output, 
    @RecipeId int = 0,
    @IngredientId int = 0, 
    @measurementId int = 0, 
    @Amount decimal(5,2),
    @ingredientSequence int = 0,
    @Message varchar(500) = ''  output
)
as 
begin 
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId, 0)

    if @recipeid = 0
    begin 
        insert RecipeIngredient(RecipeId, IngredientId, measurementId, Amount, ingredientSequence)
        values (@RecipeId, @IngredientId, @measurementId, @Amount, @ingredientSequence)
    end 
    else 
    begin 
        update RecipeIngredient
        set 
        RecipeId = @RecipeId,
        IngredientId = @IngredientId, 
        MeasurementId = @measurementId, 
        Amount = @Amount, 
        IngredientSequence = @ingredientSequence
        where RecipeIngredientId = @RecipeIngredientId
    end 
    return @return
end 
go 