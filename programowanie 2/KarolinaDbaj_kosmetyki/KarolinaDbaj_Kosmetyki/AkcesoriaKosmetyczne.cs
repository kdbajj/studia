using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace KarolinaDbaj_Kosmetyki
{
    class AkcesoriaKosmetyczne : Kosmetyk
    {
        string nazwa;
        public int waga;
        string materiałWykonania;
        bool przyjazneŚrodowisku;
        string doCzegoSłuży;
        ArrayList odcienieSzczotki = new ArrayList();
        Bitmap image2;

        public AkcesoriaKosmetyczne() : base()
        {
            nazwa = "szczotka";
            waga = 100;
            materiałWykonania = "plastik";
            przyjazneŚrodowisku = true;
            doCzegoSłuży = "rozczesywanie włosów";
            this.odcienieSzczotki.Add("czerwony");
            this.odcienieSzczotki.Add("różowy");
            this.odcienieSzczotki.Add("fioletowy");
        }
        public AkcesoriaKosmetyczne(int numerProduktu,string nazwa,
            bool testowanyDermatologicznie, int waga, string materiałWykonania,
            string marka,float cena, bool przyjazneŚrodowisku, string doCzegoSłuży,
            Bitmap image) 
            : base(cena, marka,numerProduktu, testowanyDermatologicznie,image)
        {
            
            this.nazwa = nazwa;
            this.waga = waga;
            this.materiałWykonania = materiałWykonania;
            this.przyjazneŚrodowisku = przyjazneŚrodowisku;
            this.doCzegoSłuży = doCzegoSłuży;
            this.odcienieSzczotki.Add("czerwony");
            this.odcienieSzczotki.Add("różowy");
            this.odcienieSzczotki.Add("fioletowy");


        }
        public AkcesoriaKosmetyczne(int waga)
            
        {
            this.waga = waga;
        }
            public AkcesoriaKosmetyczne(AkcesoriaKosmetyczne o) : base(o)
        {
            this.nazwa = o.nazwa;
            this.waga = o.waga;
            this.materiałWykonania = o.materiałWykonania;
            this.przyjazneŚrodowisku = o.przyjazneŚrodowisku;
            this.doCzegoSłuży = o.doCzegoSłuży;
            this.odcienieSzczotki.Add("czerwony");
            this.odcienieSzczotki.Add("różowy");
            this.odcienieSzczotki.Add("fioletowy");
        }
        public override void Wypisz(ListBox lb)
        {
            base.Wypisz(lb); //wywołanie metody Write Z KLASY BAZOWEJ 
            lb.Items.Add("Waga produktu w gramach: " + waga);
            lb.Items.Add("Nazwa produktu: " + nazwa);
            lb.Items.Add("Materiał wykonania: " + materiałWykonania);
            lb.Items.Add("Czy produkt jest przyjazny środowisku: " + przyjazneŚrodowisku);
            lb.Items.Add("Do czego służy: " + doCzegoSłuży);
            lb.Items.Add("Szczotka dostępna w takich kolorach:");
            lb.Items.Add(odcienieSzczotki[0]);
            lb.Items.Add(odcienieSzczotki[1]);
            lb.Items.Add(odcienieSzczotki[2]);
            //NowyProdukt();
        }
        public override void Wypisz(ListBox lb,PictureBox pb)
        {
            base.Wypisz(lb,pb); //wywołanie metody Write Z KLASY BAZOWEJ 
            lb.Items.Add("Waga produktu w gramach: " + waga);
            lb.Items.Add("Nazwa produktu: " + nazwa);
            lb.Items.Add("Materiał wykonania: " + materiałWykonania);
             lb.Items.Add("Czy produkt jest przyjazny środowisku: " + przyjazneŚrodowisku+PrzyjazneŚrodowisku());
            lb.Items.Add("Do czego służy: " + doCzegoSłuży);
            lb.Items.Add("Szczotka dostępna w takich kolorach:");
            lb.Items.Add(odcienieSzczotki[0]);
            lb.Items.Add(odcienieSzczotki[1]);
            lb.Items.Add(odcienieSzczotki[2]);
            //Uczulenie();
            NowyProdukt();
        }
        public override void WritePhotoToFile(string fullFileName)
        {
            image.Save(fullFileName, ImageFormat.Bmp);
        }
        //Definicja metody wirtualnej ReadPhotoFromFile
        public override void ReadPhotoFromFile(string fullFileName)
        {
            image = (Bitmap)Image.FromFile(fullFileName);
        }

        private int PrzyjazneŚrodowisku()
        {
            if (przyjazneŚrodowisku == true)
            {
                MessageBox.Show("Produkt został wykonany z ekologicnzych materiałów!", "Przyjazne środowisku!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return 0;
        }
        public static bool SetTestowanyDermatologicznie(string s)
        {
            if (s == "tak") return true;
            else return false;
        }
        public static AkcesoriaKosmetyczne operator ==(AkcesoriaKosmetyczne kosmetyk1, AkcesoriaKosmetyczne kosmetyk2)
        {
            AkcesoriaKosmetyczne wynik = new AkcesoriaKosmetyczne();
            TextBox textBox1 = new TextBox();
            //int ilosc=Convert.ToInt32(textBox1.Text);
            
            wynik.waga = (kosmetyk1.waga) + kosmetyk2.waga;
            return wynik;
        }
        public static AkcesoriaKosmetyczne operator !=(AkcesoriaKosmetyczne kosmetyk1, AkcesoriaKosmetyczne kosmetyk2)
        {
            ListBox listBox1 = new ListBox();
            AkcesoriaKosmetyczne wynik = new AkcesoriaKosmetyczne();
            TextBox textBox1 = new TextBox();
            
            wynik.waga = kosmetyk1.waga + kosmetyk2.waga;
            listBox1.Text = "Ceny produktów są różne, kwota do zapłaty wynosi: "+wynik;

            return wynik;
        }
        public static AkcesoriaKosmetyczne operator +(AkcesoriaKosmetyczne kosmetyk1, AkcesoriaKosmetyczne kosmetyk2)
        {
            AkcesoriaKosmetyczne suma = new AkcesoriaKosmetyczne();
            ListBox listBox1 = new ListBox();
            TextBox textBox1 = new TextBox();
            
            suma.waga = (kosmetyk1.waga) + kosmetyk2.waga;
            listBox1.Text = "Ceny produktów są różne, kwota do zapłaty wynosi: " + suma;
            return suma;
        }



        /* public void ZaładujZdjęcieKosmetyk(PictureBox pictureBox2)
         {
             string fileName = "akcesoria1.jpg";
             string path = Path.Combine(Environment.CurrentDirectory, fileName);
             image2 = new Bitmap(path);
             pictureBox2.Image = image2;
             pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
         }
        */


        //deklarowanie zmiennych w kasie AkcesoriaKosmetyczne
        /*internal class AkcesoriaKosmetyczne
        {

            int numer;
            string nazwaMarki;
            string rodzajKosmetyku;
            int waga;
            float cena;
            int kodProduktu;
            string działanie;
            string materiałWykonania;
            bool przyjazneŚrodowisku;
            string dlaKogo;
            int liczbaKosmetykow = 0;
            ArrayList odcienieSzczotki = new ArrayList();


            public AkcesoriaKosmetyczne()
            {
                liczbaKosmetykow += 1;
                this.numer = liczbaKosmetykow;
                this.nazwaMarki = "Tangle teezer";
                this.rodzajKosmetyku = "Sczotka do włosów";
                this.waga = 90;
                this.cena = 39.99f;
                this.kodProduktu = 189;
                this.działanie = "Dobrze rozczesuje włosy, masuje skórę głowy";
                this.materiałWykonania = "Tworzywo sztuczne";
                this.przyjazneŚrodowisku = true;
                this.dlaKogo = "Włosy normalne";
                this.odcienieSzczotki.Add("czerwony");
                this.odcienieSzczotki.Add("różowy");
                this.odcienieSzczotki.Add("fioletowy");

            }
            public AkcesoriaKosmetyczne(int numer, string nazwaMarki, string rodzajKosmetyku, int waga, float cena, int kodProduktu, string działanie, bool testowanyDermatologicznie, string materiałWykonania, bool przyjazneŚrodowisku, string dlaKogo)
            {
                liczbaKosmetykow += 1;
                this.numer = liczbaKosmetykow;
                this.nazwaMarki = "Tangle teezer";
                this.rodzajKosmetyku = "Sczotka do włosów";
                this.waga = 90;
                this.cena = 39.99f;
                this.kodProduktu = 189;
                this.działanie = "Dobrze rozczesuje włosy, masuje skórę głowy";
                this.materiałWykonania = "Tworzywo sztuczne";
                this.przyjazneŚrodowisku = true;
                this.dlaKogo = "Włosy normalne";
                this.odcienieSzczotki.Add("czerwony");
                this.odcienieSzczotki.Add("różowy");
                this.odcienieSzczotki.Add("fioletowy");
            }
            public AkcesoriaKosmetyczne(AkcesoriaKosmetyczne produkt)
            {
                liczbaKosmetykow += 1;
                this.numer = produkt.liczbaKosmetykow;
                this.nazwaMarki = produkt.nazwaMarki;
                this.rodzajKosmetyku = produkt.rodzajKosmetyku;
                this.waga = produkt.waga;
                this.cena = produkt.cena;
                this.kodProduktu =produkt.kodProduktu;
                this.działanie = produkt.działanie;
                this.materiałWykonania = produkt.materiałWykonania;
                this.przyjazneŚrodowisku = produkt.przyjazneŚrodowisku;
                this.dlaKogo = produkt.dlaKogo;
                this.odcienieSzczotki.Add("czerwony");
                this.odcienieSzczotki.Add("różowy");
                this.odcienieSzczotki.Add("fioletowy");
            }
            //dodanie do listy poszczególnych produktów
            public void Wypisz(ListBox lblAkcesoria)
            {
                var kosmetyk = new Kosmetyk();
                lblAkcesoria.Items.Add("Numer artykułu (kolejno):\t" + numer);
                lblAkcesoria.Items.Add("Nazwa marki:" + nazwaMarki);
                lblAkcesoria.Items.Add("Rodzaj kosmetyku:" + rodzajKosmetyku);
                lblAkcesoria.Items.Add("Waga produktu: " + waga);
                lblAkcesoria.Items.Add("Cena produktu: " + cena);
                lblAkcesoria.Items.Add("Kod produktu: " + kodProduktu + kosmetyk.NowyProdukt());//metoda z klasy kosmetyki
                lblAkcesoria.Items.Add("Działanie: " + działanie);
                lblAkcesoria.Items.Add("Materiał wykonania: " + materiałWykonania);
                lblAkcesoria.Items.Add("Przyjazne środowisku: " + przyjazneŚrodowisku+PrzyjazneŚrodowisku());//dodanie metoda, która wyświetla komunikat, czy produkt jest ekologiczny
                lblAkcesoria.Items.Add("Dla kogo przeznaczony jest produkt: " + dlaKogo);
                 lblAkcesoria.Items.Add("Dostępne kolory produktu:" + odcienieSzczotki[0]);
               lblAkcesoria.Items.Add("Dostępne kolory produktu:" + odcienieSzczotki[1]);
                lblAkcesoria.Items.Add("Dostępne kolory produktu:" + odcienieSzczotki[2]);
            }
        */
        //stworzenie metody odpowiadającej za sprawdzenie, czy produkt jest ekologiczny

    }
}
