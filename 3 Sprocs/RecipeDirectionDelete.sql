create or alter procedure dbo.RecipeDirectionDelete(
    @RecipeDirectionId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @RecipeDirectionId = isnull(@RecipeDirectionId,0)

    begin try

        delete RecipeDirection where RecipeDirectionId = @RecipeDirectionId
        
    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
