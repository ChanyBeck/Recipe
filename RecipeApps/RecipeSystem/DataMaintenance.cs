using System.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public static class DataMaintenance
    {
        public static DataTable GetList(string tablename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }
    }
}
