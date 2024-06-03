﻿namespace RecipeWinForms
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
            lblCaptionUser = new Label();
            lblCaptionCuisine = new Label();
            lblCaptionRecipeName = new Label();
            lblCaptionPicture = new Label();
            lblCaptionCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            lblPicture = new Label();
            lblRecipeStatus = new Label();
            txtCalories = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lstUserName = new ComboBox();
            lstCuisineType = new ComboBox();
            txtRecipeName = new TextBox();
            lblDateDrafted = new Label();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            ttRecipe = new ToolTip(components);
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblCaptionUser, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 2);
            tblMain.Controls.Add(lblCaptionPicture, 0, 3);
            tblMain.Controls.Add(lblCaptionCalories, 0, 4);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 5);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 6);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 8);
            tblMain.Controls.Add(lblPicture, 1, 3);
            tblMain.Controls.Add(lblRecipeStatus, 1, 8);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 6);
            tblMain.Controls.Add(txtDateArchived, 1, 7);
            tblMain.Controls.Add(lstUserName, 1, 0);
            tblMain.Controls.Add(lstCuisineType, 1, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 2);
            tblMain.Controls.Add(lblDateDrafted, 1, 5);
            tblMain.Location = new Point(0, 32);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.Size = new Size(698, 396);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.Anchor = AnchorStyles.Left;
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(3, 9);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(42, 21);
            lblCaptionUser.TabIndex = 0;
            lblCaptionUser.Text = "&User";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(3, 49);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(61, 21);
            lblCaptionCuisine.TabIndex = 2;
            lblCaptionCuisine.Text = "&Cuisine";
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 89);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(102, 21);
            lblCaptionRecipeName.TabIndex = 4;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionPicture
            // 
            lblCaptionPicture.Anchor = AnchorStyles.Left;
            lblCaptionPicture.AutoSize = true;
            lblCaptionPicture.Location = new Point(3, 129);
            lblCaptionPicture.Name = "lblCaptionPicture";
            lblCaptionPicture.Size = new Size(58, 21);
            lblCaptionPicture.TabIndex = 6;
            lblCaptionPicture.Text = "Picture";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Location = new Point(3, 169);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(66, 21);
            lblCaptionCalories.TabIndex = 8;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(3, 209);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(98, 21);
            lblCaptionDateDrafted.TabIndex = 10;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(3, 249);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(114, 21);
            lblCaptionDatePublished.TabIndex = 12;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(3, 289);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(107, 21);
            lblCaptionDateArchived.TabIndex = 14;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(3, 327);
            lblCaptionRecipeStatus.Margin = new Padding(3, 7, 3, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(102, 21);
            lblCaptionRecipeStatus.TabIndex = 16;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.BackColor = SystemColors.ControlLight;
            lblPicture.Dock = DockStyle.Fill;
            lblPicture.Location = new Point(123, 120);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(572, 40);
            lblPicture.TabIndex = 7;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.ControlLight;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(123, 320);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(572, 76);
            lblRecipeStatus.TabIndex = 17;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(123, 163);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(572, 29);
            txtCalories.TabIndex = 9;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(123, 243);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(572, 29);
            txtDatePublished.TabIndex = 13;
            ttRecipe.SetToolTip(txtDatePublished, "Enter a Date yyyy-mm-dd");
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(123, 283);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(572, 29);
            txtDateArchived.TabIndex = 15;
            ttRecipe.SetToolTip(txtDateArchived, "Enter a Date yyyy-mm-dd");
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(123, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(196, 29);
            lstUserName.TabIndex = 1;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(123, 43);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(196, 29);
            lstCuisineType.TabIndex = 3;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(123, 83);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(572, 29);
            txtRecipeName.TabIndex = 5;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = SystemColors.ControlLight;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(123, 200);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(572, 40);
            lblDateDrafted.TabIndex = 11;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(698, 28);
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
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 428);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
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
        private Label lblCaptionPicture;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private Label lblPicture;
        private Label lblRecipeStatus;
        private TextBox txtCalories;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
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
    }
}