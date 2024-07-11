
using RecipeSystem;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        DataTable dtingredient;
        DataTable dtsteps;
        BindingSource bs = new();
        string delete = "deletecol";
        int recipeid = 0;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnIngredientsSave.Click += BtnIngredientsSave_Click;
            btnStepsSave.Click += BtnStepsSave_Click;
            gridIngredients.CellContentClick += GridIngredients_CellContentClick;
            gridSteps.CellContentClick += GridSteps_CellContentClick;
            foreach (Control c in tblMain.Controls)
            {
                c.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            }
            this.FormClosing += FrmRecipe_FormClosing;
        }


        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bs.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtUsers = Recipe.GetList("UsersGet");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, "Users", dtrecipe);
            DataTable dtCuisine = Recipe.GetList("CuisineGet");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, "Cuisine", dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, bs);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bs);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bs);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bs);
            //WindowsFormsUtility.SetControlBinding(lblPicture, bs);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bs);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bs);
            this.Text = GetRecipeDesc();

            LoadRecipeDirection();

            LoadRecipeIngredient();

            SetEnableButtons();
        }

        private void LoadRecipeIngredient()
        {
            dtingredient = Ingredients.Load(recipeid);
            gridIngredients.Columns.Clear();
            gridIngredients.DataSource = dtingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gridIngredients, Recipe.GetList("MeasurementGet"), "MeasurementType", "Measurement");
            WindowsFormsUtility.AddComboBoxToGrid(gridIngredients, Recipe.GetList("IngredientGet"), "ingredientName", "Ingredient");
            WindowsFormsUtility.FormatGridForEdit(gridIngredients, "RecipeIngredient");
            WindowsFormsUtility.AddDeleteButtonToGrid(gridIngredients, delete);
        }

        private void LoadRecipeDirection()
        {
            dtsteps = Direction.Load(recipeid);
            gridSteps.Columns.Clear();
            gridSteps.DataSource = dtsteps;
            WindowsFormsUtility.FormatGridForEdit(gridSteps, "RecipeDirection");
            WindowsFormsUtility.AddDeleteButtonToGrid(gridSteps, delete);
            WindowsFormsUtility.FormatGridForEdit(gridSteps, "RecipeDirection");
        }

        private bool SaveRecipe()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetEnableButtons();
                this.Text = GetRecipeDesc();
                bs.DataSource = dtrecipe;
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
        private void SaveIng()
        {
            try
            {
                Ingredients.Save(dtingredient, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveSteps()
        {
            try
            {
                Direction.Save(dtsteps, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteIng(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gridIngredients, rowIndex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    Ingredients.Delete(id);
                    LoadRecipeIngredient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gridIngredients.Rows.Count)
            {
                gridIngredients.Rows.RemoveAt(rowIndex);
            }
        }
        private void DeleteDirection(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gridSteps, rowIndex, "RecipeDirectionId");
            if (id > 0)
            {
                try
                {
                    Direction.Delete(id);
                    LoadRecipeDirection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gridSteps.Rows.Count)
            {
                gridSteps.Rows.RemoveAt(rowIndex);
            }
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

        private void SetEnableButtons()
        {
            bool b = recipeid == 0? false : true;
            btnDelete.Enabled = b;
            btnIngredientsSave.Enabled = b;
            btnStepsSave.Enabled = b;
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
            SaveIng();
        }

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {
            SaveSteps();
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

        private void GridIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteIng(e.RowIndex);
        }

        private void GridSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteDirection(e.RowIndex);
        }
    }
}
