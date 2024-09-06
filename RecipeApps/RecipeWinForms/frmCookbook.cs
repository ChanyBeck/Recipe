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
    public partial class frmCookbook : Form
    {
        DataTable dtCookbook;
        DataTable dtrecipe;
        BindingSource bs = new();
        int cookbookid = 0;
        string delete = "deletecol";
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            btnDelete.Click += BtnDelete_Click;
            gridRecipe.CellContentClick += GridRecipe_CellContentClick;
            this.Shown += FrmCookbook_Shown;
            this.FormClosing += FrmCookbook_FormClosing;
        }


        public void LoadForm(int id)
        {
            cookbookid = id;
            this.Tag = id;
            dtCookbook = Cookbook.Load(id);
            bs.DataSource = dtCookbook;
            if (id == 0)
            {
                dtCookbook.Rows.Add();
            }
            DataTable dtUsers = Cookbook.GetList("UsersGet");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, "Users", dtCookbook);
            WindowsFormsUtility.SetControlBinding(txtTitle, bs);
            WindowsFormsUtility.SetControlBinding(txtPrice, bs);
            WindowsFormsUtility.SetControlBinding(lblBookCreated, bs);

            checkActive.DataBindings.Add("checked", dtCookbook, "IsActive", false, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
            //checkActive.CheckState = 0;
            LoadRecipe(cookbookid);
            this.Text = Cookbook.GetCookbookDesc(dtCookbook);
        }

        private void LoadRecipe(int cookbookid)
        {
            dtrecipe = Cookbook.LoadRecipe(cookbookid);
            gridRecipe.Columns.Clear();
            gridRecipe.DataSource = dtrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gridRecipe, Recipe.GetList("RecipeGet"), "RecipeName", "Recipe");
            WindowsFormsUtility.FormatGridForEdit(gridRecipe, "Recipe");
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtCookbook);
                b = true;
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
                this.Tag = cookbookid;
                SetEnableButtons();
                //this.Text = GetRecipeDesc();
                dtCookbook = Cookbook.Load(cookbookid);
                bs.DataSource = dtCookbook;
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
        private void SaveRecipe()
        {
            try
            {
                Cookbook.SaveRecipe(dtrecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteRecipe(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gridRecipe, rowIndex, "BookRecipeId");
            if (id > 0)
            {
                try
                {
                    Cookbook.DeleteRecipe(id);
                    LoadRecipe(cookbookid);
                    WindowsFormsUtility.AddDeleteButtonToGrid(gridRecipe, delete);
                    WindowsFormsUtility.FormatGridForEdit(gridRecipe, "Recipe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gridRecipe.Rows.Count)
            {
                gridRecipe.Rows.RemoveAt(rowIndex);
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtCookbook);
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
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSave.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveRecipe();
        }
        private void GridRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipe(e.RowIndex);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void FrmCookbook_Shown(object? sender, EventArgs e)
        {
            WindowsFormsUtility.AddDeleteButtonToGrid(gridRecipe, delete);
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bs.EndEdit();
            if (SQLUtility.TableHasChanges(dtCookbook) == true)
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
