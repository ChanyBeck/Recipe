use HeartyHearthDB
go 

drop table if exists BookRecipe
drop table if exists CookBook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Meal
drop table if exists Course
drop table if exists RecipeDirection
drop table if exists RecipeIngrediant
drop table if exists Recipe
drop table if exists Mesurement
drop table if exists Ingrediant
drop table if exists Cuisine
drop table if exists Users
go 

create table dbo.Users(
    UsersId int not null identity primary key,
    FirstName varchar(30) not null 
        constraint ck_User_First_Name_cannot_be_blank check(FirstName <> ''),
    LastName varchar(30) not null 
        constraint ck_User_Last_Name_cannot_be_blank check(LastName <> ''),
    UserName varchar(20) not null   
        constraint ck_Users_User_Name_cannot_be_blank check(UserName <> '')
        constraint u_Users_UserName unique
)

create table dbo.Cuisine(
    CuisineId int not null identity primary key, 
    CuisineType varchar (50) not null
        constraint ck_Cuisine_CuisinType_cannot_be_blank check(CuisineType <> '')
        constraint u_Cuisine_CuisineType unique
)

create table dbo.Ingrediant(
    IngrediantId int not null identity primary key,
    IngrediantName varchar(50) not null 
        constraint ck_Ingrediant_Name_canot_be_blank check(IngrediantName <> '')
        constraint u_Ingrediant_IngrediantName_unique unique,
    Picture as concat('Ingrediant_', replace(IngrediantName, ' ', '_'), '.jpg') persisted,
)

create table dbo.Mesurement(
    MesurementId int not null identity primary key, 
    MesurementType varchar(20) not null
        constraint ck_Mesurement_Type_cannot_be_blank check(MesurementType <> '')
        constraint u_Mesurement_MesurementType unique 
)
create table dbo.Recipe(
    RecipeId int not null identity primary key,
    UsersId int not null   
        constraint f_Users_Recipe foreign key references Users(UsersId),
    CuisineId int not null 
        constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(50) not null 
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName<> '')
        constraint u_Recipe_RecipeName unique,
    Picture as concat('Recipe_', replace(RecipeName, ' ', '_'), '.jpg') persisted,
    Calories int not null 
        constraint ck_Recipe_Calories_must_be_greater_than_zero check(Calories >= 0),
    DateDrafted datetime not null default getdate(),
    DatePublished datetime null 
        constraint ck_Recipe_Date_Published_must_be_later_than_current_date check(DatePublished <= getdate()),
    DateArchived datetime null 
        constraint ck_Recipe_Date_Archived_must_be_later_than_current_date check(DateArchived <= getdate()),
    RecipeStatus as case
        when DatePublished is null and DateArchived is null then 'Draft'
        when DateArchived is null then 'Published'
        else 'Archived'
        end,
    constraint ck_Recipe_Date_Published_must_be_greater_than_Date_Drafted check(DatePublished >= DateDrafted),
    constraint ck_Recipe_Date_Archived_must_be_greater_than_Date_Published_and_Date_drafted check(DateArchived >= DatePublished and DateArchived >= DateDrafted)
)

create table dbo.RecipeIngrediant(
    RecipeIngrediantId int not null identity primary key, 
    RecipeId int not null constraint f_Recipe_RecipeIngrediant foreign key references Recipe(RecipeId),
    IngrediantId int not null constraint f_Ingrediant_RecipeIngrediant foreign key references Ingrediant(IngrediantId),
    MesurementId int null constraint f_Mesurement_RecipeIngrediant foreign key references Mesurement(MesurementId),
    Amount decimal(5,2) not null 
        constraint ck_RecipeIngrediant_Amount_must_be_greater_than_zero check(Amount > 0),
    IngrediantSequence int not null 
        constraint ck_RecipeIngrediant_Ingrediant_Sequence_must_be_greater_than_zero check(IngrediantSequence > 0),
    constraint u_RecipeIngrediant_Recipe_Ingrediant_Sequence unique(RecipeId, IngrediantSequence),
    constraint u_RecipeIngrediant_Recipe_Ingrediant unique(RecipeId, IngrediantId)
)

create table dbo.RecipeDirection(
    RecipeDirectionId int not null identity primary key, 
    RecipeId int not null constraint f_Recipe_RecipeDirection foreign key references Recipe(RecipeId),
    Direction varchar(1000) not null constraint ck_RecipeDirection_Direction_cannot_be_blank check(Direction <> ''),
    DirectionSequence int not null 
        constraint ck_RecipeDirection_Direction_Sequence_must_be_greater_than_zero check(DirectionSequence > 0),
    constraint ck_RecipeDirection_Recipe_Direction_Sequence unique(RecipeId, DirectionSequence)
)

create table dbo.Course(
    CourseId int not null identity primary key, 
    CourseName varchar(40) not null 
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName <> '')
        constraint u_Course_CourseName unique,
    CourseSequence int not null 
        constraint ck_Course_CourseSequence_must_be_greater_than_zero check(CourseSequence > 0)
        constraint u_Course_CourseSequence unique
)

create table dbo.Meal(
    MealId int not null identity primary key, 
    UsersId int not null constraint f_Users_Meal foreign key references Users(UsersId),
    MealName varchar(50) not null 
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> '')
        constraint u_Meal_MealName unique,
    Picture as concat('Meal_', replace(MealName, ' ', '_'), '.jpg') persisted,
    IsActive bit not null, 
    MealCreated datetime not null default getdate()
)

create table dbo.MealCourse(
    MealCourseId int not null identity primary key, 
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
    constraint ck_MealCourse_Meal_Course_Recipe unique(MealId, CourseId)
)

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId), 
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    IsMain bit not null,
    constraint u_MealCourseRecipe_MealCourse_Recipe unique(MealCourseId, RecipeId)
)
create table dbo.CookBook(
    CookBookId int not null identity primary key, 
    UsersId int not null constraint f_Users_CookBook foreign key references Users(UsersId),
    Title varchar(100) not null 
        constraint ck_CookBook_Title_cannot_be_blank check(Title <> '')
        constraint u_CookBook_Title unique,
    Price decimal(5,2) not null 
        constraint ck_CookBook_Price_must_be_greater_than_zero check(Price > 0),
    Picture as concat('CookBook_', replace(Title, ' ', '_'), '.jpg') persisted,
    IsActive bit not null, 
    BookCreated datetime not null default getdate()
)

create table dbo.BookRecipe(
    BookRecipeId int not null identity primary key, 
    CookBookId int not null constraint f_CookBook_BookRecipe foreign key references CookBook(CookBookId),
    RecipeId int not null constraint f_Recipe_BookRecipe foreign key references Recipe(RecipeId), 
    BookRecipeSequence int not null
        constraint ck_BookRecipe_Sequnce_must_be_greater_than_zero check(BookRecipeSequence > 0), 
    constraint u_BookRecipe_Book_Recipe unique(CookBookId, RecipeId), 
    constraint u_BookRecipe_Book_BookRecipeSequence unique(CookBookId, BookRecipeSequence)
)