using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CPUFramework;

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
            string sql = "select r.*, c.CuisineType, u.UserName from Recipe r join Cuisine c on c.CuisineId = r.CuisineId join Users u on u.UsersId = r.UsersId where r.RecipeId =" + recipeid;
            dtrecipe = SQLUtility.GetDataTable(sql);
            DataTable dtUsers = SQLUtility.GetDataTable("select UsersId, UserName from Users");
            SetListBinding(lstUserName, dtUsers, "Users");
            DataTable dtCuisine = SQLUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
            SetListBinding(lstCuisineType, dtCuisine, "Cuisine");
            SetControlBinding(txtCalories, dtrecipe);
            SetControlBinding(txtDateArchived, dtrecipe);
            SetControlBinding(txtDateDrafted, dtrecipe);
            SetControlBinding(txtDatePublished, dtrecipe);
            SetControlBinding(lblPicture, dtrecipe);
            SetControlBinding(lblRecipeName, dtrecipe);
            SetControlBinding(lblRecipeStatus, dtrecipe);
            this.Show();
        }
        public void SetListBinding(ComboBox lst, DataTable dt, string tablename)
        {
            lst.DataSource = dt;
            lst.ValueMember = tablename + "Id";
            lst.DisplayMember = lst.Name.Substring(3);
            lst.DataBindings.Add("SelectedValue", dt, lst.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }
        public void SetControlBinding(Control c, DataTable dt)
        {
            string property = "";
            string column = "";
            string controlname = c.Name.ToLower();
            if (controlname.StartsWith("txt") || controlname.StartsWith("lbl"))
            {
                column = controlname.Substring(3);
                property = "Text";
            }

            if (property != "" && column != "")
            {
                c.DataBindings.Add(property, dt, column, true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void Save()
        {
            SQLUtility.DebugPringDataTable(dtrecipe);
            DataRow dr = dtrecipe.Rows[0];
            string sql = string.Join(Environment.NewLine, $"update recipe set",
                $"Calories = {dr["Calories"]},",
                $"CuisineId = '{dr["CuisineId"]}',",
                //$"DateArchived = '{dr["DateArchived"]}',",
                $"DateDrafted = '{dr["DateDrafted"]}',",
                $"DatePublished = '{dr["DatePublished"]}',",
                $"UsersId = '{dr["UsersId"]}'",
                $"where recipeid = {dr["RecipeId"]}");
            Debug.Print(sql);
            SQLUtility.GetDataTable(sql);
        }

        private void Delete()
        {

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
