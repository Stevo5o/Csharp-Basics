using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();
            myCar.Make = "DeLorean";
            myCar.ElapsedMilage = 200000;

            MessageBox.Show(myCar.Make);

        }
       
    }
}
