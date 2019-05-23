namespace WindowsFormsApp1
{
    partial class FrmMenu
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
            this.helloFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloFormToolStripMenuItem
            // 
            this.helloFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameFormToolStripMenuItem,
            this.calcFormToolStripMenuItem,
            this.contextMenuToolStripMenuItem});
            this.helloFormToolStripMenuItem.Name = "helloFormToolStripMenuItem";
            this.helloFormToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.helloFormToolStripMenuItem.Text = "Hello Form";
            this.helloFormToolStripMenuItem.Click += new System.EventHandler(this.helloFormToolStripMenuItem_Click);
            // 
            // nameFormToolStripMenuItem
            // 
            this.nameFormToolStripMenuItem.Name = "nameFormToolStripMenuItem";
            this.nameFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameFormToolStripMenuItem.Text = "Name Form";
            this.nameFormToolStripMenuItem.Click += new System.EventHandler(this.nameFormToolStripMenuItem_Click);
            // 
            // calcFormToolStripMenuItem
            // 
            this.calcFormToolStripMenuItem.Name = "calcFormToolStripMenuItem";
            this.calcFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcFormToolStripMenuItem.Text = "Calc Form";
            // 
            // contextMenuToolStripMenuItem
            // 
            this.contextMenuToolStripMenuItem.Name = "contextMenuToolStripMenuItem";
            this.contextMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contextMenuToolStripMenuItem.Text = "contextMenu";
            this.contextMenuToolStripMenuItem.Click += new System.EventHandler(this.contextMenuToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuToolStripMenuItem;
    }
}