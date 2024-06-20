namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            pnlRadioButtons = new FlowLayoutPanel();
            radioUsers = new RadioButton();
            radioCuisines = new RadioButton();
            radioIngredients = new RadioButton();
            radioMeasurements = new RadioButton();
            radioCourses = new RadioButton();
            tblDataGrid = new TableLayoutPanel();
            gData = new DataGridView();
            btnSave = new Button();
            tblMain.SuspendLayout();
            pnlRadioButtons.SuspendLayout();
            tblDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tblMain.Controls.Add(pnlRadioButtons, 0, 0);
            tblMain.Controls.Add(tblDataGrid, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 0;
            // 
            // pnlRadioButtons
            // 
            pnlRadioButtons.Controls.Add(radioUsers);
            pnlRadioButtons.Controls.Add(radioCuisines);
            pnlRadioButtons.Controls.Add(radioIngredients);
            pnlRadioButtons.Controls.Add(radioMeasurements);
            pnlRadioButtons.Controls.Add(radioCourses);
            pnlRadioButtons.Dock = DockStyle.Fill;
            pnlRadioButtons.FlowDirection = FlowDirection.TopDown;
            pnlRadioButtons.Location = new Point(4, 4);
            pnlRadioButtons.Margin = new Padding(4);
            pnlRadioButtons.Name = "pnlRadioButtons";
            pnlRadioButtons.Size = new Size(197, 622);
            pnlRadioButtons.TabIndex = 0;
            // 
            // radioUsers
            // 
            radioUsers.AutoSize = true;
            radioUsers.Checked = true;
            radioUsers.Location = new Point(4, 4);
            radioUsers.Margin = new Padding(4);
            radioUsers.Name = "radioUsers";
            radioUsers.Size = new Size(67, 25);
            radioUsers.TabIndex = 0;
            radioUsers.TabStop = true;
            radioUsers.Text = "Users";
            radioUsers.UseVisualStyleBackColor = true;
            // 
            // radioCuisines
            // 
            radioCuisines.AutoSize = true;
            radioCuisines.Location = new Point(4, 37);
            radioCuisines.Margin = new Padding(4);
            radioCuisines.Name = "radioCuisines";
            radioCuisines.Size = new Size(86, 25);
            radioCuisines.TabIndex = 1;
            radioCuisines.Text = "Cuisines";
            radioCuisines.UseVisualStyleBackColor = true;
            // 
            // radioIngredients
            // 
            radioIngredients.AutoSize = true;
            radioIngredients.Location = new Point(4, 70);
            radioIngredients.Margin = new Padding(4);
            radioIngredients.Name = "radioIngredients";
            radioIngredients.Size = new Size(106, 25);
            radioIngredients.TabIndex = 2;
            radioIngredients.Text = "Ingredients";
            radioIngredients.UseVisualStyleBackColor = true;
            // 
            // radioMeasurements
            // 
            radioMeasurements.AutoSize = true;
            radioMeasurements.Location = new Point(4, 103);
            radioMeasurements.Margin = new Padding(4);
            radioMeasurements.Name = "radioMeasurements";
            radioMeasurements.Size = new Size(131, 25);
            radioMeasurements.TabIndex = 3;
            radioMeasurements.Text = "Measurements";
            radioMeasurements.UseVisualStyleBackColor = true;
            // 
            // radioCourses
            // 
            radioCourses.AutoSize = true;
            radioCourses.Location = new Point(4, 136);
            radioCourses.Margin = new Padding(4);
            radioCourses.Name = "radioCourses";
            radioCourses.Size = new Size(84, 25);
            radioCourses.TabIndex = 4;
            radioCourses.Text = "Courses";
            radioCourses.UseVisualStyleBackColor = true;
            // 
            // tblDataGrid
            // 
            tblDataGrid.ColumnCount = 1;
            tblDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDataGrid.Controls.Add(gData, 0, 0);
            tblDataGrid.Controls.Add(btnSave, 0, 1);
            tblDataGrid.Dock = DockStyle.Fill;
            tblDataGrid.Location = new Point(208, 3);
            tblDataGrid.Name = "tblDataGrid";
            tblDataGrid.RowCount = 2;
            tblDataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 86.05769F));
            tblDataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9423075F));
            tblDataGrid.Size = new Size(818, 624);
            tblDataGrid.TabIndex = 1;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(3, 3);
            gData.Name = "gData";
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(812, 531);
            gData.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(677, 574);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 47);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            pnlRadioButtons.ResumeLayout(false);
            pnlRadioButtons.PerformLayout();
            tblDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlRadioButtons;
        private RadioButton radioUsers;
        private RadioButton radioCuisines;
        private RadioButton radioIngredients;
        private RadioButton radioMeasurements;
        private RadioButton radioCourses;
        private DataGridView gData;
        private TableLayoutPanel tblDataGrid;
        private Button btnSave;
    }
}