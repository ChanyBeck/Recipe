namespace RecipeWinForms
{
    partial class frmDashboard
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
            lblTitle = new Label();
            lblDesc = new Label();
            gridDashboard = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDashboard).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblTitle, 0, 0);
            tblMain.Controls.Add(lblDesc, 0, 1);
            tblMain.Controls.Add(gridDashboard, 0, 2);
            tblMain.Controls.Add(tableLayoutPanel1, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 2, 3, 2);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(700, 338);
            tblMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 38);
            lblTitle.Margin = new Padding(3, 38, 3, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(694, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hearty Hearth Desktop App";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.Location = new Point(3, 76);
            lblDesc.Margin = new Padding(3, 0, 3, 15);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(639, 21);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Welcome to the Hearty Hearth Desktop App. In this app you can create recipes, cookbooks...";
            // 
            // gridDashboard
            // 
            gridDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDashboard.Dock = DockStyle.Fill;
            gridDashboard.Location = new Point(3, 114);
            gridDashboard.Margin = new Padding(3, 2, 3, 2);
            gridDashboard.Name = "gridDashboard";
            gridDashboard.RowHeadersWidth = 51;
            gridDashboard.RowTemplate.Height = 29;
            gridDashboard.Size = new Size(694, 146);
            gridDashboard.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnRecipeList, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMealList, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCookbookList, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 264);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.Size = new Size(694, 94);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.AutoSize = true;
            btnRecipeList.Location = new Point(3, 2);
            btnRecipeList.Margin = new Padding(3, 2, 3, 2);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(225, 89);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.AutoSize = true;
            btnMealList.Location = new Point(234, 2);
            btnMealList.Margin = new Padding(3, 2, 3, 2);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(225, 89);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "&Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.Location = new Point(465, 2);
            btnCookbookList.Margin = new Padding(3, 2, 3, 2);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(226, 89);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "&Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tblMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDashboard";
            Text = "frmDashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridDashboard).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblTitle;
        private Label lblDesc;
        private DataGridView gridDashboard;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}