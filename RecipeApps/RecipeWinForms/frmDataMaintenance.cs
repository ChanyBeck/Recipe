using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Users, Cuisine, Ingredient, Measurement, Course};
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Ingredient;
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            BindData(currenttabletype);
            SetupRadioButtons();
        }


        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetList(currenttabletype.ToString());
            gData.DataSource = dtlist;
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void SetupRadioButtons()
        {
            foreach(Control c in pnlRadioButtons.Controls)
            {
                if(c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            radioCourses.Tag = TableTypeEnum.Course;
            radioCuisines.Tag = TableTypeEnum.Cuisine;
            radioIngredients.Tag = TableTypeEnum.Ingredient;
            radioMeasurements.Tag = TableTypeEnum.Measurement;
            radioUsers.Tag = TableTypeEnum.Users;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if(sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist) == true)
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
