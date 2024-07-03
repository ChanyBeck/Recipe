create or alter procedure dbo.CuisineDeleteAll(
    @CuisineId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @CuisineId = isnull(@CuisineId,0)

    begin try
        begin tran

        ;
        with x as
        (select d.*
        from RecipeDirection d
        join Recipe r
        on r.RecipeId = d.RecipeId
        join Cuisine c 
        on c.CuisineId = r.CuisineId
        where c.CuisineId = @CuisineId
        )
        delete d 
        from x
        join RecipeDirection d 
        on d.RecipeDirectionId = x.RecipeDirectionId

        ;
        with x as
        (select i.*
        from RecipeIngredient i 
        join Recipe r
        on r.RecipeId = i.RecipeId
        join Cuisine c 
        on c.CuisineId = r.CuisineId
        where c.CuisineId = @CuisineId
        )
        delete i 
        from x
        join RecipeIngredient i 
        on i.RecipeIngredientId = x.RecipeIngredientId
        
        ;
        with x as
        (select b.* 
        from BookRecipe b 
        join Recipe r 
        on b.RecipeId = r.RecipeId
        join Cuisine c 
        on c.CuisineId = r.CuisineId
        where c.CuisineId = @CuisineId
        )
        delete b 
        from x 
        join BookRecipe b 
        on b.BookRecipeId = x.BookRecipeId
        
        ;
        with x as
        (select m.* 
        from MealCourseRecipe m  
        join Recipe r 
        on m.RecipeId = r.RecipeId
        join Cuisine c 
        on c.CuisineId = r.CuisineId
        where c.CuisineId = @CuisineId
        )
        delete m
        from x 
        join MealCourseRecipe m 
        on m.MealCourseRecipeId = x.MealCourseRecipeId

        delete Recipe where CuisineId = @CuisineId
        delete Cuisine where CuisineId = @CuisineId

        commit
    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
