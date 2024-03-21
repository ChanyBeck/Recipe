using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "select r.RecipeId, r.RecipeName from Recipe r where r.recipename like '%" + recipename + "%'"; ;
            DataTable dt = SQLUtility.ExecuteSQL(sql);
            return dt;
        }
        public static DataTable Load(int id)
        {
            string sql = "select r.*, c.CuisineType, u.UserName from Recipe r join Cuisine c on c.CuisineId = r.CuisineId join Users u on u.UsersId = r.UsersId where r.RecipeId =" + id;
            return SQLUtility.ExecuteSQL(sql);
        }
        public static DataTable GetList(string tablename, string columnname)
        {
            return SQLUtility.ExecuteSQL($"select {tablename}id, {columnname} from {tablename}");
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPringDataTable(dtrecipe);
            DataRow dr = dtrecipe.Rows[0];
            int id = (int)dr["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{dr["Recipename"]}',",
                    $"Calories = {dr["Calories"]},",
                    $"CuisineId = '{dr["CuisineId"]}',",
                    //$"DateArchived = '{dr["DateArchived"]}',",
                    $"DatePublished = '{dr["DatePublished"]}',",
                    $"UsersId = '{dr["UsersId"]}'",
                    $"where recipeid = {dr["RecipeId"]}");
            }
            else
            {
                sql = "insert recipe(Recipeid, Calories, CuisineId, DateDrafted, DatePublished, UsersId) ";
                sql += $"select '{dr["Recipeid"]}', {dr["Calories"]}, '{dr["CuisineId"]}', '{dr["DateDrafted"]}', '{dr["DatePublished"]}', '{dr["UsersId"]}'";

            }
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
        }
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["Recipeid"];
            string sql = "Delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
