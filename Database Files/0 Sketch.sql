-- SM Excellent sketch! 100% See comments, no need to resubmit.
-- Good luck on DB!
/*
HEARTY HEATH

Users
    FirstName varchar(30) not null
    LastName Varchar(30) not null
    username varchar(20) not null not blank unique

Cuisine
    Cuisine type varchar(20) not null not blank
    unique

Ingredients
    Ing. varchar(50) not null not blank
    unique
    Picture path+ tablename + Ing.

Mesurement
    Type varchar(20) not null not blank 
    unique

Recipe
    userId
    cuisineId
    Name varchar(50) unique not null not blank
    Picture  concat path+ tablename + name
    Calories int not null >= 0
    DateDrafted not null getdate()
    DatePublished datetimwe null >= datedrafted <= getdate() 
-- SM You just need to check that it's after DatePublished and after DateDrafted. null values are ignored by check constraint.
    DateArchived date null <= getdate() check(DateArchived >= DatePublished) and (DateArchived >= DateDrafted)
    status case when DatePublished is null and DateArchived is null then 'Draft'
        when DateArchived is null then 'Published'
        else 'Archived'


RecipeIngredients()
    RecipeId
    IngId
    Sequence int > 0
    MesurementId null
    Amount decimal(5,2) not null > 0
    unique(Recipe, Ing)
    unique(sequence, recipe)

RecipeDirection
    RecipeId#
    Sequence int >0
    directions varchar(1000) not null not blank
    unique(recipe, sequence)

Course
    CourseName varchar(30) unique not null not blank
    Sequence int not null unique > 0 

Meal
    UserId
    Name varchar(50) unique not null not blank
    Picture path+ tablename + name 
    Isactive bit not null
    DateCreated not null getdate() 

MealCourse
    MealId
    CourseId
    unique(meal, course)

MealCourseRecipe
    MealCourseId
    RecipeId
    IsMain bit not null
    unique(MealCourse, Recipe)

CookBook
    UserId
    Name varchar(50) not null not blank unique
    Price decimal(5,2) not null > 0
    Picture path+ tablename + name
    IsActive bit not null
    DateCreated not null getdate() 

BookRecipe
    BookId
    RecipeId
    Sequence int > 0
    unique(book, sequence)
    unique(Bookid, Recipeid)
*/