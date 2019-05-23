namespace Color
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
            this.btnColor = new System.Windows.Forms.Button();
            this.bt2Font = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(74, 96);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // bt2Font
            // 
            this.bt2Font.Location = new System.Drawing.Point(246, 96);
            this.bt2Font.Name = "bt2Font";
            this.bt2Font.Size = new System.Drawing.Size(75, 23);
            this.bt2Font.TabIndex = 1;
            this.bt2Font.Text = "Font";
            this.bt2Font.UseVisualStyleBackColor = true;
            this.bt2Font.Click += new System.EventHandler(this.bt2Font_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt2Font);
            this.Controls.Add(this.btnColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button bt2Font;
    }
}

