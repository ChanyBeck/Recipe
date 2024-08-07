declare @cookbookid int 

select top 1 @cookbookid = c.CookBookId from CookBook c 

exec RecipeCookbookget @cookbookid = @cookbookid