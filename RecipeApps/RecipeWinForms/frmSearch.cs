using System.Data;
using System.Diagnostics;


namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            txtRecipeName.KeyDown += TxtRecipeName_KeyDown;
            gRecipes.KeyDown += GRecipes_KeyDown;
        }


        public void SearchForRecipes(string recipename)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt = Recipe.SearchRecipe(recipename);
                gRecipes.DataSource = dt;
                WindowsFormsUtility.FormatGridForSearch(gRecipes, "recipe");
                if (gRecipes.Rows.Count > 0)
                {
                    gRecipes.Focus();
                    gRecipes.Rows[0].Selected = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        private void DoSearch()
        {
            SearchForRecipes(txtRecipeName.Text);
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            DoSearch();
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
        private void TxtRecipeName_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoSearch();
            }
        }
        private void GRecipes_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipes.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipes.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
