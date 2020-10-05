using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Person p = new Person();
            p.Alder = 15;
            
            p.Navn = "sklædghlsdkhj";
            p.Løn = 654654.35;
            propertyGrid1.SelectedObject = p;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person a = (Person)propertyGrid1.SelectedObject;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person a = (Person)propertyGrid1.SelectedObject;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(a, Newtonsoft.Json.Formatting.Indented);
            MessageBox.Show(json);
        }
    }

    class Person {

        private int alder;

        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private bool erDansk;

        public bool ErDansk
        {
            get { return erDansk; }
            
        }

        private double løn;

        public double Løn
        {
            get { return løn; }
            set { løn = value; }
        }


    }
}
