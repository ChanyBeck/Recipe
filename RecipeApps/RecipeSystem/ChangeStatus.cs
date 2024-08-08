using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class ChangeStatus
    {
        public static void Save(int id, string status)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("ChangeRecipeStatus");

            SQLUtility.SetParameterValue(cmd, "@RecipeId", id);

            SQLUtility.SetParameterValue(cmd, "@NewStatus", status);

            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
