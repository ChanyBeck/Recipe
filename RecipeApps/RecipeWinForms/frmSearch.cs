using System.Data;
using System.Diagnostics;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            FormatGrid();
        }

        private void SearchForRecipes(string recipename)
        {
            string sql = "select r.RecipeId, r.RecipeName from Recipe r where r.recipename like '%" + recipename + "%'";
            Debug.Print(sql);
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipes.DataSource = dt;
            gRecipes.Columns["RecipeId"].Visible = false;
        }
        private void ShowRecipeForm(int rowindex)
        {
            int id = (int)gRecipes.Rows[rowindex].Cells["RecipeId"].Value;
            frmRecipe frm = new();
            frm.ShowForm(id);
        }
        private void FormatGrid()
        {
            gRecipes.AllowUserToAddRows = false;
            gRecipes.ReadOnly = true;
            gRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipes(txtRecipeName.Text);
        }

    }
}
