using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// basic 'if' statement
            //if (comboBox1.Text == "SteJ")
            //{
            //    MessageBox.Show("You picked SteJ");
            //    comboBox1.Text = ""; // clears comboBox
            //}

            //// 'if' statement 
            //// curly braces removed
            //// one line of code to be executed
            //if (comboBox1.Text == "Steph")
            //    MessageBox.Show("You picked Steph");

            //if (comboBox1.Text != "Ste")
            //{
            //    if (comboBox1.Text == "SteJ")
            //    {
            //        MessageBox.Show("You picked SteJ.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("I'm not sure who you picked.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("You picked Ste");
            //}

            //// 'switch' statement 
            //switch (listBox1.SelectedItem.ToString())
            //{
            //    case "Foobar":
            //        MessageBox.Show("You picked Foobar");
            //        break;

            //    case "Bazquirk":
            //        MessageBox.Show("You picked Bazquirk");
            //        break;

            //    default:
            //        MessageBox.Show("You picked something else.");
            //        break;
            //}

            //// arrays set the size
            //string[] myArraySize = new string[2];
            //myArraySize[0] = "SteJ";
            //myArraySize[1] = "Steph";
            //myArraySize[2] = "Stevo"; // causes an out of bounds exception
            //MessageBox.Show(myArraySize[1]);

            //// array begin at [0] = Ste | [1] = SteJ | [2] = Stevo | [3] = Steph
            //string[] myArray = {"Ste", "SteJ", "Stevo", "Steph"};
            //// MessageBox.Show(myArray[1]);

            //// temp value nickname 
            //foreach (var nickname in myArray)
            //{
            //    MessageBox.Show(nickname);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}

            //int i = 0;
            //while (i < int.Parse(textBox1.Text))
            //{
            //    i++;
            //}
            //MessageBox.Show("The final value was: " + i.ToString());

            //// Combining array, for and if 
            //string[] myArray = {"Ste", "SteJ", "Stevo", "Steph"};

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] == "Stevo")
            //    {
            //        MessageBox.Show("Found Stevo");
            //    }
            //}

            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                switch (listBox1.SelectedItems[i].ToString())
                {
                    case "Foobar":
                        MessageBox.Show("Foobar");
                        break;

                    case "Bazquirk":
                        MessageBox.Show("Bazquirk");
                        break;

                    case "Widgets":
                        MessageBox.Show("Widgets");
                        break;

                    case "Gadgets":
                        MessageBox.Show("Gadgets");
                        break;
                }
            }
        }
    }
}

