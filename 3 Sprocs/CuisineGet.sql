create or alter procedure dbo.CuisineGet(
    @CuisineId int = 0, 
    @All bit = 0, 
	@IncludeBlank bit = 0,
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0
	declare @t table(CuisineId int) 

	select @All = isnull(@All,0), @CuisineId = isnull(@CuisineId,0), @IncludeBlank = isnull(@IncludeBlank, 0)

	insert @t(c.CuisineId)
    select c.CuisineId
    from Cuisine c 
	where CuisineId = @CuisineId
	or @All = 1
	order by c.CuisineType

	select *
    from @t t 
    join Cuisine c 
    on c.CuisineId = t.CuisineId
    union select 0, 0,''
    where @IncludeBlank = 1

	-- select c.CuisineId, c.cuisinetype
	-- from Cuisine c
	-- where CuisineId = @CuisineId
	-- or @All = 1
	-- order by c.CuisineType

	return @return
end
go 
