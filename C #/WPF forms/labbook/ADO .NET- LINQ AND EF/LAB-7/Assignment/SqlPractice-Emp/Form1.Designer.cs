namespace SqlPractice_Emp
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
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(42, 286);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(131, 203);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 62;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(131, 158);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(100, 20);
            this.txtDesig.TabIndex = 61;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(131, 115);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 60;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 59;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(30, 203);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(42, 13);
            this.lblBasic.TabIndex = 58;
            this.lblBasic.Text = "Basic : ";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Location = new System.Drawing.Point(30, 166);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(69, 13);
            this.lblDesig.TabIndex = 57;
            this.lblDesig.Text = "Designation: ";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(30, 123);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(68, 13);
            this.lblDept.TabIndex = 56;
            this.lblDept.Text = "Department: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 55;
            this.lblName.Text = "Employ Name: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(131, 16);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 54;
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(30, 23);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(87, 13);
            this.lblEmpno.TabIndex = 53;
            this.lblEmpno.Text = "Employ Number: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

