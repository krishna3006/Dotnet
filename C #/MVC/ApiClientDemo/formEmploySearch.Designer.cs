namespace ApiClientDemo
{
    partial class formEmploySearch
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
            this.lblEmployno = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.txtEmployno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployno
            // 
            this.lblEmployno.AutoSize = true;
            this.lblEmployno.Location = new System.Drawing.Point(64, 58);
            this.lblEmployno.Name = "lblEmployno";
            this.lblEmployno.Size = new System.Drawing.Size(55, 13);
            this.lblEmployno.TabIndex = 0;
            this.lblEmployno.Text = "EmployNo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(66, 157);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(64, 218);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 3;
            this.lblDesignation.Text = "Designation";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(64, 266);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(33, 13);
            this.lblBasic.TabIndex = 4;
            this.lblBasic.Text = "Basic";
            // 
            // txtEmployno
            // 
            this.txtEmployno.Location = new System.Drawing.Point(155, 59);
            this.txtEmployno.Name = "txtEmployno";
            this.txtEmployno.Size = new System.Drawing.Size(100, 20);
            this.txtEmployno.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(147, 166);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 7;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(169, 215);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(100, 20);
            this.txtDesignation.TabIndex = 8;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(161, 265);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(369, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // formEmploySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmployno);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmployno);
            this.Name = "formEmploySearch";
            this.Text = "formEmploySearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployno;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.TextBox txtEmployno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Button btnSearch;
    }
}