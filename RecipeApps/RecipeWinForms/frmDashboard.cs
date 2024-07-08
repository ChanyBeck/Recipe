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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            ShowData();
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnRecipeList.Click += BtnRecipeList_Click;
        }

        private void ShowData()
        {
            DataTable dt = new();
            dt = DataMaintenance.GetList("Dashboard");
            gridDashboard.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearch(gridDashboard, "Dashboard");
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
        }

    }
}
