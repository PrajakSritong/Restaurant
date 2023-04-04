namespace Project_Restaurant
{
    partial class Order
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
            this.addFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFlieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastfoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaifoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFoodToolStripMenuItem,
            this.orderFoodToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFoodToolStripMenuItem
            // 
            this.addFoodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFlieToolStripMenuItem});
            this.addFoodToolStripMenuItem.Name = "addFoodToolStripMenuItem";
            this.addFoodToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.addFoodToolStripMenuItem.Text = "File";
            // 
            // saveFlieToolStripMenuItem
            // 
            this.saveFlieToolStripMenuItem.Name = "saveFlieToolStripMenuItem";
            this.saveFlieToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveFlieToolStripMenuItem.Text = "Save file";
            // 
            // orderFoodToolStripMenuItem
            // 
            this.orderFoodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem});
            this.orderFoodToolStripMenuItem.Name = "orderFoodToolStripMenuItem";
            this.orderFoodToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.orderFoodToolStripMenuItem.Text = "Order food";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastfoodToolStripMenuItem,
            this.thaifoodToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fastfoodToolStripMenuItem
            // 
            this.fastfoodToolStripMenuItem.Name = "fastfoodToolStripMenuItem";
            this.fastfoodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fastfoodToolStripMenuItem.Text = "Fast food";
            // 
            // thaifoodToolStripMenuItem
            // 
            this.thaifoodToolStripMenuItem.Name = "thaifoodToolStripMenuItem";
            this.thaifoodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thaifoodToolStripMenuItem.Text = "Thai food";
            // 
            // Foodprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Foodprice";
            this.Text = "Foodprice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addFoodToolStripMenuItem;
        private ToolStripMenuItem saveFlieToolStripMenuItem;
        private ToolStripMenuItem orderFoodToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem fastfoodToolStripMenuItem;
        private ToolStripMenuItem thaifoodToolStripMenuItem;
    }
}