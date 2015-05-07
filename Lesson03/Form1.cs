using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is a comment
            textBox1.Text = "Hello World";

            /*
             * this is a multi-line
             * comment
             */

            #region This is a region
            // this is a region and its useful for 
            // organising your code 
            // https://msdn.microsoft.com/en-us/library/9a1ybwek.aspx
            #endregion
        }
    }
}
