namespace WindowsFormsApp1
{
    partial class frmCalc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSecondNo = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First No";
            // 
            // txtFirstNo
            // 
            this.txtFirstNo.Location = new System.Drawing.Point(210, 47);
            this.txtFirstNo.Name = "txtFirstNo";
            this.txtFirstNo.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNo.TabIndex = 1;
            this.txtFirstNo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second No";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(118, 131);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // txtSecondNo
            // 
            this.txtSecondNo.Location = new System.Drawing.Point(210, 80);
            this.txtSecondNo.Name = "txtSecondNo";
            this.txtSecondNo.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNo.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(210, 131);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(79, 188);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(238, 187);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(385, 188);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "Mul";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstNo);
            this.Controls.Add(this.label1);
            this.Name = "frmCalc";
            this.Text = "frmCalc";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSecondNo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}