using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyki
{

    class ArtykulyPielegnacyjne : Kosmetyk
    {

        string nazwa;
        int pojemność;
        string dlaKogo;
        bool wegańskie;
        string działanie;
        float cena;

        public ArtykulyPielegnacyjne() : base()
        {

            nazwa = "Żel myjący do twarzy";
            pojemność = 100;
            dlaKogo = "Dla wszystkich typów cery.";
            wegańskie = true;
            działanie = "Nawilża  i oczyszcza skórę twarzy.";
        }

        /*public ArtykulyPielegnacyjne(int numer, string nazwaMarki, string rodzajKosmetyku, int pojemność,
            float cena, int numerProduktu, string odcień, bool testowanyDermatologicznie, string wykończenie, 
            int trwałośćWMiesiącach, bool wegańskie,string dlaKogo, string działanie)
            : base( numer, nazwaMarki,  rodzajKosmetyku, cena, numerProduktu, 
            odcień, testowanyDermatologicznie, wykończenie,trwałośćWMiesiącach)
        {   
            
            this.pojemność = pojemność;
            this.dlaKogo=dlaKogo;
            this.wegańskie = wegańskie;
            this.działanie = działanie;
        }
        */
        public ArtykulyPielegnacyjne(int numerProduktu, string nazwa, int pojemność, float cena,
            bool wegańskie, string dlaKogo, string działanie, Bitmap image,
            bool testowanyDermatologicznie, string marka)
            : base(cena, marka, numerProduktu, testowanyDermatologicznie, image)
        {
            //this.numer = numer;
            //this.cena = cena;
            this.nazwa = nazwa;
            this.pojemność = pojemność;
            this.dlaKogo = dlaKogo;
            this.wegańskie = wegańskie;
            this.działanie = działanie;
        }
        public ArtykulyPielegnacyjne(ArtykulyPielegnacyjne o) : base(o)
        {
            this.nazwa = o.nazwa;
            this.pojemność = o.pojemność;
            this.dlaKogo = o.dlaKogo;
            this.wegańskie = o.wegańskie;
            this.działanie = o.działanie;
        }
        public override void Wypisz(ListBox lblPielegnacja)
        {
            base.Wypisz(lblPielegnacja); //wywołanie metody Write Z KLASY BAZOWEJ (Person)
            lblPielegnacja.Items.Add("Nazwa: " + nazwa);
            lblPielegnacja.Items.Add("Pojemność: " + pojemność + "g");
            lblPielegnacja.Items.Add("Dla kogo: " + dlaKogo);
            lblPielegnacja.Items.Add("Wegański produkt: " + wegańskie);
            lblPielegnacja.Items.Add("Działanie: " + działanie);
            //NowyProdukt();
        }
        public override void Wypisz(ListBox lb, PictureBox pb)
        {

            base.Wypisz(lb, pb); //wywołanie metody Write Z KLASY BAZOWEJ 
            base.Wypisz(lb); //wywołanie metody Write Z KLASY BAZOWEJ (Person)
            lb.Items.Add("Nazwa: " + nazwa);
            lb.Items.Add("Pojemność: " + pojemność + "g");
            lb.Items.Add("Dla kogo: " + dlaKogo);
            lb.Items.Add("Wegański produkt: " + wegańskie);
            lb.Items.Add("Działanie: " + działanie);
            Uczulenie();
            //NowyProdukt();

        }
        public void ObliczanieRabatu(Label lb, ComboBox cb)
        {
            //Label lb = new Label();
            //ComboBox cb = new ComboBox();
            cena = GetInputValidator.ConvertToFloat(cb.Text);
            float rabat;
            float cenaPoRabacie;
            if (GetInputValidator.ConvertToFloat(cb.Text) != 50)
            {
                rabat = ((20 * cena) / 100);
                cenaPoRabacie = cena - rabat;
                lb.Text = "Produkt nie jest w pojemności 50g, \n więc rabat wynosi 10%, \n cena po zniżce to: " + zaokraglij_2(cenaPoRabacie) + " zł!";
            }
            else if (GetInputValidator.ConvertToFloat(cb.Text) == 50)
            {
                rabat = ((10 * cena) / 100);
                cenaPoRabacie = cena - rabat;
                lb.Text = "Produkt jest w pojemności 50g,\n więc rabat wynosi 20%, \n  cena po zniżce to:" + zaokraglij_2(cenaPoRabacie) + " zł!";
            }

        }
        public float zaokraglij_2(float cenaPoRabacie)
        {

            float wynik = cenaPoRabacie * 100;
            int a = (int)wynik;
            wynik = (float)a / 100;
            return wynik;
        }
        /* public override void WriteToFile(StreamWriter sw)
         {
             sw.WriteLine("A"); //pierwsza linia (pomocnicza) do oznaczenia, że dalej
                                //zapisane są pola obiektu klasy Artykuły Pielegnacyjne
             sw.WriteLine(numerProduktu);
             sw.WriteLine(nazwa);
             sw.WriteLine(pojemność);
             sw.WriteLine(cena);
             sw.WriteLine(wegańskie);
             sw.WriteLine(dlaKogo);
             sw.WriteLine(działanie);
             sw.WriteLine(testowanyDermatologicznie);
             sw.WriteLine(marka);

         }

         //Definicja metody wirtualnej wczytującej wartości pól obiektu klasy Student z pliku tekstowego
         public override void ReadFromFile(StreamReader sr)
         {
            // numerProduktu = Convert.ToInt32(sr.ReadLine());//
             nazwa = sr.ReadLine();
             pojemność = Convert.ToInt32(sr.ReadLine());
           //  cena = GetInputValidator.ConvertToFloat(sr.ReadLine());//
             wegańskie = AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(sr.ReadLine());
             dlaKogo = sr.ReadLine();
             działanie = sr.ReadLine();
           //  testowanyDermatologicznie = AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(sr.ReadLine());
             marka = sr.ReadLine();
         }
         //Definicja metody wirtualnej WritePhotoToFile
         //public override void WritePhotoToFile(string fullFileName)
         //{
         //image.Save(fullFileName, ImageFormat.Bmp);
         //}
         //Definicja metody wirtualnej ReadPhotoFromFile
         //public override void ReadPhotoFromFile(string fullFileName)
         //{
         //  image = (Bitmap)Image.FromFile(fullFileName);
         /
        /}

        */
        public override void WriteToFile(StreamWriter streamWriter)
        {
            streamWriter.WriteLine("--------------------");
            streamWriter.WriteLine("Artykuły pielęgnacyjne");

            base.WriteToFile(streamWriter);
            streamWriter.WriteLine(nazwa);
            streamWriter.WriteLine(pojemność);
            streamWriter.WriteLine(wegańskie);
            streamWriter.WriteLine(dlaKogo);
            streamWriter.WriteLine(działanie);
            streamWriter.WriteLine(marka);

            streamWriter.WriteLine("");
        }

        public override void ReadFromFile(List<string> stringList)
        {
            try
            {
                base.ReadFromFile(stringList);
                nazwa = stringList[9];
                pojemność = Convert.ToInt32(stringList[10]);
                wegańskie = AkcesoriaKosmetyczne.SetTestowanyDermatologicznie(stringList[11]);
                dlaKogo = stringList[12];
                działanie = stringList[13];
                marka = stringList[14];
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                MessageBox.Show($"Błąd przy wczytywaniu pliku!\n\n Kod błędu {e}");
            }


        }
    }
}

