namespace RecipeWinForms
{
    partial class frmRecipe
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            tabData = new TabControl();
            tabIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            gridIngredients = new DataGridView();
            btnIngredientsSave = new Button();
            tabSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            gridSteps = new DataGridView();
            btnStepsSave = new Button();
            lblCaptionUser = new Label();
            lblCaptionCuisine = new Label();
            lstUserName = new ComboBox();
            lstCuisineType = new ComboBox();
            lblCaptionRecipeName = new Label();
            txtRecipeName = new TextBox();
            lblCaptionCalories = new Label();
            txtCalories = new TextBox();
            lblCaptionRecipeStatus = new Label();
            lblRecipeStatus = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblStatus = new Label();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnChangeStatus = new ToolStripButton();
            ttRecipe = new ToolTip(components);
            tblMain.SuspendLayout();
            tabData.SuspendLayout();
            tabIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridIngredients).BeginInit();
            tabSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSteps).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tabData, 0, 6);
            tblMain.Controls.Add(lblCaptionUser, 0, 1);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lstCuisineType, 1, 2);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 4);
            tblMain.Controls.Add(lblRecipeStatus, 1, 4);
            tblMain.Controls.Add(tableLayoutPanel1, 1, 5);
            tblMain.Controls.Add(lblStatus, 0, 5);
            tblMain.Location = new Point(0, 31);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.3573885F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.419244F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.793815F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.591065F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3402061F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 55.4982834F));
            tblMain.Size = new Size(940, 622);
            tblMain.TabIndex = 0;
            // 
            // tabData
            // 
            tblMain.SetColumnSpan(tabData, 2);
            tabData.Controls.Add(tabIngredients);
            tabData.Controls.Add(tabSteps);
            tabData.Dock = DockStyle.Fill;
            tabData.Location = new Point(3, 297);
            tabData.Name = "tabData";
            tabData.SelectedIndex = 0;
            tabData.Size = new Size(934, 322);
            tabData.TabIndex = 20;
            // 
            // tabIngredients
            // 
            tabIngredients.Controls.Add(tblIngredients);
            tabIngredients.Location = new Point(4, 30);
            tabIngredients.Name = "tabIngredients";
            tabIngredients.Padding = new Padding(3);
            tabIngredients.Size = new Size(926, 288);
            tabIngredients.TabIndex = 0;
            tabIngredients.Text = "Ingredients";
            tabIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblIngredients.Controls.Add(gridIngredients, 0, 1);
            tblIngredients.Controls.Add(btnIngredientsSave, 0, 0);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblIngredients.Size = new Size(920, 282);
            tblIngredients.TabIndex = 2;
            // 
            // gridIngredients
            // 
            gridIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridIngredients.Dock = DockStyle.Fill;
            gridIngredients.Location = new Point(3, 40);
            gridIngredients.Name = "gridIngredients";
            gridIngredients.RowTemplate.Height = 25;
            gridIngredients.Size = new Size(914, 239);
            gridIngredients.TabIndex = 0;
            // 
            // btnIngredientsSave
            // 
            btnIngredientsSave.AutoSize = true;
            btnIngredientsSave.Location = new Point(3, 3);
            btnIngredientsSave.Name = "btnIngredientsSave";
            btnIngredientsSave.Size = new Size(75, 31);
            btnIngredientsSave.TabIndex = 1;
            btnIngredientsSave.Text = "Save";
            btnIngredientsSave.UseVisualStyleBackColor = true;
            // 
            // tabSteps
            // 
            tabSteps.Controls.Add(tblSteps);
            tabSteps.Location = new Point(4, 30);
            tabSteps.Name = "tabSteps";
            tabSteps.Padding = new Padding(3);
            tabSteps.Size = new Size(926, 288);
            tabSteps.TabIndex = 1;
            tabSteps.Text = "Steps";
            tabSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(gridSteps, 0, 1);
            tblSteps.Controls.Add(btnStepsSave, 0, 0);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSteps.Size = new Size(920, 282);
            tblSteps.TabIndex = 1;
            // 
            // gridSteps
            // 
            gridSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSteps.Dock = DockStyle.Fill;
            gridSteps.Location = new Point(3, 40);
            gridSteps.Name = "gridSteps";
            gridSteps.RowTemplate.Height = 25;
            gridSteps.Size = new Size(914, 239);
            gridSteps.TabIndex = 0;
            // 
            // btnStepsSave
            // 
            btnStepsSave.AutoSize = true;
            btnStepsSave.Location = new Point(3, 3);
            btnStepsSave.Name = "btnStepsSave";
            btnStepsSave.Size = new Size(75, 31);
            btnStepsSave.TabIndex = 2;
            btnStepsSave.Text = "Save";
            btnStepsSave.UseVisualStyleBackColor = true;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.Anchor = AnchorStyles.Left;
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(3, 43);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(42, 21);
            lblCaptionUser.TabIndex = 0;
            lblCaptionUser.Text = "&User";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(3, 86);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(61, 21);
            lblCaptionCuisine.TabIndex = 2;
            lblCaptionCuisine.Text = "&Cuisine";
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(111, 38);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(196, 29);
            lstUserName.TabIndex = 1;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(111, 75);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(196, 29);
            lstCuisineType.TabIndex = 3;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 7);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(102, 21);
            lblCaptionRecipeName.TabIndex = 4;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(111, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(826, 29);
            txtRecipeName.TabIndex = 5;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Location = new Point(3, 139);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(66, 21);
            lblCaptionCalories.TabIndex = 8;
            lblCaptionCalories.Text = "Calories";
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(111, 124);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(572, 29);
            txtCalories.TabIndex = 9;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(3, 185);
            lblCaptionRecipeStatus.Margin = new Padding(3, 7, 3, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(102, 21);
            lblCaptionRecipeStatus.TabIndex = 16;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.ControlLight;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(111, 178);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(826, 50);
            lblRecipeStatus.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lblCaptionDateDrafted, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCaptionDatePublished, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCaptionDateArchived, 2, 0);
            tableLayoutPanel1.Controls.Add(lblDateDrafted, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDatePublished, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDateArchived, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(111, 231);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(826, 60);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(3, 1);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(62, 21);
            lblCaptionDateDrafted.TabIndex = 10;
            lblCaptionDateDrafted.Text = "Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(278, 1);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(78, 21);
            lblCaptionDatePublished.TabIndex = 12;
            lblCaptionDatePublished.Text = "Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(553, 1);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(71, 21);
            lblCaptionDateArchived.TabIndex = 14;
            lblCaptionDateArchived.Text = "Archived";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = SystemColors.ControlLight;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(3, 24);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(269, 36);
            lblDateDrafted.TabIndex = 11;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = SystemColors.ControlLight;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(278, 24);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(269, 36);
            lblDatePublished.TabIndex = 15;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = SystemColors.ControlLight;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(553, 24);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(270, 36);
            lblDateArchived.TabIndex = 16;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 228);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(95, 21);
            lblStatus.TabIndex = 19;
            lblStatus.Text = "Status Dates";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2, btnChangeStatus });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(940, 28);
            tsMain.TabIndex = 1;
            tsMain.TabStop = true;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 25);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 25);
            btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.Image = (Image)resources.GetObject("btnChangeStatus.Image");
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(113, 25);
            btnChangeStatus.Text = "Change Status";
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 653);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tabData.ResumeLayout(false);
            tabIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridIngredients).EndInit();
            tabSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridSteps).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private Label lblRecipeStatus;
        private TextBox txtCalories;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private TextBox txtRecipeName;
        private Label lblDateDrafted;
        private ToolTip ttRecipe;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblStatus;
        private TabControl tabData;
        private TabPage tabIngredients;
        private TableLayoutPanel tblIngredients;
        private DataGridView gridIngredients;
        private Button btnIngredientsSave;
        private TabPage tabSteps;
        private TableLayoutPanel tblSteps;
        private Button btnStepsSave;
        private DataGridView gridSteps;
        private ToolStripButton btnChangeStatus;
        private Label lblDatePublished;
        private Label lblDateArchived;
    }
}