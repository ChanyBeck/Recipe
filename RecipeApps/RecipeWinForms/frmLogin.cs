using RecipeWinForms.Properties;
using System.Configuration;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loggedin = false;
        public frmLogin()
        {
            InitializeComponent();
            btnOkay.Click += BtnOkay_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
            txtUsername.Text = Settings.Default.userid;
            this.ShowDialog();
            return loggedin;
        }

        private void BtnOkay_Click(object? sender, EventArgs e)
            try
            {
        {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";
#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUsername.Text, txtPassword.Text);
                loggedin = true;
                Settings.Default.userid = txtUsername.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Login", Application.ProductName);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
