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
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            lstSource.Items.Add("Arun");
            lstSource.Items.Add("Bhargav");
            lstSource.Items.Add("Krishna");
            lstSource.Items.Add("Siva");
        }

        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGreaterthan_Click(object sender, EventArgs e)
        {
            lstTarget.Items.Add(lstSource.Text);
            lstSource.Items.Remove(lstSource.Text);
        }

        private void btnLessthan_Click(object sender, EventArgs e)
        {
            for (int i = 0;i< lstSource.Items.Count; i++)
            {
                lstTarget.Items.Add(lstSource.Items[i].ToString());
            }
            lstSource.Items.Clear();
        }
    }
}
