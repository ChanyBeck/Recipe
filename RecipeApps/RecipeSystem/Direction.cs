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

            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDirectionGet");

            cmd.Parameters["@RecipeId"].Value = id;

            return SQLUtility.GetDataTable(cmd);
        }
        public static void Save(DataTable dt, int id)
        {
            foreach(DataRow row in dt.Select("", "", DataViewRowState.Added))
            {
                row["RecipeId"] = id;
            }
            SQLUtility.SaveDataTable(dt, "RecipeDirectionUpdate");
        }

        public static void Delete(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDirectionDelete");

            cmd.Parameters["@RecipeDirectionId"].Value = id;
            
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
