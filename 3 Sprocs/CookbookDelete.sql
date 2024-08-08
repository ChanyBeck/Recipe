create or alter procedure dbo.CookbookDelete(
    @CookbookId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @CookbookId = isnull(@CookbookId,0)

    begin try

        delete CookBook where CookBookId = @CookbookId

    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
