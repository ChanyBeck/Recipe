create or alter procedure dbo.IngredientUpdate(
    @IngredientId int output,
    @IngredientName varchar (50),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @IngredientId = isnull(@IngredientId, 0)

    if @IngredientId = 0
    begin 
        insert Ingredient(ingredientName)
        values (@IngredientName)

        select @IngredientId = SCOPE_IDENTITY();
    end 
    else 
    begin 
        update Ingredient 
        set 
        ingredientName = @IngredientName
        where ingredientId = @IngredientId
    end 
    return @return
end 
go 