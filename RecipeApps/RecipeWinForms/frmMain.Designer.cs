namespace RecipeWinForms
{
    partial class frmMain
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
            menuMain = new MenuStrip();
            menuRecipe = new ToolStripMenuItem();
            menuSearch = new ToolStripMenuItem();
            menuNewRecipe = new ToolStripMenuItem();
            menuCascade = new ToolStripMenuItem();
            menuTile = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            menuDataMaintenance = new ToolStripMenuItem();
            menuData = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuMain.Items.AddRange(new ToolStripItem[] { menuRecipe, menuCascade, menuDataMaintenance });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1029, 29);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // menuRecipe
            // 
            menuRecipe.DropDownItems.AddRange(new ToolStripItem[] { menuSearch, menuNewRecipe });
            menuRecipe.Name = "menuRecipe";
            menuRecipe.Size = new Size(68, 25);
            menuRecipe.Text = "&Recipe";
            // 
            // menuSearch
            // 
            menuSearch.Name = "menuSearch";
            menuSearch.Size = new Size(162, 26);
            menuSearch.Text = "&Search";
            // 
            // menuNewRecipe
            // 
            menuNewRecipe.Name = "menuNewRecipe";
            menuNewRecipe.Size = new Size(162, 26);
            menuNewRecipe.Text = "&New Recipe";
            // 
            // menuCascade
            // 
            menuCascade.DropDownItems.AddRange(new ToolStripItem[] { menuTile, cascadeToolStripMenuItem });
            menuCascade.Name = "menuCascade";
            menuCascade.Size = new Size(80, 25);
            menuCascade.Text = "&Window";
            // 
            // menuTile
            // 
            menuTile.Name = "menuTile";
            menuTile.Size = new Size(137, 26);
            menuTile.Text = "Tile";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(137, 26);
            cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // menuDataMaintenance
            // 
            menuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { menuData });
            menuDataMaintenance.Name = "menuDataMaintenance";
            menuDataMaintenance.Size = new Size(147, 25);
            menuDataMaintenance.Text = "&Data Maintenance";
            // 
            // menuData
            // 
            menuData.Name = "menuData";
            menuData.Size = new Size(180, 26);
            menuData.Text = "&Data";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1029, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tsMain);
            Controls.Add(menuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Hearty Hearth";
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem menuRecipe;
        private ToolStripMenuItem menuSearch;
        private ToolStripMenuItem menuNewRecipe;
        private ToolStripMenuItem menuCascade;
        private ToolStripMenuItem menuTile;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStrip tsMain;
        private ToolStripMenuItem menuDataMaintenance;
        private ToolStripMenuItem menuData;
    }
}