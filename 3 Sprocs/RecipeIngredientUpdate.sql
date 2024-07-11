create or alter procedure dbo.RecipeIngredientUpdate(
    @RecipeIngredientId int output, 
    @RecipeId int,
    @IngredientId int, 
    @measurementId int, 
    @Amount decimal(5,2),
    @ingredientSequence int,
    @Message varchar(500) = ''  output
)
as 
begin 
    declare @return int = 0

    select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

    if @RecipeIngredientId = 0
    begin 
        insert RecipeIngredient(RecipeId, IngredientId, measurementId, Amount, ingredientSequence)
        values (@RecipeId, @IngredientId, @measurementId, @Amount, @ingredientSequence)
            
        select @Recipeid = SCOPE_IDENTITY();
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