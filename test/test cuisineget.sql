declare @Id int
select top 1 @Id = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @Id -- return one record

exec CuisineGet --return empty result set

exec CuisineGet @All = 1 --return all records

exec CuisineGet @CuisineType = 'an' --return records with Cuisine type an

exec CuisineGet @CuisineType = '' --return empty result set