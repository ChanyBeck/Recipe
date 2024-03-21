using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CPUWindowsFormsFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
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
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtUsers = Recipe.GetList("Users", "UserName");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, "Users", dtrecipe);
            DataTable dtCuisine = Recipe.GetList("Cuisine", "CuisineType");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, "Cuisine", dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblPicture, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtrecipe);
            this.Show();
        }


        private void Save()
        {
            Recipe.Save(dtrecipe);
        }

        private void Delete()
        {
            Recipe.Delete(dtrecipe);
            this.Close();
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
