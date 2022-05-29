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
    public partial class AkcesoriaKosmetyczneFormatka : Form
    {
        public AkcesoriaKosmetyczneFormatka()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text="123";
            textBox2.Text = "szczotka";
            textBox3.Text="200";
            textBox4.Text="plastik";
            textBox6.Text="rozczeswanie włosów";
           
            pictureBox2.Image = null;
            lblAkcesoria.Items.Clear();
            labelNowyProdukt.Text = "";

        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            pictureBox2.Image = null;
        }
        private void AkcesoriaKosmetyczneFormatka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            

        }
        private void button3_Click(object sender, EventArgs e)
        {


            AkcesoriaKosmetyczne akcesoria = new AkcesoriaKosmetyczne(Convert.ToInt32(textBox1.Text), textBox2.Text, AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()), Convert.ToInt32(textBox3.Text), textBox4.Text, AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox3.SelectedItem.ToString()), textBox6.Text, (Bitmap)pictureBox2.Image);
            labelNowyProdukt.Text = "Nowy produkt:";
            Form1.kosmetyki.Add(akcesoria); //dodanie obiektu do listy
            lblAkcesoria.Items.Clear(); //wyczyszczenie listBoxa
            labelNowyProdukt.Text = "";
            labelNowyProdukt.Text = "NOWY PRODUKT ZOSTAŁ DODANY DO LISTY";
            Form1.kosmetyki[Form1.kosmetyki.Count - 1].Wypisz(lblAkcesoria, pictureBox2);
        }
        //string[] odcienieSzczotki = comboBox3.Items.Cast<Object>().Select(item => item.ToString()).ToArray();
        // var artykul1 = new AkcesoriaKosmetyczne(Convert.ToInt32(textBox1.Text), Kosmetyk.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()), Convert.ToInt32(textBox3.Text), textBox4.Text, Kosmetyk.SetTestowanyDermatologicznie(comboBox3.SelectedItem.ToString()), textBox6.Text);
        // Przeglad.kosmetyki.Add(artykul1);
        // Przeglad.kosmetyki[Przeglad.kosmetyki.Count - 1].Wypisz(listBoxKosmetyk);

        //artykul1.Wypisz(lblAkcesoria);
        // lblAkcesoria.Items.Add("");
       /* private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap f = new Bitmap(openFileDialog1.OpenFile());
                pictureBox1.Image = f;
            }
        }*/
        //Metoda wywoływana przy zdarzeniu pokazania formatki FormStudent
        private void AkcesoriaKosmetyczneFormatka_Shown(object sender, EventArgs e)
        {
            ClearTextBoxes();
            labelNowyProdukt.Text = "";
            lblAkcesoria.Items.Clear();
            pictureBox2.Image = null;
        }




        private void AkcesoriaKosmetyczneFormatka_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
               
                               
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kosmetyk.ZaladujZdjecie(pictureBox2);

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            Form1 formatkaGłówna = new Form1();
            formatkaGłówna.Show();
            this.Hide();
        }
    }
}
