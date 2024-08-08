namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            lblRecipeName = new Label();
            lblCurrentStatus = new Label();
            tblDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCurrentStatus, 0, 1);
            tblMain.Controls.Add(tblDates, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Margin = new Padding(3, 0, 3, 10);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(794, 30);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(3, 40);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(794, 25);
            lblCurrentStatus.TabIndex = 1;
            lblCurrentStatus.Text = "Current Status:";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 4;
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.Controls.Add(lblStatusDates, 0, 1);
            tblDates.Controls.Add(lblDrafted, 1, 0);
            tblDates.Controls.Add(lblPublished, 2, 0);
            tblDates.Controls.Add(lblArchived, 3, 0);
            tblDates.Controls.Add(lblDateDrafted, 1, 1);
            tblDates.Controls.Add(lblDatePublished, 2, 1);
            tblDates.Controls.Add(lblDateArchived, 3, 1);
            tblDates.Location = new Point(3, 68);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.Size = new Size(794, 106);
            tblDates.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(55, 53);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(87, 53);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "StatusDates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(201, 33);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(60, 20);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(399, 33);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(73, 20);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(597, 33);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(67, 20);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Location = new Point(201, 53);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(100, 23);
            lblDateDrafted.TabIndex = 4;
            // 
            // lblDatePublished
            // 
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Location = new Point(399, 53);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(100, 23);
            lblDatePublished.TabIndex = 5;
            // 
            // lblDateArchived
            // 
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Location = new Point(597, 53);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(100, 23);
            lblDateArchived.TabIndex = 6;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 180);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(794, 292);
            tblButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.Top;
            btnDraft.AutoSize = true;
            btnDraft.Location = new Point(94, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(75, 30);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Top;
            btnPublish.AutoSize = true;
            btnPublish.Location = new Point(358, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(75, 30);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.Top;
            btnArchive.AutoSize = true;
            btnArchive.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnArchive.Location = new Point(623, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(75, 30);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmChangeStatus";
            Text = "frmChangeStatus";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblDates;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}