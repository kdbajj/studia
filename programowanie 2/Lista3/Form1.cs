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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoginCheck()
        {
            string login = "karolina";
            string password = "dbaj";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                button2.Visible = true;
                button3.Visible = true;
            }
            else if (textBox1.Text!= login && textBox2.Text!= password)
            {
                MessageBox.Show ("Podałeś zły login lub hasło");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 zadanieA = new Form2();
            zadanieA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 zadanieB = new Form4();
            zadanieB.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
