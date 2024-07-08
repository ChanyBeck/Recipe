namespace RecipeWinForms
{
    partial class frmMealList
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
            gridMealList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridMealList).BeginInit();
            SuspendLayout();
            // 
            // gridMealList
            // 
            gridMealList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMealList.Dock = DockStyle.Fill;
            gridMealList.Location = new Point(0, 0);
            gridMealList.Name = "gridMealList";
            gridMealList.RowTemplate.Height = 25;
            gridMealList.Size = new Size(800, 450);
            gridMealList.TabIndex = 0;
            // 
            // frmMealList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridMealList);
            Name = "frmMealList";
            Text = "Meal List";
            ((System.ComponentModel.ISupportInitialize)gridMealList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridMealList;
    }
}