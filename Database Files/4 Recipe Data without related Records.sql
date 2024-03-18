;
with x as(
    select UserName = 'GRamsay', CuisineType = 'English', RecipeName = 'Green Salad', Calories = 100, DatePublished = getdate(), DateArchived = getdate()
    union select 'GFieri', 'French', 'French Toast', 80, getdate(), null
    union select 'MCaines', 'English', 'Cherry Pie', 200, null, null
)
insert Recipe(UsersId, CuisineId, RecipeName, Calories, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DatePublished, x.DateArchived
from x
join Users u
on x.UserName = u.UserName
join Cuisine c 
on x.CuisineType = c.CuisineType