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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void helloFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.MdiParent = this;
            obj.Show();
        }

        private void nameFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
