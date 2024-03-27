declare @Id int
select top 1 @Id = r.RecipeId from recipe r 
exec RecipeGet @RecipeId = @Id -- return one record

exec RecipeGet --return empty result set

exec RecipeGet @All = 1 --return all records

exec RecipeGet @RecipeName = 'oo' --return records with recipe name oo

exec RecipeGet @RecipeName = '' --return empty result set