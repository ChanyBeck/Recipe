using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace RecipeTest
{
    public class RecipeTests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        [Test]
        public void GetCuisineList()
        {
            int lstcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from Cuisine");

            Assume.That(lstcount > 0, "No records in table, can't test");

            TestContext.WriteLine("Num of cuisine in DB = " + lstcount);
            TestContext.WriteLine("Ensure num of rows returned = " + lstcount);

            DataTable dt = Recipe.GetList("CuisineGet");

            Assert.IsTrue(dt.Rows.Count == lstcount, "Num of rows returned (" + dt.Rows.Count + ") does not equal to total cuisine types (" + lstcount + ")");
            TestContext.WriteLine("Number of rows in Cuisine = " + dt.Rows.Count);
        }

        [Test]
        public void SaveMultipleRows()
        {
            string sql = "delete Cuisine where cuisinetype in ('TestCuisine1', 'TestCuisine2')";
            SQLUtility.ExecuteSQL(sql);
            sql = "update cuisine set cuisinetype = 'cuisine' where cuisinetype = 'TestChange1'";
            SQLUtility.ExecuteSQL(sql);
            DataTable dt = DataMaintenance.GetList("Cuisine");
            var dr = dt.Rows.Add();
            dr["CuisineType"] = "TestCuisine1";
            dr = dt.Rows.Add();
            dr["CuisineType"] = "TestCuisine2";
            dt.Rows[0]["CuisineType"] = "TestChange1";
            SQLUtility.SaveDataTable(dt, "CuisineUpdate");

            sql = "select * from Cuisine where CuisineType in ('TestCuisine1', 'TestCuisine2', 'TestChange1')";
            DataTable dtcheck = SQLUtility.ExecuteSQL(sql);
            Assert.IsTrue(dtcheck.Rows.Count == 3, $"num rows of dtcheck is {dt.Rows.Count}");
            TestContext.WriteLine($"num rows of dtcheck should be 3 and it is {dt.Rows.Count}");
        }

        [Test]
        public void CloneRecipe()
        {
            int recipeid = GetExisitingRecipeId();
            DataTable dtrecipe = SQLUtility.ExecuteSQL("select recipename from recipe where recipeid = " + recipeid);
            string recipename = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "recipename");

            Assume.That(recipeid > 0, "No recipes in DB, cannot test");

            TestContext.WriteLine("clone recipe = " + recipename);
            TestContext.WriteLine("Ensure recipename " + recipename + " -clone exists");

            DataTable dtclone = Recipe.CloneRecipe(recipeid);
            string recipeclone = dtclone.Rows[0]["recipename"].ToString();

            Assert.IsTrue(recipename + " -clone" == recipeclone, recipeclone + " does not exist");
            TestContext.WriteLine("new record with recipename = " + recipeclone);
        }
        public void UpdateStatus()
        {
            int recipeid = GetExisitingRecipeId();
            DataTable dtrecipe = SQLUtility.ExecuteSQL("select recipename from recipe where recipeid = " + recipeid);
            string recipename = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "recipename");

            Assume.That(recipeid > 0, "No recipes in DB, cannot test");

            TestContext.WriteLine("clone recipe = " + recipename);
            TestContext.WriteLine("Ensure recipename " + recipename + " -clone exists");

            DataTable dtclone = Recipe.CloneRecipe(recipeid);
            string recipeclone = dtclone.Rows[0]["recipename"].ToString();

            Assert.IsTrue(recipename + " -clone" == recipeclone, recipeclone + " does not exist");
            TestContext.WriteLine("new record with recipename = " + recipeclone);
        }

        [Test]
        public void AutoCreateCookbook()
        {
            int cookbookcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cookbook");
            int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");

            Assume.That(usersid > 0, "No users in DB, cannot test");

            TestContext.WriteLine("Total cookbook count in DB = " + cookbookcount);
            TestContext.WriteLine("Ensure the count in DB now has " + (cookbookcount+1) + " cookbooks and new cookbook added for userid " + usersid);

            DataTable dtcookbook = Cookbook.AutoCreateCookbook(usersid);
            int cookbookuserid = (int)dtcookbook.Rows[0]["UsersId"];

            int newcookbookcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cookbook");

            Assert.IsTrue(newcookbookcount == cookbookcount +1 && cookbookuserid == usersid, "Cookbook count is " + newcookbookcount + " no new records were added.");
            TestContext.WriteLine("Cookbooks in DB = " + newcookbookcount + ", new cookbook added for " + cookbookuserid);
        }

        [Test]
        public void GetUsersList()
        {
            int lstcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from users");

            Assume.That(lstcount > 0, "No records in table, cannot test");

            TestContext.WriteLine("Num of users in DB = " + lstcount);
            TestContext.WriteLine("Ensure num of rows returned = " + lstcount);

            DataTable dt = Recipe.GetList("UsersGet");

            Assert.IsTrue(dt.Rows.Count == lstcount, "Num of rows returned (" + dt.Rows.Count + ") does not equal to total username in DB (" + lstcount + ")");
            TestContext.WriteLine("Number of rows in users = " + dt.Rows.Count);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExisitingRecipeId();

            Assume.That(recipeid > 0, "No recipes in DB, cannot test");

            TestContext.WriteLine("recipe id in DB = " + recipeid);
            TestContext.WriteLine("Ensure recipe id returned = " + recipeid);

            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["RecipeId"];

            Assert.IsTrue(loadedid == recipeid, "recipe id returned (" + loadedid + "), does not equal to DB (" + recipeid + ")");
            TestContext.WriteLine("Loaded recipe id = " + recipeid);
        }

        [Test]
        public void DeleteRecipe()
        {
            string sql = @"
            select *
            from Recipe r 
            left join MealCourseRecipe mcr 
            on mcr.RecipeId = r.RecipeId
            left join BookRecipe br 
            on br.RecipeId = r.RecipeId
            where (r.RecipeStatus = 'Draft' or datediff(day, getdate(), r.DateArchived) > 30)
            and mcr.MealCourseRecipeId is null 
            and br.BookRecipeId is null
            order by r.RecipeId
            ";
            DataTable dt = SQLUtility.ExecuteSQL(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["Recipename"].ToString();
            }

            Assume.That(recipeid > 0, "No recipes without related tables in DB, cannot test");

            TestContext.WriteLine("recipe id with no related tables in DB = " + recipeid + " and recipename = " + recipedesc);
            TestContext.WriteLine("Ensure app can delete recipe id " + recipeid);

            Recipe.Delete(dt);

            DataTable dtafterdelete = SQLUtility.ExecuteSQL("select * from recipe where recipeid = " + recipeid);

            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "recipe with id (" + recipeid  + ") exists in DB");
            TestContext.WriteLine("recipe with id " + recipeid + " and recipe name " + recipedesc + " deleted from DB");
        }

        [Test]
        public void DeleteRecipeWithRelatedTables()
        {
            DataTable dt = SQLUtility.ExecuteSQL("select top 1 r.RecipeId, r.Recipename from Recipe r join MealCourseRecipe mcr on mcr.RecipeId = r.RecipeId join BookRecipe br on br.RecipeId = r.RecipeId where r.RecipeStatus = 'Draft' or datediff(day, getdate(), r.DateArchived) < 30");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["Recipename"].ToString();
            }

            Assume.That(recipeid > 0, "No recipes with related tables in DB, cannot test");

            TestContext.WriteLine("recipe id with related tables in DB = " + recipeid + " and recipename = " + recipedesc);
            TestContext.WriteLine("Ensure app cannot delete recipe id " + recipeid);

            Exception ex =  Assert.Throws<Exception>(()=> Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeCaloriesToInvalidNumber()
        {
            int recipeid = GetExisitingRecipeId();
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);

            Assume.That(recipeid > 0, "No recipes without related tables in DB, cannot test");

            TestContext.WriteLine("calories for recipe (" + recipeid + ") is " + calories);
            calories = -1;
            TestContext.WriteLine("Change calories for recipe (" + recipeid + ") to " + calories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["Calories"] = calories;
            Exception ex = Assert.Throws<Exception>(()=> Recipe.Save(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeRecipeToInvalidName()
        {
            int recipeid = GetExisitingRecipeId();
            Assume.That(recipeid > 0, "No recipes without related tables in DB, cannot test");

            DataTable dt = SQLUtility.ExecuteSQL("select top 1 recipename from recipe where recipeid <> " + recipeid);
            string name = dt.Rows[0]["Recipename"].ToString();
            Assume.That(name != "", "Cannot run, no other record in table");

            TestContext.WriteLine("Change recipeid (" + recipeid + ") name to " + name);

            DataTable dtload = Recipe.Load(recipeid);
            dtload.Rows[0]["RecipeName"] = name;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dtload));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void UpdateRecipeCalories()
        {
            int recipeid = GetExisitingRecipeId();
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);

            Assume.That(recipeid > 0, "No recipes without related tables in DB, cannot test");

            TestContext.WriteLine("calories for recipe (" + recipeid + ") is " + calories);
            calories += calories;
            TestContext.WriteLine("Change calories for recipe (" + recipeid + ") to " + calories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["Calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "Calories for recipe (" + recipeid + ") equales " + newcalories);
            TestContext.WriteLine("recipe with id " + recipeid + " has " + calories + " calories in DB");
        }

        [Test]
        public void InsertNewRecord()
        {
            DataTable dt = SQLUtility.ExecuteSQL("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();

            Assume.That(dt.Rows.Count == 1);

            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "No Recipes in DB, cannot test");
            int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            Assume.That(cuisineid > 0, "No Recipes in DB, cannot test");
            string recipename = "test " + DateTime.Now;

            TestContext.WriteLine("insert recipe with recipe name " + recipename);

            r["cuisineid"] = cuisineid;
            r["usersid"] = usersid;
            r["Calories"] = 100;
            r["recipename"] = recipename;
            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = '" + recipename + "'");
            Assert.IsTrue(newid > 0, "recipe with name " + recipename + "is not found in DB");
            TestContext.WriteLine("Recipe with recipename " + recipename + "exists in DB");
        }
        private int GetExisitingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}