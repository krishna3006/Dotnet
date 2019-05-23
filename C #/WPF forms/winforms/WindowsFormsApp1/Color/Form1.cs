using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            this.BackColor = dialog.Color;

        }

        private void bt2Font_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowDialog();
            bt2Font.Font = dialog.Font;
        }
    }
}



