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
    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe;
        BindingSource bs = new();
        int recipeid = new();
        enum RecipeStatus { Draft, Published, Archived };
        RecipeStatus currentstatus = RecipeStatus.Draft;

        public frmChangeStatus()
        {
            InitializeComponent();
        }

        public void LoadForm(int recipevalue)
        {
            recipeid = recipevalue;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bs.DataSource = Recipe.Load(recipeid);
            SetCurrentStatus(dtrecipe.Rows[0]["RecipeStatus"].ToString());
            lblCurrentStatus.Text = "Current Status: " + currentstatus;
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bs);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bs);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bs);
            lblRecipeName.Text = Recipe.GetRecipeDesc(dtrecipe);
            this.Text = "Recipe - Change Status";
            ButtonSetup();
        }

        public void SetCurrentStatus(string status)
        {
            foreach(Button btn in tblButtons.Controls)
            {
                btn.Enabled = true;
            }
            switch (status)
            {
                case "Draft":
                    currentstatus = RecipeStatus.Draft;
                    btnDraft.Enabled = false; 
                    break;
                case "Published":
                    currentstatus = RecipeStatus.Published;
                    btnPublish.Enabled = false;
                    break;
                case "Archived":
                    currentstatus = RecipeStatus.Archived;
                    btnArchive.Enabled = false; 
                    break;
            }
        }

        private void ButtonSetup()
        {
            foreach (Button btn in tblButtons.Controls)
            {
                btn.Click += Btn_Click;
            }
            btnDraft.Tag = RecipeStatus.Draft;
            btnPublish.Tag = RecipeStatus.Published;
            btnArchive.Tag = RecipeStatus.Archived;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to change the recipe status to " + ((Control)sender).Tag, Application.ProductName, MessageBoxButtons.YesNo);
            {
                switch (msg)
                {
                    case DialogResult.No:
                        return;
                        break;
                }
            }
            ChangeStatus.Save(recipeid, ((Control)sender).Tag.ToString());
            dtrecipe = Recipe.Load(recipeid);
            bs.DataSource = Recipe.Load(recipeid);
            SetCurrentStatus(dtrecipe.Rows[0]["RecipeStatus"].ToString());
            lblCurrentStatus.Text = "Current Status: " + currentstatus;
        }

    }
}
