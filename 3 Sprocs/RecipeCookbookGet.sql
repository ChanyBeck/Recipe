create or alter procedure dbo.RecipeCookbookGet(
    @CookbookId int
)
as 
begin 

    select @CookbookId = isnull(@Cookbookid, 0)

    select c.CookBookId, r.RecipeId, b.BookRecipeId, b.BookRecipeSequence
    from Cookbook c 
    left join BookRecipe b
    on c.CookBookId = b.CookBookId
    left join Recipe r 
    on r.RecipeId = b.RecipeId
    where c.CookBookId = @Cookbookid
    order by b.BookRecipeSequence

end 
