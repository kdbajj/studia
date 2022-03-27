using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lista3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (Convert.ToInt32(textBox1.Text));
            Rysuj (n);

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Rysuj(int n)
        {

            int poziom = 0;
            for (int i = 1; i <= n; i++)
            {
                var list = new List<int>();
                for (int j = 0; j <= poziom; j++)
                {
                    list.Add(i);
                }
                listBox1.Items.Add(string.Join<int>(" ", list));
                poziom++;
            }
        }
    }
}


