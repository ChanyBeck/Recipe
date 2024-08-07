namespace RecipeWinForms
{
    partial class frmCookbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            lblUser = new Label();
            lblActive = new Label();
            tblPrice = new TableLayoutPanel();
            lblPrice = new Label();
            lblDateCreated = new Label();
            lblBookCreated = new Label();
            txtPrice = new TextBox();
            txtTitle = new TextBox();
            lstUserName = new ComboBox();
            checkActive = new CheckBox();
            tblRecipe = new TableLayoutPanel();
            btnSaveRecipe = new Button();
            gridRecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblPrice.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblActive, 0, 4);
            tblMain.Controls.Add(tblPrice, 0, 3);
            tblMain.Controls.Add(txtTitle, 1, 1);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(checkActive, 1, 4);
            tblMain.Controls.Add(tblRecipe, 0, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1040, 587);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(106, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(3, 36);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(97, 15);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 65);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(30, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 146);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(40, 15);
            lblActive.TabIndex = 5;
            lblActive.Text = "Active";
            // 
            // tblPrice
            // 
            tblPrice.ColumnCount = 3;
            tblMain.SetColumnSpan(tblPrice, 2);
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblPrice.ColumnStyles.Add(new ColumnStyle());
            tblPrice.ColumnStyles.Add(new ColumnStyle());
            tblPrice.Controls.Add(lblPrice, 0, 1);
            tblPrice.Controls.Add(lblDateCreated, 2, 0);
            tblPrice.Controls.Add(lblBookCreated, 2, 1);
            tblPrice.Controls.Add(txtPrice, 1, 1);
            tblPrice.Dock = DockStyle.Fill;
            tblPrice.Location = new Point(3, 97);
            tblPrice.Name = "tblPrice";
            tblPrice.RowCount = 2;
            tblPrice.RowStyles.Add(new RowStyle());
            tblPrice.RowStyles.Add(new RowStyle());
            tblPrice.Size = new Size(1034, 46);
            tblPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 15);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(209, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(78, 15);
            lblDateCreated.TabIndex = 1;
            lblDateCreated.Text = "Date Created:";
            // 
            // lblBookCreated
            // 
            lblBookCreated.BackColor = SystemColors.ControlDark;
            lblBookCreated.ForeColor = SystemColors.ControlText;
            lblBookCreated.Location = new Point(209, 15);
            lblBookCreated.Name = "lblBookCreated";
            lblBookCreated.Size = new Size(159, 23);
            lblBookCreated.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(103, 18);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Location = new Point(106, 39);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(931, 23);
            txtTitle.TabIndex = 8;
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(106, 68);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(931, 23);
            lstUserName.TabIndex = 9;
            // 
            // checkActive
            // 
            checkActive.AutoSize = true;
            checkActive.Location = new Point(106, 149);
            checkActive.Name = "checkActive";
            checkActive.Size = new Size(15, 14);
            checkActive.TabIndex = 10;
            checkActive.UseVisualStyleBackColor = true;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblMain.SetColumnSpan(tblRecipe, 2);
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipe.Controls.Add(btnSaveRecipe, 0, 0);
            tblRecipe.Controls.Add(gridRecipe, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 169);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle());
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblRecipe.Size = new Size(1034, 460);
            tblRecipe.TabIndex = 11;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.Location = new Point(3, 3);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(75, 30);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // gridRecipe
            // 
            gridRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRecipe.Dock = DockStyle.Fill;
            gridRecipe.Location = new Point(3, 39);
            gridRecipe.Name = "gridRecipe";
            gridRecipe.RowHeadersWidth = 51;
            gridRecipe.RowTemplate.Height = 25;
            gridRecipe.Size = new Size(1028, 418);
            gridRecipe.TabIndex = 1;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 587);
            Controls.Add(tblMain);
            Name = "frmCookbook";
            Text = "frmCookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblPrice.ResumeLayout(false);
            tblPrice.PerformLayout();
            tblRecipe.ResumeLayout(false);
            tblRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblCuisine;
        private Label lblActive;
        private TableLayoutPanel tblPrice;
        private Label lblPrice;
        private Label lblDateCreated;
        private Label lblBookCreated;
        private TextBox txtPrice;
        private TextBox txtTitle;
        private ComboBox lstUserName;
        private CheckBox checkActive;
        private TableLayoutPanel tblRecipe;
        private Button btnSaveRecipe;
        private DataGridView gridRecipe;
    }
}