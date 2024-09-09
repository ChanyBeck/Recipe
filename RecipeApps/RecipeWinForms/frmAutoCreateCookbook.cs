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
    public partial class frmAutoCreateCookbook : Form
    {
        DataTable dtcookbook = new();
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            GetUsersList();
            btnCreate.Click += BtnCreate_Click;
        }

        private void GetUsersList()
        {
            WindowsFormsUtility.SetListBinding(lstUserName, DataMaintenance.GetList("Users"), "Users", null);
        }
        private void CreateCookbook()
        {
            int cookbookid = new();
            int usersid = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
            Cursor = Cursors.WaitCursor;
            try
            {
                dtcookbook = Cookbook.AutoCreateCookbook(usersid);
                cookbookid = (int)dtcookbook.Rows[0]["cookbookid"];
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), cookbookid);
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

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }
    }
}
