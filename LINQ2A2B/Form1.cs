using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ2A2B
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
        public struct a
        {
            public string fio;
            public string iner;
            public string oger;
            public double age;
            public double ves;
        }
        //--------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            List<Departament> department = new List<Departament>()
            {
                new Departament { NAZV = "Отдел закупок", COUNTRY ="Германия" },
                new Departament { NAZV = "Отдел продаж", COUNTRY ="Испания" },
                new Departament { NAZV = "Отдел маркетинга", COUNTRY ="Россия" }
            };

            List<Employ> employes = new List<Employ>()
            {
                    new Employ {NAZV2="Иванов", DEP ="Отдел закупок"},
                    new Employ {NAZV2="Петров", DEP ="Отдел закупок"},
                    new Employ {NAZV2="Сидоров", DEP ="Отдел продаж"},
                    new Employ {NAZV2="Лямин", DEP ="Отдел продаж "},
                    new Employ {NAZV2="Сидоренко", DEP ="Отдел маркетинга"},
                    new Employ {NAZV2="Кривоносов", DEP ="Отдел продаж "}
            };

            var result = from nm in employes
                         join t in department on nm.DEP equals t.NAZV
                         select new { Name = nm.NAZV2, DEP = nm.DEP, COUNTRY = t.COUNTRY };
        //-------------------------------------------------------------------------------------
            foreach (var mb in result)
            {
                label1.Text = ($"{mb.Name} - {mb.DEP} ({mb.COUNTRY}) \n" + label1.Text);

            }
        }
        //--------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            List<Departament> department = new List<Departament>()
            {
                new Departament { NAZV = "Отдел закупок", COUNTRY ="Германия" },
                new Departament { NAZV = "Отдел продаж", COUNTRY ="Испания" },
                new Departament { NAZV = "Отдел маркетинга", COUNTRY ="Россия" }
            };

            List<Employ> employes = new List<Employ>()
            {
                    new Employ {NAZV2="Иванов", DEP ="Отдел закупок"},
                    new Employ {NAZV2="Петров", DEP ="Отдел закупок"},
                    new Employ {NAZV2="Сидоров", DEP ="Отдел продаж"},
                    new Employ {NAZV2="Лямин", DEP ="Отдел продаж "},
                    new Employ {NAZV2="Сидоренко", DEP ="Отдел маркетинга"},
                    new Employ {NAZV2="Кривоносов", DEP ="Отдел продаж "}
            };
            //-----------------------------------------------------------------------------------
            var result = from nm in employes
                         join t in department on nm.DEP equals t.NAZV
                         select new { Name = nm.NAZV2, DEP = nm.DEP, COUNTRY = t.COUNTRY };
            //-----------------------------------------------------------------------------------
            foreach (var item in result)
                if (item.COUNTRY.StartsWith("И"))
                    label1.Text = ($"{item.Name} - {item.DEP} ({item.COUNTRY})\n" + label1.Text);
        }
        //---------------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
