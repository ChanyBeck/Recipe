create or alter procedure dbo.CuisineGet(
    @CuisineId int = 0, 
    @All bit = 0, 
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @All = isnull(@All,0), @CuisineId = isnull(@CuisineId,0)

	select c.CuisineId, c.cuisinetype
	from Cuisine c
	where CuisineId = @CuisineId
	or @All = 1
	order by c.CuisineType

	return @return
end
go 
