using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int liczba = Convert.ToInt32(textBox1.Text);
            if (liczba < 0)
            {
                label3.Text = "Podałeś liczbę ujemną.";
                return;
            }
            int objętość = liczba * liczba * liczba;
            int PolePowierzchni = 6 * (liczba * liczba);
            label3.Text = "Objętość sześcianu to " + objętość + ",  a pole powierzchni to " + PolePowierzchni;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(textBox2.Text);
            int liczba2 = Convert.ToInt32(textBox3.Text);
            int wynikSumy = liczba1 + liczba2;
            int wynikKońcowy = 0;
            if (wynikSumy <= 0)
            {
                wynikKońcowy = 0;
            }
            else if (wynikSumy > 0 && wynikSumy <= 10)
            {
                wynikKońcowy = (liczba1 * liczba1 * liczba1) * (liczba2 * liczba2 * liczba2);

            }
            else if (wynikSumy > 10 && wynikSumy <= 100)
            {

                wynikKońcowy = liczba1 + liczba2;
            }
            else if (wynikSumy > 100)
            {
                wynikKońcowy = liczba1 + liczba2;
            }
            label6.Text = "Wynik końcowy to " + wynikKońcowy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            int i = 0;
            for (i = 1; i <= a; ++i)
            {
                if (a % i == 0)
                {
                    label9.Text += i + ", ";

                }
            }
        }

        public List<int> ListN = new List<int>();
        private int Maks()
        {
            if (ListN.Count() != 0) label12.Text = "Największą liczbą jest " + ListN.Max();
            return ListN.Max();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true; // prevent beep

                if (textBox6.Text == "0")
                {
                    textBox6.Text = "";
                    int result = Maks();
                    ListN.RemoveRange(0, ListN.Count);
                    return;
                }
                ListN.Add(Convert.ToInt32(textBox6.Text));
                textBox6.Text = "";
                label12.Text = "";
            }
        }
    }
}
