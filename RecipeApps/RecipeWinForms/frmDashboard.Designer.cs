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
            tblLists = new TableLayoutPanel();
            btnMealList = new Button();
            btnCookbookList = new Button();
            btnRecipeList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDashboard).BeginInit();
            tblLists.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblMain.Controls.Add(lblTitle, 1, 0);
            tblMain.Controls.Add(lblDesc, 1, 1);
            tblMain.Controls.Add(gridDashboard, 1, 2);
            tblMain.Controls.Add(tblLists, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 2, 3, 2);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(831, 455);
            tblMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(187, 38);
            lblTitle.Margin = new Padding(3, 38, 3, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(455, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hearty Hearth Desktop App";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.Location = new Point(187, 76);
            lblDesc.Margin = new Padding(3, 0, 3, 15);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(453, 42);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Welcome to the Hearty Hearth Desktop App. In this app you can create recipes, cookbooks...";
            // 
            // gridDashboard
            // 
            gridDashboard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gridDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDashboard.Location = new Point(187, 135);
            gridDashboard.Margin = new Padding(3, 2, 3, 2);
            gridDashboard.Name = "gridDashboard";
            gridDashboard.RowHeadersWidth = 51;
            gridDashboard.RowTemplate.Height = 29;
            gridDashboard.Size = new Size(455, 146);
            gridDashboard.TabIndex = 2;
            // 
            // tblLists
            // 
            tblLists.ColumnCount = 3;
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblLists.Controls.Add(btnMealList, 1, 0);
            tblLists.Controls.Add(btnCookbookList, 2, 0);
            tblLists.Controls.Add(btnRecipeList, 0, 0);
            tblLists.Dock = DockStyle.Fill;
            tblLists.Location = new Point(187, 285);
            tblLists.Margin = new Padding(3, 2, 3, 2);
            tblLists.Name = "tblLists";
            tblLists.RowCount = 1;
            tblLists.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLists.Size = new Size(455, 168);
            tblLists.TabIndex = 3;
            // 
            // btnMealList
            // 
            btnMealList.AutoSize = true;
            btnMealList.Location = new Point(154, 2);
            btnMealList.Margin = new Padding(3, 2, 3, 2);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(145, 42);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "&Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.Location = new Point(305, 2);
            btnCookbookList.Margin = new Padding(3, 2, 3, 2);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(147, 42);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "&Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // btnRecipeList
            // 
            btnRecipeList.AutoSize = true;
            btnRecipeList.Location = new Point(3, 2);
            btnRecipeList.Margin = new Padding(3, 2, 3, 2);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(145, 42);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "&Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 455);
            Controls.Add(tblMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDashboard";
            Text = "frmDashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridDashboard).EndInit();
            tblLists.ResumeLayout(false);
            tblLists.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblTitle;
        private Label lblDesc;
        private DataGridView gridDashboard;
        private TableLayoutPanel tblLists;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}