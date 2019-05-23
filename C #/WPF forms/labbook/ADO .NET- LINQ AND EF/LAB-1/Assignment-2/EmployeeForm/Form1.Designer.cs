namespace EmployeeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdconsultant = new System.Windows.Forms.RadioButton();
            this.rdpayroll = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtempno = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEmployName = new System.Windows.Forms.Label();
            this.lblEmployNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdconsultant);
            this.groupBox1.Controls.Add(this.rdpayroll);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(272, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 92);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Type";
            // 
            // rdconsultant
            // 
            this.rdconsultant.AutoSize = true;
            this.rdconsultant.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdconsultant.Location = new System.Drawing.Point(23, 50);
            this.rdconsultant.Name = "rdconsultant";
            this.rdconsultant.Size = new System.Drawing.Size(75, 17);
            this.rdconsultant.TabIndex = 1;
            this.rdconsultant.TabStop = true;
            this.rdconsultant.Text = "Consultant";
            this.rdconsultant.UseVisualStyleBackColor = true;
            // 
            // rdpayroll
            // 
            this.rdpayroll.AutoSize = true;
            this.rdpayroll.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdpayroll.Location = new System.Drawing.Point(23, 26);
            this.rdpayroll.Name = "rdpayroll";
            this.rdpayroll.Size = new System.Drawing.Size(56, 17);
            this.rdpayroll.TabIndex = 0;
            this.rdpayroll.TabStop = true;
            this.rdpayroll.Text = "Payroll";
            this.rdpayroll.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(15, 176);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 19;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(143, 108);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 20);
            this.txtsalary.TabIndex = 17;
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(143, 56);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(100, 20);
            this.txtempname.TabIndex = 16;
            // 
            // txtempno
            // 
            this.txtempno.Location = new System.Drawing.Point(143, 9);
            this.txtempno.Name = "txtempno";
            this.txtempno.ReadOnly = true;
            this.txtempno.Size = new System.Drawing.Size(100, 20);
            this.txtempno.TabIndex = 15;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(12, 108);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 16);
            this.lblSalary.TabIndex = 14;
            this.lblSalary.Text = "Salary :";
            // 
            // lblEmployName
            // 
            this.lblEmployName.AutoSize = true;
            this.lblEmployName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployName.Location = new System.Drawing.Point(12, 57);
            this.lblEmployName.Name = "lblEmployName";
            this.lblEmployName.Size = new System.Drawing.Size(116, 16);
            this.lblEmployName.TabIndex = 13;
            this.lblEmployName.Text = "Employee Name :";
            // 
            // lblEmployNo
            // 
            this.lblEmployNo.AutoSize = true;
            this.lblEmployNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployNo.Location = new System.Drawing.Point(12, 9);
            this.lblEmployNo.Name = "lblEmployNo";
            this.lblEmployNo.Size = new System.Drawing.Size(97, 16);
            this.lblEmployNo.TabIndex = 12;
            this.lblEmployNo.Text = "Employee No :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmployName);
            this.Controls.Add(this.lblEmployNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdconsultant;
        private System.Windows.Forms.RadioButton rdpayroll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEmployName;
        private System.Windows.Forms.Label lblEmployNo;
    }
}

