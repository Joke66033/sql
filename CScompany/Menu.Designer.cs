namespace CScompany
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.จดการขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ประเภทสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลกคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.แผนกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.พนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.จดการขอมลToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // จดการขอมลToolStripMenuItem
            // 
            this.จดการขอมลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ประเภทสนคาToolStripMenuItem,
            this.สนคาToolStripMenuItem,
            this.ลกคาToolStripMenuItem,
            this.แผนกToolStripMenuItem,
            this.พนกงานToolStripMenuItem});
            this.จดการขอมลToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.จดการขอมลToolStripMenuItem.Name = "จดการขอมลToolStripMenuItem";
            this.จดการขอมลToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.จดการขอมลToolStripMenuItem.Text = "จัดการข้อมูล";
            // 
            // ประเภทสนคาToolStripMenuItem
            // 
            this.ประเภทสนคาToolStripMenuItem.Name = "ประเภทสนคาToolStripMenuItem";
            this.ประเภทสนคาToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.ประเภทสนคาToolStripMenuItem.Text = "ประเภทสินค้า";
            this.ประเภทสนคาToolStripMenuItem.Click += new System.EventHandler(this.ประเภทสนคาToolStripMenuItem_Click);
            // 
            // สนคาToolStripMenuItem
            // 
            this.สนคาToolStripMenuItem.Name = "สนคาToolStripMenuItem";
            this.สนคาToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.สนคาToolStripMenuItem.Text = "สินค้า";
            this.สนคาToolStripMenuItem.Click += new System.EventHandler(this.สนคาToolStripMenuItem_Click);
            // 
            // ลกคาToolStripMenuItem
            // 
            this.ลกคาToolStripMenuItem.Name = "ลกคาToolStripMenuItem";
            this.ลกคาToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.ลกคาToolStripMenuItem.Text = "ลูกค้า";
            this.ลกคาToolStripMenuItem.Click += new System.EventHandler(this.ลกคาToolStripMenuItem_Click);
            // 
            // แผนกToolStripMenuItem
            // 
            this.แผนกToolStripMenuItem.Name = "แผนกToolStripMenuItem";
            this.แผนกToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.แผนกToolStripMenuItem.Text = "แผนก";
            this.แผนกToolStripMenuItem.Click += new System.EventHandler(this.แผนกToolStripMenuItem_Click);
            // 
            // พนกงานToolStripMenuItem
            // 
            this.พนกงานToolStripMenuItem.Name = "พนกงานToolStripMenuItem";
            this.พนกงานToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.พนกงานToolStripMenuItem.Text = "พนักงาน";
            this.พนกงานToolStripMenuItem.Click += new System.EventHandler(this.พนกงานToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem จดการขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ประเภทสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลกคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem แผนกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem พนกงานToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}