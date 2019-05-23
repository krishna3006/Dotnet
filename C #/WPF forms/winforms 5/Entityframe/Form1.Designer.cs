namespace Entityframe
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
            this.lblEmpno = new System.Windows.Forms.Label();
            this.lblEmployname = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.txtEmployname = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(65, 52);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(40, 13);
            this.lblEmpno.TabIndex = 0;
            this.lblEmpno.Text = "Empno";
            // 
            // lblEmployname
            // 
            this.lblEmployname.AutoSize = true;
            this.lblEmployname.Location = new System.Drawing.Point(68, 106);
            this.lblEmployname.Name = "lblEmployname";
            this.lblEmployname.Size = new System.Drawing.Size(67, 13);
            this.lblEmployname.TabIndex = 1;
            this.lblEmployname.Text = "Employname";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(68, 161);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(58, 226);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 3;
            this.lblDesignation.Text = "Designation";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(61, 270);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(33, 13);
            this.lblBasic.TabIndex = 4;
            this.lblBasic.Text = "Basic";
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(160, 52);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(100, 20);
            this.txtEmpno.TabIndex = 5;
            // 
            // txtEmployname
            // 
            this.txtEmployname.Location = new System.Drawing.Point(148, 106);
            this.txtEmployname.Name = "txtEmployname";
            this.txtEmployname.Size = new System.Drawing.Size(100, 20);
            this.txtEmployname.TabIndex = 6;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(148, 158);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 7;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(148, 219);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(100, 20);
            this.txtDesig.TabIndex = 8;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(160, 267);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(349, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(349, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(338, 199);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtEmployname);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployname);
            this.Controls.Add(this.lblEmpno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpno;
        private System.Windows.Forms.Label lblEmployname;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.TextBox txtEmployname;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
    }
}