namespace WindowsFormsApp1
{
    partial class FrmList
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
            this.lstSource = new System.Windows.Forms.ListBox();
            this.lstTarget = new System.Windows.Forms.ListBox();
            this.btnGreaterthan = new System.Windows.Forms.Button();
            this.btnLessthan = new System.Windows.Forms.Button();
            this.btnDoubleGreaterthan = new System.Windows.Forms.Button();
            this.btnDoubleLessthan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(118, 62);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(111, 147);
            this.lstSource.TabIndex = 0;
            this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged);
            // 
            // lstTarget
            // 
            this.lstTarget.FormattingEnabled = true;
            this.lstTarget.Location = new System.Drawing.Point(426, 51);
            this.lstTarget.Name = "lstTarget";
            this.lstTarget.Size = new System.Drawing.Size(129, 160);
            this.lstTarget.TabIndex = 1;
            // 
            // btnGreaterthan
            // 
            this.btnGreaterthan.Location = new System.Drawing.Point(294, 62);
            this.btnGreaterthan.Name = "btnGreaterthan";
            this.btnGreaterthan.Size = new System.Drawing.Size(75, 23);
            this.btnGreaterthan.TabIndex = 2;
            this.btnGreaterthan.Text = ">";
            this.btnGreaterthan.UseVisualStyleBackColor = true;
            this.btnGreaterthan.Click += new System.EventHandler(this.btnGreaterthan_Click);
            // 
            // btnLessthan
            // 
            this.btnLessthan.Location = new System.Drawing.Point(294, 102);
            this.btnLessthan.Name = "btnLessthan";
            this.btnLessthan.Size = new System.Drawing.Size(75, 23);
            this.btnLessthan.TabIndex = 3;
            this.btnLessthan.Text = "<";
            this.btnLessthan.UseVisualStyleBackColor = true;
            this.btnLessthan.Click += new System.EventHandler(this.btnLessthan_Click);
            // 
            // btnDoubleGreaterthan
            // 
            this.btnDoubleGreaterthan.Location = new System.Drawing.Point(294, 148);
            this.btnDoubleGreaterthan.Name = "btnDoubleGreaterthan";
            this.btnDoubleGreaterthan.Size = new System.Drawing.Size(75, 19);
            this.btnDoubleGreaterthan.TabIndex = 4;
            this.btnDoubleGreaterthan.Text = ">>";
            this.btnDoubleGreaterthan.UseVisualStyleBackColor = true;
            // 
            // btnDoubleLessthan
            // 
            this.btnDoubleLessthan.Location = new System.Drawing.Point(294, 187);
            this.btnDoubleLessthan.Name = "btnDoubleLessthan";
            this.btnDoubleLessthan.Size = new System.Drawing.Size(75, 23);
            this.btnDoubleLessthan.TabIndex = 5;
            this.btnDoubleLessthan.Text = "<<";
            this.btnDoubleLessthan.UseVisualStyleBackColor = true;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoubleLessthan);
            this.Controls.Add(this.btnDoubleGreaterthan);
            this.Controls.Add(this.btnLessthan);
            this.Controls.Add(this.btnGreaterthan);
            this.Controls.Add(this.lstTarget);
            this.Controls.Add(this.lstSource);
            this.Name = "FrmList";
            this.Text = "FrmList";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.ListBox lstTarget;
        private System.Windows.Forms.Button btnGreaterthan;
        private System.Windows.Forms.Button btnLessthan;
        private System.Windows.Forms.Button btnDoubleGreaterthan;
        private System.Windows.Forms.Button btnDoubleLessthan;
    }
}