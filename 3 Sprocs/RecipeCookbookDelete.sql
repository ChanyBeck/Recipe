create or alter procedure dbo.RecipeCookbookDelete(
    @BookrecipeId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @BookrecipeId = isnull(@BookrecipeId,0)

    begin try

        delete BookRecipe where BookRecipeId = @BookrecipeId

    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
