namespace WindowsFormsApp1
{
    partial class frmComp
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
            this.lblNames = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(153, 108);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(40, 13);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Names";
            this.lblNames.Click += new System.EventHandler(this.lblNames_Click);
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(260, 99);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(121, 21);
            this.cmbNames.TabIndex = 1;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            // 
            // frmComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.lblNames);
            this.Name = "frmComp";
            this.Text = "frmComp";
            this.Load += new System.EventHandler(this.frmComp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.ComboBox cmbNames;
    }
}