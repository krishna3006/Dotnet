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
    public partial class frmComp : Form
    {
        public frmComp()
        {
            InitializeComponent();
        }

        private void lblNames_Click(object sender, EventArgs e)
        {

        }

        private void frmComp_Load(object sender, EventArgs e)
        {
            cmbNames.Items.Add("Arun");
            cmbNames.Items.Add("Bhargav");
            cmbNames.Items.Add("SIva");
            cmbNames.Items.Add("Krishna");
        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Name is" + cmbNames.Text);
        }
    }
}
