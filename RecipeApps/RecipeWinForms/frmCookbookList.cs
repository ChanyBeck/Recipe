using RecipeSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            gridCookbook.CellDoubleClick += GridCookbook_CellDoubleClick;
            gridCookbook.KeyDown += GridCookbook_KeyDown;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            this.Activated += FrmCookbookList_Activated;
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            GetList();
        }

        public void GetList()
        {
            this.Show();
            gridCookbook.DataSource = Cookbook.GetList("CookBookListGet");
            WindowsFormsUtility.FormatGridForSearch(gridCookbook, "CookBook");
        }
        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gridCookbook, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }
        private void GridCookbook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gridCookbook.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gridCookbook.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GridCookbook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

    }
}
