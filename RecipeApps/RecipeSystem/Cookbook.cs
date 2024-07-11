using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Cookbook
    {
        public static DataTable GetList(string sprocname)
        {
            //DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable Load(int id)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookGet");

            cmd.Parameters["@CookbookId"].Value = id;

            return SQLUtility.GetDataTable(cmd);
        }

    }
}
