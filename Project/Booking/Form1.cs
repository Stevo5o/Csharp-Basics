using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "1";
            checkBox1.BackColor = BackColor;

            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "B";
                checkBox1.BackColor = Color.Green;
            }
        }
    }
}
