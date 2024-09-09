create or alter procedure dbo.CourseGet(
    @CourseId int = 0, 
    @All bit = 0, 
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @All = isnull(@All,0), @CourseId = isnull(@CourseId,0)

	select c.CourseId, c.CourseName, c.CourseSequence
	from Course c 
	where CourseId = @CourseId
	or @All = 1
	order by c.CourseName

	return @return
end
go 
