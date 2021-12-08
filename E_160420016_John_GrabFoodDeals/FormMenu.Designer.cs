
namespace E_160420016_John_GrabFoodDeals
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemsToolStripMenuItem,
            this.displayItemsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuToolStripMenuItem,
            this.addRestaurantToolStripMenuItem,
            this.addPromoToolStripMenuItem});
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.addItemsToolStripMenuItem.Text = "Add Items";
            // 
            // addMenuToolStripMenuItem
            // 
            this.addMenuToolStripMenuItem.Name = "addMenuToolStripMenuItem";
            this.addMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addMenuToolStripMenuItem.Text = "Add Restaurant";
            this.addMenuToolStripMenuItem.Click += new System.EventHandler(this.addRestaurantToolStripMenuItem_Click);
            // 
            // addRestaurantToolStripMenuItem
            // 
            this.addRestaurantToolStripMenuItem.Name = "addRestaurantToolStripMenuItem";
            this.addRestaurantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRestaurantToolStripMenuItem.Text = "Add Menu";
            this.addRestaurantToolStripMenuItem.Click += new System.EventHandler(this.addMenuToolStripMenuItem_Click);
            // 
            // addPromoToolStripMenuItem
            // 
            this.addPromoToolStripMenuItem.Name = "addPromoToolStripMenuItem";
            this.addPromoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPromoToolStripMenuItem.Text = "Add Promo";
            this.addPromoToolStripMenuItem.Click += new System.EventHandler(this.addPromoToolStripMenuItem_Click);
            // 
            // displayItemsToolStripMenuItem
            // 
            this.displayItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayMenuToolStripMenuItem,
            this.displayRestaurantToolStripMenuItem,
            this.displayPromoToolStripMenuItem});
            this.displayItemsToolStripMenuItem.Name = "displayItemsToolStripMenuItem";
            this.displayItemsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.displayItemsToolStripMenuItem.Text = "Display Items";
            // 
            // displayMenuToolStripMenuItem
            // 
            this.displayMenuToolStripMenuItem.Name = "displayMenuToolStripMenuItem";
            this.displayMenuToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.displayMenuToolStripMenuItem.Text = "Display Menu";
            this.displayMenuToolStripMenuItem.Click += new System.EventHandler(this.displayMenuToolStripMenuItem_Click);
            // 
            // displayRestaurantToolStripMenuItem
            // 
            this.displayRestaurantToolStripMenuItem.Name = "displayRestaurantToolStripMenuItem";
            this.displayRestaurantToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.displayRestaurantToolStripMenuItem.Text = "Display Restaurant";
            this.displayRestaurantToolStripMenuItem.Click += new System.EventHandler(this.displayRestaurantToolStripMenuItem_Click);
            // 
            // displayPromoToolStripMenuItem
            // 
            this.displayPromoToolStripMenuItem.Name = "displayPromoToolStripMenuItem";
            this.displayPromoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.displayPromoToolStripMenuItem.Text = "Display Promo";
            this.displayPromoToolStripMenuItem.Click += new System.EventHandler(this.displayPromoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fjalla One", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grab Food Application";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Grab Food";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRestaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayRestaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

