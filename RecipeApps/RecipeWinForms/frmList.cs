using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
            RecipeList("RecipeListGet");
            btnNew.Click += BtnNew_Click;
            gridListRecipes.CellClick += GridListRecipes_CellClick;
            this.Activated += FrmList_Activated;
        }

        private void FrmList_Activated(object? sender, EventArgs e)
        {
            RecipeList("RecipeListGet");
        }

        public void RecipeList(string sprocname)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt = Recipe.GetList(sprocname);
                gridListRecipes.DataSource = dt;
                WindowsFormsUtility.FormatGridForSearch(gridListRecipes, "recipe");
                if (gridListRecipes.Rows.Count > 0)
                {
                    gridListRecipes.Focus();
                    gridListRecipes.Rows[0].Selected = true;
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
                id = WindowsFormsUtility.GetIdFromGrid(gridListRecipes, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        private void GridListRecipes_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
