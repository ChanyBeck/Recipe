create or alter procedure dbo.IngredientDelete(
    @IngredientId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @IngredientId = isnull(@IngredientId,0)

    begin try

        delete Ingredient where ingredientId = @IngredientId

    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
