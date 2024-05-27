declare @message varchar(500) = '', @return int, @usersid int, @cuisineid int, @recipeid int 

select top 1 @usersid = usersid from users

select top 1 @cuisineid = cuisineid from cuisine

exec @return = RecipeUpdate 
    @RecipeId = @recipeid output,
    @UsersId = @usersid,
    @CuisineId = @cuisineid,
    @RecipeName = 'Cherry Pie',
    @Calories = 100,
    @DateDrafted = '05/23/2024',
    @DatePublished = null,
    @DateArchived = null,
    @Message = @message output 

select @return, @message, @recipeid

select * from Recipe where RecipeId = @recipeid

delete Recipe where RecipeName = 'Cherry Pie'