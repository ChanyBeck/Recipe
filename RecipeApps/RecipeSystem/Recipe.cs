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


        public static DataTable GetList(string sprocname, bool includeblank = false)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);

            cmd.Parameters["@All"].Value = 1;

            if (includeblank == true)
            {
                SQLUtility.SetParameterValue(cmd, "@includeblank", 1);
            }

            return SQLUtility.GetDataTable(cmd);
        }

        public static void CloneRecipe(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");

            SQLUtility.SetParameterValue(cmd, "@BaseRecipeId", recipeid);

            SQLUtility.ExecuteSQL(cmd);
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
        public static string GetRecipeDesc(DataTable dtrecipe)
        {
            string value = "New Recipe";
            int pk = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pk > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

    }
}
