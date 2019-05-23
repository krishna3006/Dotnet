namespace AdoStoredProcedures
{
    partial class Form1
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
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtEmpname = new System.Windows.Forms.TextBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmployname = new System.Windows.Forms.Label();
            this.lblEmployno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(387, 314);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 19;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(387, 264);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(100, 20);
            this.txtDesig.TabIndex = 18;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(387, 212);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 17;
            // 
            // txtEmpname
            // 
            this.txtEmpname.Location = new System.Drawing.Point(387, 165);
            this.txtEmpname.Name = "txtEmpname";
            this.txtEmpname.Size = new System.Drawing.Size(100, 20);
            this.txtEmpname.TabIndex = 16;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(387, 115);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(100, 20);
            this.txtEmpno.TabIndex = 15;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(319, 322);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(33, 13);
            this.lblBasic.TabIndex = 14;
            this.lblBasic.Text = "Basic";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(316, 272);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 13;
            this.lblDesignation.Text = "Designation";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(316, 212);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 12;
            this.lblDepartment.Text = "Department";
            // 
            // lblEmployname
            // 
            this.lblEmployname.AutoSize = true;
            this.lblEmployname.Location = new System.Drawing.Point(316, 165);
            this.lblEmployname.Name = "lblEmployname";
            this.lblEmployname.Size = new System.Drawing.Size(67, 13);
            this.lblEmployname.TabIndex = 11;
            this.lblEmployname.Text = "Employname";
            // 
            // lblEmployno
            // 
            this.lblEmployno.AutoSize = true;
            this.lblEmployno.Location = new System.Drawing.Point(313, 123);
            this.lblEmployno.Name = "lblEmployno";
            this.lblEmployno.Size = new System.Drawing.Size(53, 13);
            this.lblEmployno.TabIndex = 10;
            this.lblEmployno.Text = "Employno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtEmpname);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployname);
            this.Controls.Add(this.lblEmployno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtEmpname;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmployname;
        private System.Windows.Forms.Label lblEmployno;
    }
}

