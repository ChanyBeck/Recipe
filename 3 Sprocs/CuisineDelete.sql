create or alter procedure dbo.CuisineDelete(
    @CuisineId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @CuisineId = isnull(@CuisineId,0)

    begin try

        delete Cuisine where CuisineId = @CuisineId

    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
