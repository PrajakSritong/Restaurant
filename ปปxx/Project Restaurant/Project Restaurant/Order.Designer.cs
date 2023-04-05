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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastfoodToolStripMenuItem,
            this.thaifoodToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // fastfoodToolStripMenuItem
            // 
            this.fastfoodToolStripMenuItem.Name = "fastfoodToolStripMenuItem";
            this.fastfoodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fastfoodToolStripMenuItem.Text = "Fast food";
            this.fastfoodToolStripMenuItem.Click += new System.EventHandler(this.fastfoodToolStripMenuItem_Click);
            // 
            // thaifoodToolStripMenuItem
            // 
            this.thaifoodToolStripMenuItem.Name = "thaifoodToolStripMenuItem";
            this.thaifoodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thaifoodToolStripMenuItem.Text = "Thai food";
            this.thaifoodToolStripMenuItem.Click += new System.EventHandler(this.thaifoodToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "ประวัติการสั่งซื้อ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-8, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(808, 287);
            this.dataGridView1.TabIndex = 9;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Order";
            this.Text = "Foodprice";
            this.Load += new System.EventHandler(this.Order_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Label label1;
        private DataGridView dataGridView1;
    }
}