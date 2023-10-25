namespace InventoryApp
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distributorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDistributorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.puchaseProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.unitToolStripMenuItem,
            this.productToolStripMenuItem,
            this.distributorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.userToolStripMenuItem.Text = "User ";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNewUserToolStripMenuItem.Text = "Add new user";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click_2);
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnitToolStripMenuItem});
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.unitToolStripMenuItem.Text = "Unit";
            // 
            // addUnitToolStripMenuItem
            // 
            this.addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            this.addUnitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addUnitToolStripMenuItem.Text = "Add unit ";
            this.addUnitToolStripMenuItem.Click += new System.EventHandler(this.addUnitToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductNameToolStripMenuItem,
            this.puchaseProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addProductNameToolStripMenuItem
            // 
            this.addProductNameToolStripMenuItem.Name = "addProductNameToolStripMenuItem";
            this.addProductNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProductNameToolStripMenuItem.Text = "Add product name";
            this.addProductNameToolStripMenuItem.Click += new System.EventHandler(this.addProductNameToolStripMenuItem_Click);
            // 
            // distributorToolStripMenuItem
            // 
            this.distributorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDistributorToolStripMenuItem});
            this.distributorToolStripMenuItem.Name = "distributorToolStripMenuItem";
            this.distributorToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.distributorToolStripMenuItem.Text = "Distributor";
            // 
            // addNewDistributorToolStripMenuItem
            // 
            this.addNewDistributorToolStripMenuItem.Name = "addNewDistributorToolStripMenuItem";
            this.addNewDistributorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addNewDistributorToolStripMenuItem.Text = "Add new distributor";
            this.addNewDistributorToolStripMenuItem.Click += new System.EventHandler(this.addNewDistributorToolStripMenuItem_Click);
            // 
            // puchaseProductToolStripMenuItem
            // 
            this.puchaseProductToolStripMenuItem.Name = "puchaseProductToolStripMenuItem";
            this.puchaseProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puchaseProductToolStripMenuItem.Text = "Puchase product";
            this.puchaseProductToolStripMenuItem.Click += new System.EventHandler(this.puchaseProductToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distributorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDistributorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puchaseProductToolStripMenuItem;
    }
}



