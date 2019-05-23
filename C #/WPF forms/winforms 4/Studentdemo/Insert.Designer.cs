namespace Studentdemo
{
    partial class Insert
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtStudentname = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblStudentname = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(134, 141);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 20);
            this.txtMobile.TabIndex = 23;
            // 
            // txtStudentname
            // 
            this.txtStudentname.Location = new System.Drawing.Point(134, 86);
            this.txtStudentname.Name = "txtStudentname";
            this.txtStudentname.Size = new System.Drawing.Size(100, 20);
            this.txtStudentname.TabIndex = 22;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(134, 44);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(50, 141);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(38, 13);
            this.lblMobile.TabIndex = 19;
            this.lblMobile.Text = "Mobile";
            // 
            // lblStudentname
            // 
            this.lblStudentname.AutoSize = true;
            this.lblStudentname.Location = new System.Drawing.Point(50, 86);
            this.lblStudentname.Name = "lblStudentname";
            this.lblStudentname.Size = new System.Drawing.Size(70, 13);
            this.lblStudentname.TabIndex = 18;
            this.lblStudentname.Text = "Studentname";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(47, 44);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(55, 13);
            this.lblStudentId.TabIndex = 17;
            this.lblStudentId.Text = "StudentID";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(288, 122);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtStudentname);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblStudentname);
            this.Controls.Add(this.lblStudentId);
            this.Name = "Insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtStudentname;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblStudentname;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnInsert;
    }
}