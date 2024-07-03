        declare @cuisineId int
        
        select top 1 @cuisineId = c.CuisineId
        from Cuisine c 
        
select * from Cuisine c where c.CuisineId = @cuisineId

exec CuisineDelete @cuisineId = @cuisineId

select * from Cuisine c where c.CuisineId = @cuisineId
