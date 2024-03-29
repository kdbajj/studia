﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KarolinaDbaj_Kosmetyki
{

    public abstract class Kosmetyk
    {
        private int numer;
        public string marka;
        string rodzajKosmetyku;
        public  float cena;
        public int kodProduktu;
        public bool testowanyDermatologicznie;
        string wykończenie;
        int trwałośćWMiesiącach;
        private DateTime dataZakupu;
        static int liczbaKosmetykow = -1;
        public int numerProduktu;
        //private string odcień;
        protected Bitmap image;


        public Kosmetyk()
        {
            numer = Form1.numer;
            //Form1.numer++;
            //this.nazwaMarki = "Maybelline";
            this.rodzajKosmetyku = "pomadka";
            this.cena = 36.99f;
            this.kodProduktu = 232;
            this.testowanyDermatologicznie = true;
            this.wykończenie = "matowe";
            this.trwałośćWMiesiącach = 12;
            this.dataZakupu = DateTime.Now;
            //this.tak = true;
            //this.nie = false;
            //string value1 = tak.ToString();
            //string value2 = nie.ToString();
        }
        public Kosmetyk(int numer, string nazwaMarki, string rodzajKosmetyku, int pojemność, float cena, int numerProduktu, string odcień, bool testowanyDermatologicznie, string wykończenie, int trwałośćWMiesiącach, bool wegańskie)
        {
            //liczbaKosmetykow += 1;
            //this.nazwaMarki = "Maybelline";
            this.rodzajKosmetyku = "pomadka";

            this.cena = 36.99f;
            this.kodProduktu = 232;

            this.testowanyDermatologicznie = true;
            this.wykończenie = "matowe";
            this.trwałośćWMiesiącach = 12;

        }
        public Kosmetyk(Kosmetyk O)
        {
            liczbaKosmetykow += 1;
            //this.numer = liczbaKosmetykow;
            //this.nazwaMarki = O.nazwaMarki;
            this.rodzajKosmetyku = O.rodzajKosmetyku;

            this.cena = O.cena;
            this.kodProduktu = O.kodProduktu;

            this.testowanyDermatologicznie = O.testowanyDermatologicznie;
            this.wykończenie = O.wykończenie;
            this.trwałośćWMiesiącach = O.trwałośćWMiesiącach;


        }
        public Kosmetyk(float cena, string marka, int numerProduktu, bool testowanyDermatologicznie, Bitmap image)
        {
            Przeglad.currentIndex++;
            numer = Przeglad.currentIndex;
            this.cena = cena;
            this.marka = marka;
            this.numerProduktu = numerProduktu;
            this.testowanyDermatologicznie = testowanyDermatologicznie;
            this.image = image;

        }
        public Kosmetyk(string rodzajKosmetyku, string nazwaMarki, float cena, int numerProduktu, bool testowanyDermatologicznie, int trwałośćWMiesiącach, string wykończenie, DateTime dataZakupu)
        {
            //numer += 1;
            this.rodzajKosmetyku = rodzajKosmetyku;
            // this.nazwaMarki = nazwaMarki;
            this.cena = cena;
            this.numerProduktu = numerProduktu;
            this.testowanyDermatologicznie = testowanyDermatologicznie;
            this.trwałośćWMiesiącach = trwałośćWMiesiącach;
            this.wykończenie = wykończenie;
            this.dataZakupu = dataZakupu;

        }

        private int TrwałośćWLatach()
        {
            int lata = trwałośćWMiesiącach / 12;
            if (lata != 1)
            {
                MessageBox.Show("Trwałość jest krótka(poniżej roku)", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);//wyskakuje powiadomienie ostrzegające, że produkt nie ma długiego terminu przydatności

            }
            return lata;
        }

        //public virtual void WriteToFile(StreamWriter sw)
        //{
        //}
        //Definicja metody wirtualnej wczytującej wartości pól z pliku tekstowego
        //Ciało funkcji jest zdefiniowane w odpowiednich funkcjach klas pochodnych
        public virtual void ReadFromFile(StreamReader sr)
        {
        }
        public virtual void Wypisz(ListBox lb)//metoda wirtualna w klasie bazowej
        {

        }

        public virtual void Wypisz(ListBox lb, PictureBox pb)//metoda wirtualna w klasie bazowej
        {
            // Przeglad przeglad = new Przeglad();
            // Przeglad.currentIndex += 1;
            // numer += 1;
            lb.Items.Add("Numer kosmetyku(kolejno):\t" + numer);
            lb.Items.Add("Nazwa marki:" + marka);
            lb.Items.Add("Cena produktu: " + cena);
            //lb.Items.Add("rodzaj kosmetyku:" + rodzajKosmetyku);

            //lb.Items.Add("Kod produktu: " + kodProduktu + NowyProdukt());

            lb.Items.Add("Testowany dermatologicznie: " + (testowanyDermatologicznie ? "tak" : "nie"));
            // lb.Items.Add("Wykończenie: " + wykończenie);
            //lb.Items.Add("Trwałość (w miesiącach): " + trwałośćWMiesiącach);
            //lb.Items.Add("Trwałość w latach: " + TrwałośćWLatach());
            //lb.Items.Add("Data zakupu: " + dataZakupu);
            pb.Image = image;

        }
        public virtual void ReadPhotoFromFile(string fullFileName)
        {
        }
        
        public float ObliczZniżkę(TextBox tb, Label lb)
        {
            //var textBoxZniżka = new TextBox();
            // var lblZniżka = new Label();
            tb.Text = "" + lb.Text;
            float cenaKońcowa;

            int ilość = (Convert.ToInt32(tb.Text));

            if ((Convert.ToInt32(lb.Text) % 2) == 0)
            {
                ilość = (Convert.ToInt32(lb.Text) / 2);
                cenaKońcowa = ilość * cena;
                lb.Text = "Cena za taką ilość produktów z wliczoną promocją to:" + cenaKońcowa;
            }
            else
                ilość = (Convert.ToInt32(tb.Text) / 2) + 1;
            cenaKońcowa = ilość * cena;

            lb.Text = "Cena za taką ilość produktów z wliczoną promocją to:";

            return cenaKońcowa;
        }
        public void ZaładujZdjęcie(PictureBox pictureBox1)
        {
            //PictureBox pictureBox = new PictureBox();
            string fileName = "kosmetyk.jpg";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            image = new Bitmap(path);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public static void ZaladujZdjecie(PictureBox pb)
        {
            OpenFileDialog otworz = new OpenFileDialog();
            if (otworz.ShowDialog() == DialogResult.OK)
            {
                Bitmap f = new Bitmap(otworz.OpenFile());
                pb.Image = f;
            }
        }
        public int Uczulenie()
        {
            if (testowanyDermatologicznie == true)
            {
                MessageBox.Show("Produkt może być stosowany nawet na skórę wrażliwą  na alergie.", "Produkt jest bezpieczny!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Jeśli jesteś podatny/a na wszelkie alergie, sprawdź skład produktu przed zakupem.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
        public int NowyProdukt()
        {
            if (numerProduktu > 200)
            {
                MessageBox.Show("Jest to jeden z naszych najnowszych produktów w promocyjnej cenie.", "Okazja!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return 0;
        }
        private void SaveImageToFile()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = @"JPG(*.JPG)|*.jpg";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    image.Save(saveFileDialog.FileName);
            }
            catch (System.Runtime.InteropServices.ExternalException e)
            {
                MessageBox.Show($"Bład podczas zapisu zdjęcia! Kod błędu: {e}");
            }
            catch(System.NullReferenceException e)
            {
                MessageBox.Show($"Bład podczas zapisu zdjęcia! Kod błędu: {e}");
            }
        }
        public virtual void WriteToFile(StreamWriter streamWriter)
        {
            SaveImageToFile();

            streamWriter.WriteLine(marka);
            streamWriter.WriteLine(cena);
            streamWriter.WriteLine(testowanyDermatologicznie);
            
        }
        public void LoadImage(PictureBox pb)
        {
            pb.Image = image;
            //IsCorrect = true;
        }

        public static void LoadImageDialog(PictureBox pb)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap f = new Bitmap(open.OpenFile());
                    pb.Image = f;
                }
            }
            catch (System.ArgumentException e)
            {
                MessageBox.Show($"Możliwe wczytywanie jest tylko zdjęć!\n\n Kod błędu: {e}");
            }
        }

        public virtual void ReadFromFile(List<string> stringList)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = @"JPG(*.JPG)|*.jpg|PNG|*.png";
            open.Title = "Wczytaj zdjęcie";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap f = new Bitmap(open.OpenFile());
                image = f;
            }

            marka = stringList[1];
            cena = GetInputValidator.ConvertToFloat(stringList[2]);
            testowanyDermatologicznie = AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(stringList[3]);
         
        }
    }
}
