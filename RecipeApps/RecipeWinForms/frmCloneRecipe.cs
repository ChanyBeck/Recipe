using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        DataTable dtrecipe = new();

        public frmCloneRecipe()
        {
            InitializeComponent();
            GetRecipeList();
            btnClone.Click += BtnClone_Click;
        }

        private void GetRecipeList()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, Recipe.GetList("RecipeGet", true), "Recipe", null);
        }
        private void CreateRecipe()
        {
            int recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            Cursor = Cursors.WaitCursor;
            try
            {
                dtrecipe = Recipe.CloneRecipe(recipeid);
                recipeid = (int)dtrecipe.Rows[0]["recipeId"];
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CreateRecipe();
        }


    }
}
