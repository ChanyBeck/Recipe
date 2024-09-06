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
            menuFile = new ToolStripMenuItem();
            menuDashboard = new ToolStripMenuItem();
            menuRecipe = new ToolStripMenuItem();
            menuSearch = new ToolStripMenuItem();
            menuNewRecipe = new ToolStripMenuItem();
            menuRecipesList = new ToolStripMenuItem();
            menuCloneARecipe = new ToolStripMenuItem();
            menuMeals = new ToolStripMenuItem();
            menuMealsList = new ToolStripMenuItem();
            menuCookbooks = new ToolStripMenuItem();
            menuCookbooksList = new ToolStripMenuItem();
            menuNewCookbook = new ToolStripMenuItem();
            menuAutoCreate = new ToolStripMenuItem();
            menuDataMaintenance = new ToolStripMenuItem();
            menuData = new ToolStripMenuItem();
            menuCascade = new ToolStripMenuItem();
            menuTile = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuRecipe, menuMeals, menuCookbooks, menuDataMaintenance, menuCascade });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1029, 29);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuDashboard });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 25);
            menuFile.Text = "&File";
            // 
            // menuDashboard
            // 
            menuDashboard.Name = "menuDashboard";
            menuDashboard.Size = new Size(156, 26);
            menuDashboard.Text = "Dashboard";
            // 
            // menuRecipe
            // 
            menuRecipe.DropDownItems.AddRange(new ToolStripItem[] { menuSearch, menuNewRecipe, menuRecipesList, menuCloneARecipe });
            menuRecipe.Name = "menuRecipe";
            menuRecipe.Size = new Size(75, 25);
            menuRecipe.Text = "&Recipes";
            // 
            // menuSearch
            // 
            menuSearch.Name = "menuSearch";
            menuSearch.Size = new Size(182, 26);
            menuSearch.Text = "&Search";
            // 
            // menuNewRecipe
            // 
            menuNewRecipe.Name = "menuNewRecipe";
            menuNewRecipe.Size = new Size(182, 26);
            menuNewRecipe.Text = "&New Recipe";
            // 
            // menuRecipesList
            // 
            menuRecipesList.Name = "menuRecipesList";
            menuRecipesList.Size = new Size(182, 26);
            menuRecipesList.Text = "List";
            // 
            // menuCloneARecipe
            // 
            menuCloneARecipe.Name = "menuCloneARecipe";
            menuCloneARecipe.Size = new Size(182, 26);
            menuCloneARecipe.Text = "Clone a Recipe";
            // 
            // menuMeals
            // 
            menuMeals.DropDownItems.AddRange(new ToolStripItem[] { menuMealsList });
            menuMeals.Name = "menuMeals";
            menuMeals.Size = new Size(63, 25);
            menuMeals.Text = "&Meals";
            // 
            // menuMealsList
            // 
            menuMealsList.Name = "menuMealsList";
            menuMealsList.Size = new Size(104, 26);
            menuMealsList.Text = "List";
            // 
            // menuCookbooks
            // 
            menuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { menuCookbooksList, menuNewCookbook, menuAutoCreate });
            menuCookbooks.Name = "menuCookbooks";
            menuCookbooks.Size = new Size(100, 25);
            menuCookbooks.Text = "&Cookbooks";
            // 
            // menuCookbooksList
            // 
            menuCookbooksList.Name = "menuCookbooksList";
            menuCookbooksList.Size = new Size(187, 26);
            menuCookbooksList.Text = "List";
            // 
            // menuNewCookbook
            // 
            menuNewCookbook.Name = "menuNewCookbook";
            menuNewCookbook.Size = new Size(187, 26);
            menuNewCookbook.Text = "New Cookbook";
            // 
            // menuAutoCreate
            // 
            menuAutoCreate.Name = "menuAutoCreate";
            menuAutoCreate.Size = new Size(187, 26);
            menuAutoCreate.Text = "Auto-Create";
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
            menuData.Size = new Size(142, 26);
            menuData.Text = "&Edit Data";
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
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1029, 25);
            tsMain.TabIndex = 1;
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
            Text = "7";
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
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuDashboard;
        private ToolStripMenuItem menuRecipesList;
        private ToolStripMenuItem menuCloneARecipe;
        private ToolStripMenuItem menuMeals;
        private ToolStripMenuItem menuMealsList;
        private ToolStripMenuItem menuCookbooks;
        private ToolStripMenuItem menuCookbooksList;
        private ToolStripMenuItem menuNewCookbook;
        private ToolStripMenuItem menuAutoCreate;
    }
}