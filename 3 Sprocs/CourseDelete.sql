create or alter procedure dbo.CourseDelete(
    @CourseId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @CourseId = isnull(@CourseId,0)

    begin try

        delete Course where CourseId = @CourseId

    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
