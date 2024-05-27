create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @All bit = 0, @CuisineType varchar(50) = '')  
as 
begin 
    select @CuisineType = nullif(@CuisineType, '')
    select * 
    from cuisine c 
    where c.CuisineId = @CuisineId
    or @All = 1 
    or c.CuisineType like '%' + @CuisineType + '%'
end
go 

