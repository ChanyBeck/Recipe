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
        BindingSource bs = new();
        int cookbookid = 0;
        public frmCookbook()
        {
            InitializeComponent();
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
            WindowsFormsUtility.SetListBinding(lstUser, dtUsers, "Users", dtCookbook);
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bs);
            WindowsFormsUtility.SetControlBinding(txtPrice, bs);
            WindowsFormsUtility.SetControlBinding(lblDate, bs);

        }
    }
}
