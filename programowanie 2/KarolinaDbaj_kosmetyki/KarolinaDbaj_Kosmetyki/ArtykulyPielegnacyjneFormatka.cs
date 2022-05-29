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
    public partial class ArtykulyPielegnacyjneFormatka : Form
    {
        public ArtykulyPielegnacyjneFormatka()
        {
            InitializeComponent();
            lblRabat.Text = "Promocja! Jeśli kupisz produkt o pojemności 50 g \n otrzymasz rabat!";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1234";
            textBox11.Text = "cera trądzikowa";
            textBox2.Text = "Żel nawilżający";
            textBox12.Text = "myjące";
            pictureBox2.Image = null;
            lblPielegnacja.Items.Clear();
            labelNowyProdukt.Text = "";


        }

        private void ArtykulyPielegnacyjneFormatka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnUżytkownikPielegnacja_Click(object sender, EventArgs e)
        {
            /*var artykulyPielegnacyjne = new ArtykulyPielegnacyjne(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(comboBox2.SelectedItem), GetInputValidator.ConvertToFloat(textBox3.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()), textBox9.Text, Convert.ToInt32(textBox10.Text), AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox3.SelectedItem.ToString()), textBox11.Text, textBox12.Text);
            artykulyPielegnacyjne.Wypisz(lblPielegnacja);
            lblPielegnacja.Items.Add("");*/

            ArtykulyPielegnacyjne artykul = new ArtykulyPielegnacyjne(Convert.ToInt32(textBox1.Text),textBox2.Text, Convert.ToInt32(comboBox2.SelectedItem), AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox3.SelectedItem.ToString()), textBox11.Text, textBox12.Text, (Bitmap)pictureBox2.Image, AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString())); 
            labelNowyProdukt.Text = "Nowy produkt:";
            Form1.kosmetyki.Add(artykul); //dodanie obiektu do listy
            lblPielegnacja.Items.Clear(); //wyczyszczenie listBoxa
            labelNowyProdukt.Text = "";
            labelNowyProdukt.Text = "NOWY PRODUKT ZOSTAŁ DODANY DO LISTY";
            Form1.kosmetyki[Form1.kosmetyki.Count - 1].Wypisz(lblPielegnacja, pictureBox2);
        }


        private void btnkPielegnacja_Click(object sender, EventArgs e)
        {

            var artykul = new ArtykulyPielegnacyjne();
            artykul.ObliczanieRabatu(lblRabat);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var artykuł = new ArtykulyPielegnacyjne();
            artykuł.ObliczanieRabatu(lblRabat);
           
        }

        private void ArtykulyPielegnacyjneFormatka_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kosmetyk.ZaladujZdjecie(pictureBox2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 formatkaGłówna = new Form1();
            formatkaGłówna.Show();
            this.Hide();
            
        }
    }
}
