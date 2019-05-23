namespace SupplierDetails
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
            this.cmbcolumnlist = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.grdSupplier = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcolumnlist
            // 
            this.cmbcolumnlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcolumnlist.FormattingEnabled = true;
            this.cmbcolumnlist.Items.AddRange(new object[] {
            "City",
            "Suppliername"});
            this.cmbcolumnlist.Location = new System.Drawing.Point(129, 77);
            this.cmbcolumnlist.Name = "cmbcolumnlist";
            this.cmbcolumnlist.Size = new System.Drawing.Size(121, 21);
            this.cmbcolumnlist.TabIndex = 5;
            this.cmbcolumnlist.SelectedIndexChanged += new System.EventHandler(this.cmbcolumnlist_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(23, 77);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(100, 16);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Sort Details On:";
            // 
            // grdSupplier
            // 
            this.grdSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplier.Location = new System.Drawing.Point(26, 132);
            this.grdSupplier.Name = "grdSupplier";
            this.grdSupplier.Size = new System.Drawing.Size(539, 250);
            this.grdSupplier.TabIndex = 6;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(340, 400);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(85, 23);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Location = new System.Drawing.Point(465, 400);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(95, 23);
            this.btnCancelChanges.TabIndex = 7;
            this.btnCancelChanges.Text = "Cancel Changes";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(270, 26);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 11;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(133, 30);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 20);
            this.txtcity.TabIndex = 10;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(27, 31);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(36, 16);
            this.lblSupplierName.TabIndex = 9;
            this.lblSupplierName.Text = "City :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 444);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.grdSupplier);
            this.Controls.Add(this.cmbcolumnlist);
            this.Controls.Add(this.lblSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcolumnlist;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.DataGridView grdSupplier;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label lblSupplierName;
    }
}

