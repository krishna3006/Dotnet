namespace Disconnected_form
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
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtAgentid = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblAgentid = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(193, 225);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 19;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(183, 188);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 18;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(183, 147);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 17;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(183, 108);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 16;
            // 
            // txtAgentid
            // 
            this.txtAgentid.Location = new System.Drawing.Point(183, 64);
            this.txtAgentid.Name = "txtAgentid";
            this.txtAgentid.Size = new System.Drawing.Size(100, 20);
            this.txtAgentid.TabIndex = 15;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(73, 233);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 14;
            this.lblSSN.Text = "SSN";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(73, 188);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(70, 147);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 12;
            this.lblLastname.Text = "Lastname";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(81, 108);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(54, 13);
            this.lblFirstname.TabIndex = 11;
            this.lblFirstname.Text = "FirstName";
            // 
            // lblAgentid
            // 
            this.lblAgentid.AutoSize = true;
            this.lblAgentid.Location = new System.Drawing.Point(78, 64);
            this.lblAgentid.Name = "lblAgentid";
            this.lblAgentid.Size = new System.Drawing.Size(46, 13);
            this.lblAgentid.TabIndex = 10;
            this.lblAgentid.Text = "AgentID";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(47, 282);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 20;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(183, 282);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(305, 282);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(431, 282);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 23;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtAgentid);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblAgentid);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtAgentid;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblAgentid;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
    }
}