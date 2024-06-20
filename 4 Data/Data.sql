use HeartyHearthDB
go 

delete BookRecipe
delete CookBook
delete MealCourseRecipe
delete MealCourse
delete Meal
delete Course
delete RecipeDirection
delete RecipeIngredient
delete Recipe
delete Measurement
delete Ingredient
delete Cuisine
delete Users
go 

insert Users(FirstName, LastName, UserName)
select 'Guy', 'Fieri', 'GFieri'
union select 'Michael', 'Caines', 'MCaines'
union select 'Jamie', 'Oliver', 'JOliver'
union select 'Gordon', 'Ramsay', 'GRamsay'

insert Cuisine(CuisineType)
select 'French'
union select 'American'
union select 'Italian'
union select 'English'

insert Ingredient(IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Flour'
union select 'Eggs'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apple'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cubes'
union select 'Club Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Garlic'
union select 'Black Pepper'
union select 'Salt'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'
union select 'Vanilla Pudding'

insert measurement(measurementType)
select 'Cup'
union select 'Tsp'
union select 'Tbsp'
union select 'Oz.'
union select 'Cloves'
union select 'Pinch'
union select 'Stick'

;
with x as(
    select UserName = 'GRamsay', CuisineType = 'English', RecipeName = 'Chocolate Chip Cookies', Calories = 100, DatePublished = getdate(), DateArchived = getdate()
    union select 'GFieri', 'French', 'Apple Yogurt Smoothie', 80, getdate(), null
    union select 'MCaines', 'English', 'Cheese Bread', 200, null, null
    union select 'GFieri', 'American', 'Butter Muffins', 150, getdate(), null
    union select 'JOliver', 'Italien', 'Maple Fish', 120, null, null
    union select 'JOliver','French', 'Rib Steak', 250, null, null
    union select 'GRamsay', 'English', 'Brownie', 100, null, null
    union select 'GRamsay', 'American', 'Hash Browns', 100, getdate(), null
)
insert Recipe(UsersId, CuisineId, RecipeName, Calories, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DatePublished, x.DateArchived
from x
join Users u
on x.UserName = u.UserName
join Cuisine c 
on x.CuisineType = c.CuisineType

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', Ingredient = 'Sugar', measurement = 'Cup', Amount = 1, IngredientSequence = 1
    union select 'Chocolate Chip Cookies', 'Oil', 'Cup', 0.5, 2
    union select 'Chocolate Chip Cookies', 'Eggs', null, 3, 3
    union select 'Chocolate Chip Cookies', 'Flour', 'Cup', 2, 4
    union select 'Chocolate Chip Cookies', 'Vanilla Sugar', 'Tsp', 1, 5
    union select 'Chocolate Chip Cookies', 'Baking Powder', 'Tsp', 2, 6
    union select 'Chocolate Chip Cookies', 'Baking Soda', 'Tsp', 0.5, 7
    union select 'Chocolate Chip Cookies', 'Chocolate Chips', 'Cup', 1, 8
    union select 'Apple Yogurt Smoothie', 'Granny Smith Apple', null, 3, 1
    union select 'Apple Yogurt Smoothie', 'Vanilla Yogurt', 'Cup', 2, 2
    union select 'Apple Yogurt Smoothie', 'Sugar', 'Tsp', 2, 3
    union select 'Apple Yogurt Smoothie', 'Orange Juice', 'Cup', 0.5, 4
    union select 'Apple Yogurt Smoothie', 'Honey', 'Tbsp', 2, 5
    union select 'Apple Yogurt Smoothie', 'Ice Cubes', null, 5, 6
    union select 'Cheese Bread', 'Club Bread', null, 1, 1
    union select 'Cheese Bread', 'Butter', 'Oz.', 4, 2
    union select 'Cheese Bread', 'Shredded Chees', 'Oz.', 8, 3
    union select 'Cheese Bread', 'Garlic', 'Cloves', 2,4
    union select 'Cheese Bread', 'Black Pepper', 'Tsp', 0.25, 5
    union select 'Cheese Bread', 'Salt', 'Pinch', 1, 6
    union select 'Butter Muffins', 'Butter', 'Stick', 1, 1
    union select 'Butter Muffins', 'Sugar', 'Cup', 3,2
    union select 'Butter Muffins', 'Vanilla Pudding', 'Tbsp', 2,3
    union select 'Butter Muffins', 'Eggs', null, 4, 4
    union select 'Butter Muffins', 'Whipped Cream Cheese', 'Oz.', 8, 5
    union select 'Butter Muffins', 'Sour Cream Cheese', 'Oz.', 8, 6
    union select 'Butter Muffins', 'Flour', 'Cup', 1, 7
    union select 'Butter Muffins', 'Baking Powder', 'Tsp', 2, 8
)
insert RecipeIngredient(RecipeId, IngredientId, measurementId, Amount, IngredientSequence)
select r.RecipeId, i.ingredientId, m.measurementId, x.Amount, x.ingredientSequence 
from x
join Recipe r
on r.RecipeName = x.Recipe
join ingredient i 
on i.ingredientName = x.ingredient
left join measurement m 
on m.measurementType = x.measurement

;
with x as(
    select Direction = 'First combine sugar, oil and eggs in a bowl', DirectionSequence = 1
    union select 'mix well', 2
    union select 'add flour, vanilla sugar, baking powder and baking soda', 3
    union select 'beat for 5 minutes', 4
    union select 'add chocolate chips', 5
    union select 'freeze for 1-2 hours', 6
    union select 'roll into balls and place spread out on a cookie sheet', 7
    union select 'bake on 350 for 10 min.', 8
)
insert RecipeDirection(RecipeId, Direction, DirectionSequence)
select r.RecipeId, x.Direction, x.DirectionSequence
from x
join Recipe r 
on r.RecipeName = 'Chocolate Chip Cookies'

;
with x as(
    select Direction = 'Peel the apples and dice', DirectionSequence = 1
    union select 'Combine all ingredients in bowl except for apples and ice cubes', 2
    union select 'mix until smooth', 3
    union select 'add apples and ice cubes', 4
    union select 'pour into glasses. ', 5
)
insert RecipeDirection(RecipeId, Direction, DirectionSequence)
select r.RecipeId, x.Direction, x.DirectionSequence
from x
join Recipe r 
on r.RecipeName = 'Apple Yogurt Smoothie'

;
with x as(
    select Direction = 'Slit bread every 3/4 inch', DirectionSequence = 1
    union select 'Combine all ingredients in bowl', 2
    union select 'fill slits with cheese mixture', 3
    union select 'wrap bread into a foil and bake for 30 minutes.', 4
)
insert RecipeDirection(RecipeId, Direction, DirectionSequence)
select r.RecipeId, x.Direction, x.DirectionSequence
from x
join Recipe r 
on r.RecipeName = 'Cheese Bread'

;
with x as(
    select Direction = 'Cream butter with sugars', DirectionSequence = 1
    union select 'Add eggs and mix well', 2
    union select 'Slowly add rest of ingredients and mix well', 3
    union select 'fill muffin pans 3/4 full and bake for 30 minutes.', 4
)
insert RecipeDirection(RecipeId, Direction, DirectionSequence)
select r.RecipeId, x.Direction, x.DirectionSequence
from x
join Recipe r 
on r.RecipeName = 'Butter Muffins'

insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Main Course', 2
union select 'Dessert', 3

;
with x as(
    select UserName = 'GRamsay', MealName = 'Breakfast bash', IsActive = 1
    union select 'JOliver', 'Fine Dinning', 1
    union select 'MCaines', 'Lunch', 0
    union select 'GRamsay', 'Party', 1
)
insert Meal(UsersId, MealName, IsActive)
select u.UsersId, x.MealName, x.IsActive
from x
join Users u 
on x.UserName = u.UserName

;
with x as(
    select Meal = 'BreakFast Bash', Course = 'Appetizer'
    union select 'Breakfast Bash', 'Main Course'
    union select 'Fine Dinning', 'Appetizer'
    union select 'Fine Dinning', 'Main Course'
    union select 'Fine Dinning', 'Dessert'
    union select 'Lunch', 'Main Course'
    union select 'Lunch', 'Dessert'
    union select 'Party', 'Dessert'
)
insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId
from x 
join Meal m 
on m.MealName = x.Meal
join Course c 
on c.CourseName = x.Course

;
with x as(
    select Recipe = 'Apple Yogurt Smoothie', IsMain = 1
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x
join Meal m 
on m.MealName = 'Breakfast Bash'
join Course c 
on c.CourseName = 'Appetizer' 
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId
join Recipe r 
on r.RecipeName = x.Recipe

;
with x as(
    select Recipe = 'Cheese Bread', IsMain = 1
    union select 'Butter Muffins', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Meal m 
on m.MealName = 'Breakfast Bash'
join Course c
on c.CourseName = 'Main Course'
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId 
join Recipe r 
on r.RecipeName = x.Recipe

;
with x as(
    select Recipe = 'Maple Fish', IsMain = 1
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Meal m 
on m.MealName = 'Fine Dinning'
join Course c
on c.CourseName = 'Appetizer'
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId 
join Recipe r 
on r.RecipeName = x.Recipe
;
with x as(
    select Recipe = 'Maple Fish', IsMain = 1
    union select 'Hash Browns', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Meal m 
on m.MealName = 'Fine Dinning'
join Course c
on c.CourseName = 'Main Course'
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId 
join Recipe r 
on r.RecipeName = x.Recipe

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', IsMain = 1
    union select 'Butter Muffins', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Meal m 
on m.MealName = 'Fine Dinning'
join Course c
on c.CourseName = 'Dessert'
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId 
join Recipe r 
on r.RecipeName = x.Recipe
;
with x as(
    select Recipe = 'Cheese Bread', IsMain = 0
    union select 'Maple Fish', 1
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Meal m 
on m.MealName = 'Lunch'
join Course c
on c.CourseName = 'Main Course'
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId 
join Recipe r 
on r.RecipeName = x.Recipe
;
with x as(
    select Recipe = 'Brownie', IsMain = 1
    union select 'Butter Muffins', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Meal m 
on m.MealName = 'Lunch'
join Course c
on c.CourseName = 'Dessert'
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId 
join Recipe r 
on r.RecipeName = x.Recipe
;
with x as(
    select Recipe = 'Chocolate Chip Cookies', IsMain = 1
    union select 'Butter Muffins', 0
    union select 'Brownie', 0
    union select 'Apple Yogurt Smoothie', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Meal m 
on m.MealName = 'Party'
join Course c
on c.CourseName = 'Dessert'
join MealCourse mc 
on mc.MealId = m.MealId 
and mc.CourseId = c.CourseId 
join Recipe r 
on r.RecipeName = x.Recipe

insert CookBook(UsersId, Title, Price, IsActive)
select u.UsersId, 'Everyday Cooking', 40, 1 from Users u where u.UserName = 'GRamsay'
union select u.UsersId, 'Joy of Cooking', 59.99, 0 from Users u where u.UserName = 'MCaines'
union select u.UsersId, 'Treats for two',30, 1 from Users u where u.UserName = 'MCaines'

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', RecipeSequence = 1
    union select 'Apple Yogurt Smoothie', 2
    union select 'Cheese Bread', 3
    union select 'Butter Muffins', 4
)
insert BookRecipe(CookBookId, RecipeId, BookRecipeSequence)
select cb.CookBookId, r.RecipeId, x.RecipeSequence
from x 
join CookBook cb 
on cb.Title = 'Everyday Cooking'
join Recipe r 
on r.RecipeName = x.Recipe

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', RecipeSequence = 1
    union select 'Apple Yogurt Smoothie', 2
    union select 'Maple Fish', 3
    union select 'Butter Muffins', 4
    union select 'Brownie', 5
)
insert BookRecipe(CookBookId, RecipeId, BookRecipeSequence)
select cb.CookBookId, r.RecipeId, x.RecipeSequence
from x 
join CookBook cb 
on cb.Title = 'Joy of Cooking'
join Recipe r 
on r.RecipeName = x.Recipe 

;
with x as(
    select Recipe = 'Brownie', RecipeSequence = 1
    union select 'Apple Yogurt Smoothie', 2
    union select 'Butter Muffins', 4
    union select 'Cheese Bread', 5
    union select 'Hash Browns', 6
    union select 'Chocolate Chip Cookies', 7
    union select 'Maple Fish', 8
)
insert BookRecipe(CookBookId, RecipeId, BookRecipeSequence)
select cb.CookBookId, r.RecipeId, x.RecipeSequence
from x 
join CookBook cb 
on cb.Title = 'Treats for two'
join Recipe r 
on r.RecipeName = x.Recipe 


select * from Users
select * from Cuisine
select * from ingredient 
select * from measurement
select * from Recipe
select * from Recipeingredient 
select * from RecipeDirection
select * from Course
select * from Meal
select c.CourseName, m.MealName 
from MealCourse mc 
join Meal m 
on m.MealId =  mc.MealId 
join Course c 
on mc.CourseId = c.CourseId
select r.RecipeName, m.MealName, c.CourseName from MealCourseRecipe mcr 
join MealCourse mc 
on mc.MealCourseId = mcr.MealCourseId 
join Meal m 
on m.MealId = mc.MealId 
join Course c 
on c.CourseId = mc.CourseId 
join Recipe r 
on r.RecipeId = mcr.RecipeId
select * from CookBook
select * from BookRecipe
