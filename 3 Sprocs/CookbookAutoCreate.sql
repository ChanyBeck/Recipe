create or alter procedure dbo.CookbookCreate(
    @CookbookId int = null output,
    @UsersId int = 0,
    @Message varchar(500) = ''  output
)  
as 
begin 

;
with x as (
    select r.UsersId, 'total recipes' = count(*) from Recipe r
    group by r.UsersId
)
insert CookBook(UsersId, Title, Price)
select u.UsersId, Title = concat('Recipes by ', u.FirstName, ' ', u.LastName), 'Price' = x.[total recipes]*1.33
from Users u  
join x 
on x.UsersId = u.UsersId
where u.UsersId = @UsersId

select @CookBookId = SCOPE_IDENTITY(); 

drop sequence IncrementSequence
create sequence IncrementSequence start with 1 increment by 1; 

insert BookRecipe (CookBookId, RecipeId, BookRecipeSequence)
select @CookBookId, r.RecipeId, next value for IncrementSequence over(order by r.RecipeName)
from users u  
join Recipe r 
on r.UsersId = u.UsersId
where u.UsersId = @UsersId
order by r.RecipeName

select * from CookBook where CookBookId = @CookBookId

end 
go 