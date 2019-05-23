namespace Disconnected_form
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
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtEmpname = new System.Windows.Forms.TextBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.lblBAsic = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblEmployname = new System.Windows.Forms.Label();
            this.lblEmpno = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(132, 206);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 23;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(132, 163);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(100, 20);
            this.txtDesig.TabIndex = 22;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(132, 109);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 21;
            // 
            // txtEmpname
            // 
            this.txtEmpname.Location = new System.Drawing.Point(132, 76);
            this.txtEmpname.Name = "txtEmpname";
            this.txtEmpname.Size = new System.Drawing.Size(100, 20);
            this.txtEmpname.TabIndex = 20;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(132, 39);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(100, 20);
            this.txtEmpno.TabIndex = 19;
            // 
            // lblBAsic
            // 
            this.lblBAsic.AutoSize = true;
            this.lblBAsic.Location = new System.Drawing.Point(56, 206);
            this.lblBAsic.Name = "lblBAsic";
            this.lblBAsic.Size = new System.Drawing.Size(33, 13);
            this.lblBAsic.TabIndex = 18;
            this.lblBAsic.Text = "Basic";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(56, 154);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 17;
            this.lblDesignation.Text = "Designation";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(56, 109);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 16;
            this.lblDept.Text = "Department";
            // 
            // lblEmployname
            // 
            this.lblEmployname.AutoSize = true;
            this.lblEmployname.Location = new System.Drawing.Point(56, 76);
            this.lblEmployname.Name = "lblEmployname";
            this.lblEmployname.Size = new System.Drawing.Size(67, 13);
            this.lblEmployname.TabIndex = 15;
            this.lblEmployname.Text = "Employname";
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(53, 39);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(43, 13);
            this.lblEmpno.TabIndex = 14;
            this.lblEmpno.Text = "Emp no";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtEmpname);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.lblBAsic);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblEmployname);
            this.Controls.Add(this.lblEmpno);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtEmpname;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.Label lblBAsic;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblEmployname;
        private System.Windows.Forms.Label lblEmpno;
        private System.Windows.Forms.Button btnSearch;
    }
}