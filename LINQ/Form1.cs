using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace LINQ
{
    public partial class Form1 : Form
    {
        static void Print(string b, Hashtable a)
        {
            var strb = new StringBuilder();
            ICollection koll = a.Keys;
            strb.AppendLine($"{b}");
            foreach(string i in koll)
            {
                strb.AppendLine(i + " " + a[i]);
            }
            MessageBox.Show(strb.ToString(), "Сообщение", MessageBoxButtons.OKCancel);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test = true;
            Hashtable people = new Hashtable();
            StreamReader file = new StreamReader("Люди.txt");
            string peoples;
            while ((peoples = file.ReadLine()) != null)
            {
                string[] temp = peoples.Split(' ');
                string name = temp[0] + " " + temp[1] + " " + temp[2];
                string ageandves = temp[3] + " " + temp[4];
                if (int.Parse(temp[3]) < 40)
                    people.Add(name, ageandves);

            }
            Print("Люди: ", people);
        }
    }
}
