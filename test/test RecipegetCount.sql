declare @return int, @message varchar (1000)

exec @return = RecipeGet @all = 1, @message = @message OUTPUT

select @return, @message