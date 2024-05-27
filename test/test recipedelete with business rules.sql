declare @RecipeId int

select top 1  @RecipeId = r.RecipeId 
from Recipe r 
where r.RecipeStatus = 'Published' or datediff(day, getdate(), r.DateArchived) < 30

select * from Recipe r 
where r.RecipeId = @RecipeId

declare @return int, @message varchar (500)
exec @return = RecipeDelete @RecipeId = @recipeid, @message = @message output 
select @return, @message

select * from Recipe r 
where r.RecipeId = @RecipeId

