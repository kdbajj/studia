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
            textBox7.Text = "The ordinary";
            textBox5.Text = "49,99";
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

            ArtykulyPielegnacyjne artykul = new ArtykulyPielegnacyjne(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(comboBox2.SelectedItem), GetInputValidator.ConvertToFloat(textBox5.Text), AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox3.SelectedItem.ToString()), textBox11.Text, textBox12.Text, (Bitmap)pictureBox2.Image, AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()), textBox7.Text);
            labelNowyProdukt.Text = "Nowy produkt:";
            Form1.kosmetyki.Add(artykul); //dodanie obiektu do listy
            lblPielegnacja.Items.Clear(); //wyczyszczenie listBoxa
            labelNowyProdukt.Text = "";
            labelNowyProdukt.Text = "NOWY PRODUKT ZOSTAŁ DODANY DO LISTY";
            Form1.kosmetyki[Form1.kosmetyki.Count - 1].Wypisz(lblPielegnacja, pictureBox2);

        }

        private void btnkPielegnacja_Click(object sender, EventArgs e)
        {

            //var artykul = new ArtykulyPielegnacyjne();
            //artykul.ObliczanieRabatu(lblRabat);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var artykuł = new ArtykulyPielegnacyjne();
            // artykuł.ObliczanieRabatu(lblRabat);
            artykuł.ObliczanieRabatu(lblRabat, comboBox2);

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

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("Nie wpisałeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboBox2_Leave_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
                MessageBox.Show("Nie zaznaczyłeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboBox3_Leave_1(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
                MessageBox.Show("Nie zaznaczyłeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void textBox11_Leave_1(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
                MessageBox.Show("Nie wpisałeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void textBox12_Leave_1(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
                MessageBox.Show("Nie wpisałeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboBox1_Leave_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Nie zaznaczyłeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void textBox7_Leave_1(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
                MessageBox.Show("Nie wpisałeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void textBox5_Leave_1(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
                MessageBox.Show("Nie wpisałeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {

           // if (textBox1.Text == "")
             //   MessageBox.Show("Nie wpisałeś/aś żadnej wartości!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // if (textBox1.MouseClick==System.Windows.Forms.MouseButtons.Right) { MessageBox.Show("Right click"); }

        }
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
           {
                textBox1.Text = "674";
            }      
        }

        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    textBox1.Text = "Krem";
            //}
        }

        private void textBox11_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
           // {
           //     textBox1.Text = "Cera sucha";
           // }
        }

        private void textBox12_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
           // {
            //    textBox1.Text = "Nawilżające";
            ///}
        }

        private void textBox7_MouseUp(object sender, MouseEventArgs e)
        {
           // if (e.Button == MouseButtons.Right)
           // {
           //     textBox1.Text = "The ordinary";
           // }
        }

        private void textBox5_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
           // {
           //     textBox1.Text = "50.99";
           // }
        }
    }
}
