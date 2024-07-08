using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Ingredients
    {
        public static DataTable Load(int id)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");

            cmd.Parameters["@RecipeId"].Value = id;

            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable GetList(string tablename)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("IngredientGet");

            cmd.Parameters["@All"].Value = 1;

            return SQLUtility.GetDataTable(cmd);
        }
        public static void Save(DataTable dtingredients, int id)
        {
            foreach(DataRow row in dtingredients.Select("", "", DataViewRowState.Added))
            {
                row["RecipeId"] = id;
            }
            SQLUtility.SaveDataTable(dtingredients, "RecipeIngredientUpdate");
        }
        public static void Delete(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientDelete");
            cmd.Parameters["@RecipeIngredientId"].Value = id;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
