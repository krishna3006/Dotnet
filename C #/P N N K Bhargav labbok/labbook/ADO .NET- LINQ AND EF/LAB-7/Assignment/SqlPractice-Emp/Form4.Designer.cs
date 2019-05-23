namespace SqlPractice_Emp
{
    partial class Form4
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(126, 226);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(100, 20);
            this.txtComm.TabIndex = 59;
            // 
            // txtInsta
            // 
            this.txtInsta.Location = new System.Drawing.Point(126, 181);
            this.txtInsta.Name = "txtInsta";
            this.txtInsta.Size = new System.Drawing.Size(100, 20);
            this.txtInsta.TabIndex = 58;
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(126, 138);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(100, 20);
            this.txtPremium.TabIndex = 57;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(126, 88);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 56;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(25, 226);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(51, 13);
            this.lblBasic.TabIndex = 55;
            this.lblBasic.Text = "Comment";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Location = new System.Drawing.Point(25, 189);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(57, 13);
            this.lblDesig.TabIndex = 54;
            this.lblDesig.Text = "Installment";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(25, 146);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(47, 13);
            this.lblDept.TabIndex = 53;
            this.lblDept.Text = "Premium";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Customer Name";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(126, 39);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 51;
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(25, 46);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(68, 13);
            this.lblEmpno.TabIndex = 50;
            this.lblEmpno.Text = "Customer ID ";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(81, 304);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 78;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.btnInsert);
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
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
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
        private System.Windows.Forms.Button btnInsert;
    }
}