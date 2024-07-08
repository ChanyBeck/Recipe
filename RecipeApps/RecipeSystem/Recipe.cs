 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");

            cmd.Parameters["@RecipeName"].Value = recipename;

            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable Load(int id)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");

            cmd.Parameters["@RecipeId"].Value = id;

            return SQLUtility.GetDataTable(cmd);
        }

        
        public static DataTable GetList(string sprocname)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);

            cmd.Parameters["@All"].Value = 1;

            return SQLUtility.GetDataTable(cmd);
        }

        public static void Save(DataTable dtrecipe)
        {
            //SQLUtility.DebugPringDataTable(dtrecipe);
            DataRow dr = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(dr, "RecipeUpdate");
            
            //SQLUtility.ExecuteSQL(sql);
        }
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["Recipeid"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
