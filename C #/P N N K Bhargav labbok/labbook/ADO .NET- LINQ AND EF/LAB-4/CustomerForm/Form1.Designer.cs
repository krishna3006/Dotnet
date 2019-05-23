namespace CustomerForm
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
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.cmbcolumnlist = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCity.Location = new System.Drawing.Point(42, 33);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(96, 16);
            this.lblCustomerCity.TabIndex = 0;
            this.lblCustomerCity.Text = "Customer City :";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(42, 80);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(100, 16);
            this.lblSort.TabIndex = 1;
            this.lblSort.Text = "Sort Details On:";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(148, 32);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 20);
            this.txtcity.TabIndex = 2;
            // 
            // cmbcolumnlist
            // 
            this.cmbcolumnlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcolumnlist.FormattingEnabled = true;
            this.cmbcolumnlist.Items.AddRange(new object[] {
            "City",
            "CreditLimit",
            "CustomerName"});
            this.cmbcolumnlist.Location = new System.Drawing.Point(148, 80);
            this.cmbcolumnlist.Name = "cmbcolumnlist";
            this.cmbcolumnlist.Size = new System.Drawing.Size(121, 21);
            this.cmbcolumnlist.TabIndex = 3;
            this.cmbcolumnlist.SelectedIndexChanged += new System.EventHandler(this.cmbcolumnlist_SelectedIndexChanged_1);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(285, 28);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(29, 126);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(426, 256);
            this.grdCustomers.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 400);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.cmbcolumnlist);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblCustomerCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.ComboBox cmbcolumnlist;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView grdCustomers;
    }
}

