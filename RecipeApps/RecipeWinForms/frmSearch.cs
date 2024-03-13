using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
        }

        private void SearchForRecipes(string recipename)
        {
            string sql = "select * from Recipe r where r.recipename is like '%" + recipename + "%'";
            Debug.Print(sql);
            DataTable dt = GetDataTable(sql);
            gRecipes.DataSource = dt;
           
        }
        private string GetConnectionString()
        {
            var s = "Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=True";
            return s;
        }

        private DataTable GetDataTable(string sqlstatement)
        {
            DataTable dt = new();
            SqlConnection conn = new();
            conn.ConnectionString = GetConnectionString();
            conn.Open();
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = sqlstatement;
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipes(txtRecipeName.Text);
        }
        
    }
}
