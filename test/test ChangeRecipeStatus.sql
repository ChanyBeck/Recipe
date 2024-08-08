declare @RecipeId int, @NewStatus varchar (20)

select top 1 @RecipeId = RecipeId from Recipe order by RecipeName

select * from Recipe where RecipeId = @RecipeId

select @NewStatus = 'Published'

exec dbo.ChangeRecipeStatus @RecipeId = @RecipeId, @NewStatus = @NewStatus

select * from Recipe where RecipeId = @RecipeId