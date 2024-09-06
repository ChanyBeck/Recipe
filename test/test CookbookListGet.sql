declare @cookbookid int 

	select top 1 @Cookbookid = b.CookBookId
	from CookBook b 
    join Users u 
    on u.UsersId = b.UsersId
    join BookRecipe r 
    on r.CookBookId = b.CookBookId

    exec CookBookListGet @all = 1


