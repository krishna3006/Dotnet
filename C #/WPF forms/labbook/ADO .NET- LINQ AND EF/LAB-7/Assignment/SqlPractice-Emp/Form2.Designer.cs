namespace SqlPractice_Emp
{
    partial class Form2
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblDesig = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblEmpno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(101, 287);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 77;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(138, 208);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 75;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(138, 163);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(100, 20);
            this.txtDesig.TabIndex = 74;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(138, 120);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 73;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 72;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(37, 208);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(42, 13);
            this.lblBasic.TabIndex = 71;
            this.lblBasic.Text = "Basic : ";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Location = new System.Drawing.Point(37, 171);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(69, 13);
            this.lblDesig.TabIndex = 70;
            this.lblDesig.Text = "Designation: ";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(37, 128);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(68, 13);
            this.lblDept.TabIndex = 69;
            this.lblDept.Text = "Department: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "Employ Name: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(138, 21);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 67;
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(37, 28);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(87, 13);
            this.lblEmpno.TabIndex = 66;
            this.lblEmpno.Text = "Employ Number: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblDesig);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblEmpno);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblDesig;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblEmpno;
    }
}