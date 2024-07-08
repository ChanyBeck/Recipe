declare @message varchar(500) = '', @return int,
        @RecipeIngredientId int = 0, 
    @RecipeId int = 0,
    @IngredientId int = 0, 
    @measurementId int = 0, 
    @Amount decimal(5,2),
    @ingredientSequence int = 0

select top 1 @RecipeIngredientId = RecipeIngredientId, 
    @RecipeId = RecipeId,
    @IngredientId = IngredientId,
    @measurementId = measurementId,
    @Amount = Amount,
    @ingredientSequence = ingredientSequence
    from RecipeIngredient

select @Amount = 8

exec @return = RecipeIngredientUpdate
@RecipeIngredientId = @RecipeIngredientId output, 
    @RecipeId =@RecipeId,
    @IngredientId = @IngredientId,
    @measurementId = @measurementId,
    @Amount = @Amount,
    @ingredientSequence = @ingredientSequence,
    @Message = @message output 

select @return, @message, @recipeid

select * from RecipeIngredient where RecipeIngredientId = @RecipeIngredientId
