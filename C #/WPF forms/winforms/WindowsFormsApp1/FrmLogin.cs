using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("Bhargav", "naga");
            users.Add("Arun", "Arun");
            users.Add("Siva", "sada");
            string pwd = string.Empty;
            users.TryGetValue(txtUserName.Text, out pwd);
            if (pwd != null)
            {
                if (pwd.Equals(txtPassword.Text))
                {
                    FrmMenu obj = new FrmMenu();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid Credentials");
                }
            }
            else
            {
                MessageBox.Show("Invalid user.....");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }
    }
}
