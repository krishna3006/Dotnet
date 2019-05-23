namespace AdoConnected2
{
    partial class Agent
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
            this.lblAgentid = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtAgentid = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAgentid
            // 
            this.lblAgentid.AutoSize = true;
            this.lblAgentid.Location = new System.Drawing.Point(91, 53);
            this.lblAgentid.Name = "lblAgentid";
            this.lblAgentid.Size = new System.Drawing.Size(46, 13);
            this.lblAgentid.TabIndex = 0;
            this.lblAgentid.Text = "AgentID";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(94, 97);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(54, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "FirstName";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(83, 136);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(86, 177);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(86, 222);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 4;
            this.lblSSN.Text = "SSN";
            // 
            // txtAgentid
            // 
            this.txtAgentid.Location = new System.Drawing.Point(196, 53);
            this.txtAgentid.Name = "txtAgentid";
            this.txtAgentid.Size = new System.Drawing.Size(100, 20);
            this.txtAgentid.TabIndex = 5;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(196, 97);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(196, 136);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(196, 177);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(206, 214);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Agent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgentid;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtAgentid;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSSN;
    }
}

