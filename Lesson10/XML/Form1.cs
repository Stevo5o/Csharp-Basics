using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"cars.xml");

            System.Xml.XmlTextReader xr = new System.Xml.XmlTextReader(sr);

            System.Xml.XmlDocument carCollectionDoc = new System.Xml.XmlDocument();

            carCollectionDoc.Load(xr);

            linkLabel1.Text = carCollectionDoc.InnerText;
        }
    }
}
