
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        DataTable dtingredient;
        BindingSource bs = new();
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnIngredientsSave.Click += BtnIngredientsSave_Click;
            foreach (Control c in tblMain.Controls)
            {
                c.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            }
            this.FormClosing += FrmRecipe_FormClosing;
        }

        public void ShowForm(int recipeid)
        {
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bs.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtUsers = Recipe.GetList("Users");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, "Users", dtrecipe);
            DataTable dtCuisine = Recipe.GetList("Cuisine");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, "Cuisine", dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, bs);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bs);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bs);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bs);
            //WindowsFormsUtility.SetControlBinding(lblPicture, bs);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bs);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bs);
            this.Text = GetRecipeDesc();
            this.Show();
            SearchForIngredients(recipeid);
            SearchForSteps(recipeid);
        }
        public void SearchForSteps(int recipeid)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt = new();
                gridSteps.DataSource = Direction.Load(recipeid);
                WindowsFormsUtility.FormatGridForEdit(gridSteps, "recipeRecipeDirection");
                if (gridSteps.Rows.Count > 0)
                {
                    gridSteps.Focus();
                    gridSteps.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        public void SearchForIngredients(int recipeid)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                dtingredient = Ingredients.Load(recipeid);
                gridIngredients.DataSource = dtingredient;
                WindowsFormsUtility.AddComboBoxToGrid(gridIngredients, Recipe.GetList("Measurement"), "MeasurementType", "Measurement");
                WindowsFormsUtility.AddComboBoxToGrid(gridIngredients, Recipe.GetList("Ingredient"), "ingredientName", "Ingredient");
                WindowsFormsUtility.FormatGridForEdit(gridIngredients, "RecipeIngredient");
                if (gridIngredients.Rows.Count > 0)
                {
                    gridIngredients.Focus();
                    gridIngredients.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private bool SaveRecipe()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                this.Tag = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(SQLUtility.ParseConstraintMessage(ex.Message));
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            string alloweddelete = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "IsDeleteAllowed");
            if (alloweddelete != "")
            {
                MessageBox.Show(alloweddelete, Application.ProductName);
                return;
            }
            var response = MessageBox.Show("Are you sure you wan to delete this Recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(SQLUtility.ParseConstraintMessage(ex.Message));
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private bool SaveIngredient()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Ingredients.Save(dtingredient);
                b = true;
                this.Tag = SQLUtility.GetValueFromFirstRowAsInt(dtingredient, "RecipeIngredientId");
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(SQLUtility.ParseConstraintMessage(ex.Message));
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }


        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pk = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pk > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            SaveRecipe();
        }

        private void BtnIngredientsSave_Click(object? sender, EventArgs e)
        {
            SaveIngredient();
        }


        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bs.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe) == true)
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = SaveRecipe();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
