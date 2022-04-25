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
            btnZniżka.Hide();
            textBoxZniżka.Hide();

        }

        //public ListBox ListBoxKosmetyk { get; private set; }
      
        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Width = 80;
            pictureBox1.Height = 90; 

            WyświetlObraz();

            Kosmetyk o1 = new Kosmetyk();
            o1.Wypisz(listBoxKosmetyk);

            Kosmetyk o2 = new Kosmetyk(2, "Maybelline", "Cienie do oczu", 15, 50.55f, 435, "kolorowy", true, "połyskujące", 15, true);
            o2.Wypisz(listBoxKosmetyk);

            Kosmetyk o3 = new Kosmetyk();
            o3.Wypisz(listBoxKosmetyk);
            lblZniżka.Text = "Promocja! \n Kup jeden dostań 2 gratis!\n Działa nawet przy zakupie kilku sztuk!\n Wpisz ile produktów chcesz kupić \n i oblicz ile wynosi całkowity koszt:";
            btnZniżka.Show();
            textBoxZniżka.Show();
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
            
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
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
            try
            {
                kosmetyk.ObliczZniżkę(Convert.ToInt32(textBoxZniżka.Text));
                lblZniżka.Text = "Cena za taką ilość produktów \n z wliczoną promocją to:" + kosmetyk.ObliczZniżkę(Convert.ToInt32(textBoxZniżka.Text)) + " zł";
                textBoxZniżka.Text = String.Empty;//czyścimy pole do wprowadzania danych, aby nie wyskoczył błąd
                int liczbaProduktów = (Convert.ToInt32(textBoxZniżka.Text));
            }
            catch (Exception)
            {
                lblZniżka.Text = "Błąd! Nie podałxś żadnej wartości!";
                
            }
        }
       

    private void textBoxZniżka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

