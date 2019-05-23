namespace ApplicationUsers
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.btnstate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(249, 338);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(85, 23);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Location = new System.Drawing.Point(374, 338);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(95, 23);
            this.btnCancelChanges.TabIndex = 4;
            this.btnCancelChanges.Text = "Cancel Changes";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // grdUsers
            // 
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Location = new System.Drawing.Point(12, 12);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.Size = new System.Drawing.Size(480, 300);
            this.grdUsers.TabIndex = 3;
            // 
            // btnstate
            // 
            this.btnstate.Location = new System.Drawing.Point(32, 338);
            this.btnstate.Name = "btnstate";
            this.btnstate.Size = new System.Drawing.Size(102, 23);
            this.btnstate.TabIndex = 6;
            this.btnstate.Text = "Show Row State";
            this.btnstate.UseVisualStyleBackColor = true;
            this.btnstate.Click += new System.EventHandler(this.btnstate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 384);
            this.Controls.Add(this.btnstate);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.grdUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.Button btnstate;
    }
}

