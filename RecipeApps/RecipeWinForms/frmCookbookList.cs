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
        }

        public void ShowList()
        {
            this.Show();
            gridCookbook.DataSource = Cookbook.GetList("CookBookList");
            WindowsFormsUtility.FormatGridForSearch(gridCookbook, "CookBook");
        }
    }
}
