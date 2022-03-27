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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            int a=(Convert.ToInt32(textBox1.Text));
            Szachownica(a);

        }

       private void Szachownica(int a)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < a; i++)
            {
                var list = new List<int>();
                int znak;
                if (i % 2 == 0)
                {
                    znak = 0;
                }
                else
                {
                    znak = 1;
                }

                for (int j = 0; j < a; j++)
                {
                    if (znak == 0)
                    {
                        list.Insert(0, 0);
                        znak = 1;
                    }
                    else
                    {
                        list.Insert(0, 1);
                        znak = 0;
                    }
                }
                listBox1.Items.Add(string.Join<int>(" ", list));
            }

            
        }
       

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}





