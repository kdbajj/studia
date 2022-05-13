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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //btnZniżka.Hide();
            // textBoxZniżka.Hide();
            lblZniżka.Text = "Promocja! \n Kup jeden dostań 2 gratis!\n Działa nawet przy zakupie kilku sztuk!\n Wpisz ile produktów chcesz kupić \n i oblicz ile wynosi całkowity koszt:";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WyświetlObraz();

            
            //btnZniżka.Show();
            //textBoxZniżka.Show();

            var kosmetyk1 = new Kosmetyk();
            kosmetyk1.Wypisz(listBoxKosmetyk);
            listBoxKosmetyk.Items.Add("");

            var kosmetyk2 = new Kosmetyk("pomadka", "maybelline", 22.6F, 4567, Convert.ToBoolean("true"), 12, "matowe", DateTime.Now);
            kosmetyk2.Wypisz(listBoxKosmetyk);
            listBoxKosmetyk.Items.Add("");

        }

        private void btnAkcesoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            AkcesoriaKosmetyczneFormatka akcesoria = new AkcesoriaKosmetyczneFormatka();
            akcesoria.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPielegnacja_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArtykulyPielegnacyjneFormatka pielęgnacja = new ArtykulyPielegnacyjneFormatka();
            pielęgnacja.Show();
        }

        public void MyDateTimePicker()
        {

            // DateTimePicker dateTimePicker1 = new DateTimePicker();
            var datepicker1 = DateTime.Now;
            // dateTimePicker1.MaxDate = DateTime.Now;
            //  dateTimePicker1.ShowCheckBox = true;
            // dateTimePicker1.ShowUpDown = true;


            // dateTimePicker1=DateTime.Now;
        }

        public void WyświetlObraz()
        {

            PictureBox pictureBox1 = new PictureBox();
            Bitmap image = new Bitmap("C:\\pomadka1.jpg");
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)image;
            Controls.Add(pictureBox1);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnZniżka_Click(object sender, EventArgs e)
        {

            var kosmetyk = new Kosmetyk();//tworzymy nowy obiekt 
                                          //try
                                          // {
            kosmetyk.ObliczZniżkę(Convert.ToInt32(textBoxZniżka.Text));
            lblZniżka.Text = "Cena za taką ilość produktów \n z wliczoną promocją to:" + kosmetyk.ObliczZniżkę(Convert.ToInt32(textBoxZniżka.Text)) + " zł";
            textBoxZniżka.Text = String.Empty;//czyścimy pole do wprowadzania danych, aby nie wyskoczył błąd
              
        }


        private void textBoxZniżka_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kosmetyk kosmetyk = new Kosmetyk(textBox1.Text, textBox6.Text, GetInputValidator.ConvertToFloat(textBox2.Text), Convert.ToInt32(textBox3.Text), Kosmetyk.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()), Convert.ToInt32(textBox5.Text), textBox4.Text, GetInputValidator.GetOnlyDDMMYYY(dataZakupu));
            kosmetyk.Wypisz(listBoxKosmetyk);
            listBoxKosmetyk.Items.Add("");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            var kosmetyk = new Kosmetyk();
            kosmetyk.ZaładujZdjęcie(pictureBox1);
        }
    }
}

