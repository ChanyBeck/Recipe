
namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        BindingSource bs = new();
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
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
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bs);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bs);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bs);
            WindowsFormsUtility.SetControlBinding(lblPicture, bs);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bs);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bs);
            this.Text = GetRecipeDesc();
            this.Show();
        }

        private bool Save()
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
            Save();
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
                        bool b = Save();
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
