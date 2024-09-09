declare @UsersId int 

select top 1 @UsersId = UsersId from Users 

select * from CookBook
select * from BookRecipe

exec cookbookcreate @UsersId = @UsersId


select * from CookBook
select * from BookRecipe

/*
select r.RecipeName, r.RecipeId from Recipe r where r.UsersId = @userId

select * from BookRecipe

select * from CookBook

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
where u.UsersId = @userId

select * from CookBook
drop SEQUENCE IncrementSequence
create sequence IncrementSequence start with 1 increment by 1; 

insert BookRecipe (CookBookId, RecipeId, BookRecipeSequence)
select c.CookBookId, r.RecipeId, next value for IncrementSequence over(order by r.RecipeName)
from CookBook c 
join Users u 
on u.UsersId = c.UsersId 
join Recipe r 
on r.UsersId = u.UsersId
where u.UsersId = @userId
order by r.RecipeName

select * from BookRecipe*/