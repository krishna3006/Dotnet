namespace SqlPractice_Emp
{
    partial class Form3
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
            this.txtComm = new System.Windows.Forms.TextBox();
            this.txtInsta = new System.Windows.Forms.TextBox();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblDesig = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblEmpno = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(145, 222);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(100, 20);
            this.txtComm.TabIndex = 49;
            // 
            // txtInsta
            // 
            this.txtInsta.Location = new System.Drawing.Point(145, 177);
            this.txtInsta.Name = "txtInsta";
            this.txtInsta.Size = new System.Drawing.Size(100, 20);
            this.txtInsta.TabIndex = 48;
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(145, 134);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(100, 20);
            this.txtPremium.TabIndex = 47;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(145, 84);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 46;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(44, 222);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(51, 13);
            this.lblBasic.TabIndex = 45;
            this.lblBasic.Text = "Comment";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Location = new System.Drawing.Point(44, 185);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(57, 13);
            this.lblDesig.TabIndex = 44;
            this.lblDesig.Text = "Installment";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(44, 142);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(47, 13);
            this.lblDept.TabIndex = 43;
            this.lblDept.Text = "Premium";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Customer Name";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(145, 35);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 41;
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(44, 42);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(68, 13);
            this.lblEmpno.TabIndex = 40;
            this.lblEmpno.Text = "Customer ID ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(92, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(161, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(47, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.txtInsta);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblDesig);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblEmpno);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComm;
        private System.Windows.Forms.TextBox txtInsta;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblDesig;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblEmpno;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}