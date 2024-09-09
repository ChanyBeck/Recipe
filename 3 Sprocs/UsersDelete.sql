create or alter procedure dbo.UsersDelete(
    @UsersId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @UsersId = isnull(@UsersId,0)

    begin try

        delete Users where UsersId = @UsersId

    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
