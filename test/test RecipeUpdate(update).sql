declare @message varchar(500) = '', @return int, @usersid int, @cuisineid int, @recipeid int,
    @RecipeName varchar (50),
    @Calories int,
    @DateDrafted datetime,
    @DatePublished datetime,
    @DateArchived datetime

select top 1 @recipeid = Recipeid,
    @UsersId = UsersId, 
    @CuisineId = CuisineId, 
    @RecipeName = RecipeName, 
    @Calories = Calories, 
    @DateDrafted = DateDrafted, 
    @DatePublished = DatePublished, 
    @DateArchived = DateArchived 
    from Recipe

select @RecipeName = reverse(@RecipeName)

exec @return = RecipeUpdate 
    @RecipeId = @recipeid output,
    @UsersId = @usersid,
    @CuisineId = @cuisineid,
    @RecipeName = @RecipeName,
    @Calories = @Calories,
    @DateDrafted =  @DateDrafted,
    @DatePublished = @DateDrafted,
    @DateArchived = @DateArchived,
    @Message = @message output 

select @return, @message, @recipeid

select * from Recipe where RecipeId = @recipeid
