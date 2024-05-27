using CPUFramework;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;


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
        }

        public void ShowForm(int recipeid)
        {
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
            this.Show();
        }


        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
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

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you wan to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
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
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
