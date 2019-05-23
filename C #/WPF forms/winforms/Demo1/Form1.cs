using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            this.BackColor = dialog.Color;
        }
    }
}
