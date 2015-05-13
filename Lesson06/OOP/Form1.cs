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
            myCar.ElapsedMilage = 9999999;

            // MessageBox.Show(myCar.Make);

            // int result = AddTwoNumbers(3, 5);
            // displayMessage(result.ToString());
            // MessageBox.Show(result.ToString());
            displayMessage(AddTwoNumbers(3, 5).ToString());
        }

        // add two numbers method 
        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void displayMessage(string message)
        {
            MessageBox.Show((message));
        }
    }
}
