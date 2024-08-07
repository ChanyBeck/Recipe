create or alter procedure dbo.RecipeCookbookUpdate(
    @BookrecipeId int output,
    @Cookbookid int,
    @RecipeId int,
    @BookRecipeSequence int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @BookrecipeId = isnull(@BookrecipeId, 0)

    if @BookrecipeId = 0
    begin 
        insert BookRecipe(CookBookId, RecipeId, BookRecipeSequence)
        values(@Cookbookid, @RecipeId, @BookRecipeSequence)

        select @BookrecipeId = SCOPE_IDENTITY();

    end 
    else 
    begin 
        update BookRecipe
        set 
        CookBookId = @Cookbookid,
        RecipeId = @RecipeId,
        BookRecipeSequence = @BookRecipeSequence
        where BookRecipeId = @BookrecipeId
    end 
    return @return
end 
go 