namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Users, Cuisine, Ingredient, Measurement, Course};
        public frmDataMaintenance()
        {
            InitializeComponent();
            BindData(TableTypeEnum.Users);
            SetupRadioButtons();
        }

        private void BindData(TableTypeEnum tabletype)
        {
            DataTable dt = new();
            dt = DataMaintenance.GetList(tabletype.ToString());
            gData.DataSource = dt;
            WindowsFormsUtility.FormatGridForEdit(gData, tabletype.ToString());
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
    }
}
