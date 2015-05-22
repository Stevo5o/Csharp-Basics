using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            linkLabel2.Text = " First child node: " + carCollectionDoc.FirstChild.InnerText;

            linkLabel3.Text = " Second child node: " + carCollectionDoc.FirstChild.NextSibling.InnerText;

            System.Xml.XmlNode carcollection = carCollectionDoc.FirstChild.NextSibling;

            linkLabel4.Text = "Now that we have a reference to 'carcollection': " + carcollection.FirstChild.InnerText;

            linkLabel5.Text = "First child of carcollection: " + carcollection.FirstChild.InnerText;

            linkLabel6.Text = "First child of the first child of carcollection: " + carcollection.FirstChild.FirstChild.InnerText;

            System.Xml.XmlNodeList carCollectionItems = carCollectionDoc.SelectNodes("carcollection/car");

            System.Xml.XmlNode make = carCollectionItems.Item(0).SelectSingleNode("make");

            linkLabel7.Text = "make.InnerText: " + make.InnerText;
        }
    }
}
