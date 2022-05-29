using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyki
{
    public partial class Przeglad : Form
    {
        int currentIndex = -1;

        public Przeglad()
        {
            InitializeComponent();
            labelInfo.Text = "";
            currentIndex = -1;
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            if (currentIndex == 0) //jeżeli wyświetlamy pierwszy element na liście
                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (currentIndex >= Form1.kosmetyki.Count - 1) //jeżeli wyświetlamy ostatni element na liście
                button2.Enabled = false;
            else
                button2.Enabled = true;
            if (currentIndex < 0) //nic nie wyświetlamy
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void Przeglad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Przeglad_Load(object sender, EventArgs e)
        {

        }
        public static List<Kosmetyk> kosmetyki = new List<Kosmetyk>();

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex--;
            listBox1.Items.Clear();
            Form1.kosmetyki[currentIndex].Wypisz(listBox1, pictureBox2);
            UpdateButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex++;
            listBox1.Items.Clear();
            Form1.kosmetyki[currentIndex].Wypisz(listBox1, pictureBox2);
            UpdateButtons();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.kosmetyki.Count > 0) //jeżeli lista nie jest pusta
            {
                currentIndex = 0; //wyświetlamy pierwszy obiekt
                listBox1.Items.Clear();
                Form1.kosmetyki[currentIndex].Wypisz(listBox1, pictureBox2);
                UpdateButtons();
            }
            else
                MessageBox.Show("Lista jest pusta!");
        }
        private void Przeglad_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox2.Image = null;
            labelInfo.Text = "";
            currentIndex = -1;
            UpdateButtons();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 formatkaGłówna = new Form1();
            formatkaGłówna.Show();
            this.Hide();
        }
    }
}
