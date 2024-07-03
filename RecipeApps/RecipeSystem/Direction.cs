using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Direction
    {
        public static DataTable Load(int id)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeRecipeDirectionGet");

            cmd.Parameters["@RecipeId"].Value = id;

            return SQLUtility.GetDataTable(cmd);
        }
        public static void Save(DataTable dtrecipe)
        {
            DataRow dr = dtrecipe.Rows[0];

            SQLUtility.SaveDataRow(dr, "RecipeRecipeDirectionUpdate");
        }
    }
}
