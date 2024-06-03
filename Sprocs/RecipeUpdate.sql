create or alter procedure dbo.RecipeUpdate(
    @RecipeId int output,
    @UsersId int,
    @CuisineId int,
    @RecipeName varchar (50),
    @Calories int,
    @DatePublished datetime,
    @DateArchived datetime,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId, 0), @DatePublished = nullif(@DatePublished, 0), @DateArchived = nullif(@DateArchived, 0)

    if @recipeid = 0
    begin 
        insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DatePublished, DateArchived)
        values (@UsersId, @CuisineId, @RecipeName, @Calories, @DatePublished, @DateArchived)
        select @RecipeId = SCOPE_IDENTITY()
    end 
    else 
    begin 
        update Recipe 
        set 
        UsersId = @UsersId, 
        CuisineId = @CuisineId, 
        RecipeName = @RecipeName, 
        Calories = @Calories, 
        DatePublished = @DatePublished, 
        DateArchived = @DateArchived
        where RecipeId = @recipeid
    end 
    return @return
end 
go 