using System.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class Cookbook
    {
        public static DataTable GetList(string sprocname)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);

            cmd.Parameters["@All"].Value = 1;

            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable Load(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookGet");

            cmd.Parameters["@CookbookId"].Value = id;

            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadRecipe(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeCookbookGet");

            cmd.Parameters["@CookbookId"].Value = id;

            return SQLUtility.GetDataTable(cmd);
        }
        public static void Save(DataTable dtcookbook)
        {
            DataRow dr = dtcookbook.Rows[0];

            SQLUtility.SaveDataRow(dr, "CookbookUpdate");
        }

        public static void SaveRecipe(DataTable dtrecipe)
        {
           SQLUtility.SaveDataTable(dtrecipe, "RecipeCookbookUpdate"); 
        }

        public static void Delete() { }

        public static void DeleteRecipe(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeCookbookDelete");

            SQLUtility.SetParameterValue(cmd, "@BookRecipeId", id);

            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
