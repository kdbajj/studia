using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //lblZniżka.Text = "Promocja! \n Kup jeden dostań 2 gratis!\n Działa nawet przy zakupie kilku sztuk!\n Wpisz ile produktów chcesz kupić \n i oblicz ile wynosi całkowity koszt:";
        }
        public static int numer = 0;
        Przeglad przeglad1 = new Przeglad();
        public static List<Kosmetyk> kosmetyki = new List<Kosmetyk>();
        AkcesoriaKosmetyczneFormatka akcesoria = new AkcesoriaKosmetyczneFormatka(); // OBIEKT formatki do dodawania studentów do listy
        ArtykulyPielegnacyjneFormatka artykuly = new ArtykulyPielegnacyjneFormatka(); // OBIEKT formatki do dodawania wykładowców do listy
        Przeglad przeglad = new Przeglad();

        private void button1_Click(object sender, EventArgs e)
        {
            WyświetlObraz();

            //btnZniżka.Show();
            //textBoxZniżka.Show();

            //Kosmetyk kosmetyk1 = new Kosmetyk();
            //kosmetyk1.Wypisz(listBoxKosmetyk);
            //listBoxKosmetyk.Items.Add("");

            //var kosmetyk2 = new Kosmetyk("pomadka", "maybelline", 22.6F, 4567, Convert.ToBoolean("true"), 12, "matowe", DateTime.Now);
            //kosmetyk2.Wypisz(listBoxKosmetyk);
            //listBoxKosmetyk.Items.Add("");

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
            //dateTimePicker1.MaxDate = DateTime.Now;
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

            //var kosmetyk = new Kosmetyk();
            // kosmetyk.ObliczZniżkę(Convert.ToInt32(textBoxZniżka.Text));
            // lblZniżka.Text = "Cena za taką ilość produktów \n z wliczoną promocją to:" + kosmetyk.ObliczZniżkę(Convert.ToInt32(textBoxZniżka.Text)) + " zł";
            // textBoxZniżka.Text = String.Empty;//czyścimy pole do wprowadzania danych, aby nie wyskoczył błąd

        }


        private void textBoxZniżka_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kosmetyk kosmetyk = new Kosmetyk(textBox1.Text, textBox6.Text, GetInputValidator.ConvertToFloat(textBox2.Text), Convert.ToInt32(textBox3.Text), Kosmetyk.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()), Convert.ToInt32(textBox5.Text), textBox4.Text, GetInputValidator.GetOnlyDDMMYYY(dataZakupu));
            // kosmetyk.Wypisz(listBoxKosmetyk);
            //  listBoxKosmetyk.Items.Add("");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            var kosmetyk = new ArtykulyPielegnacyjne();
            kosmetyk.ZaładujZdjęcie(pictureBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Przeglad przeglad = new Przeglad();

            przeglad.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FunkcjeOperatorowe funkcje = new FunkcjeOperatorowe();
            funkcje.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string pathPhotos = textBox1.Text;
            int i = 0;
            OpenFileDialog ofd = new OpenFileDialog(); //okno dialogowe do wyboru pliku do odczytu danych
            ofd.Filter = "Plik tekstowy|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName); //otwarcie pliku do odczytu
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line == "A") //odczytanie linii "pomocniczej", żeby wiedzieć,
                    { //jakiej klasy obiekt utworzyć (i jakie pola wczytać)
                        ArtykulyPielegnacyjne a = new ArtykulyPielegnacyjne();
                        a.ReadFromFile(sr);
                        a.ReadPhotoFromFile(pathPhotos + "//" + i + ".bmp");
                        kosmetyki.Add(a);
                        i++;
                    }
                    else if (line == "K")
                    {
                        AkcesoriaKosmetyczne k = new AkcesoriaKosmetyczne();
                        k.ReadFromFile(sr); //DLA WYKŁADOWCY BRAKUJE JESZCZE WCZYTYWANIA OBRAZÓW!!!
                        kosmetyki.Add(k);
                        i++;
                    }
                }
                sr.Close(); //zamknięcie pliku
                            //Dla każdego obiektu na liście wyświetl dane obiektu w listBox1
                foreach (Kosmetyk a in kosmetyki)
                    a.Wypisz(listBox1);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string pathPhotos = textBox1.Text;
            bool exists = System.IO.Directory.Exists(pathPhotos);
            if (!exists)
                System.IO.Directory.CreateDirectory(pathPhotos);
            SaveFileDialog sfd = new SaveFileDialog(); //okno dialogowe do wyboru pliku do zapisu
            sfd.Filter = "Plik tekstowy|*.txt";
            sfd.Title = "Podaj nazwę pliku do zapisu danych osób";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                for (int i = 0; i < kosmetyki.Count; i++) //dla każdego obiektu na liście list
                {
                   kosmetyki[i].WriteToFile(sw); //wywołaj odpowiednią wersję metody (wirtualnej)
                                              //zapisującej do pliku
                   kosmetyki[i].WritePhotoToFile(pathPhotos + "//" + i + ".bmp"); //wywołaj metodę zapisującą
                                                                               //zdjęcie do katalogu
                }
                sw.Close();
            }
        }
        string plik="testowy.txt";
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = plik;
        }
    }
}


