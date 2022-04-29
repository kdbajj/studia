using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyki
{

    class ArtykulyPielegnacyjne : Kosmetyk
    {
        int pojemność;
        string dlaKogo;
        bool wegańskie;
        string działanie;
        

        public ArtykulyPielegnacyjne() : base()
        {
            pojemność = 100;
            dlaKogo = "Dla wszystkich typów cery.";
            wegańskie = true;
            działanie = "Nawilża  i oczyszcza skórę twarzy.";
        }

        public ArtykulyPielegnacyjne(int numer, string nazwaMarki, string rodzajKosmetyku, int pojemność,
            float cena, int numerProduktu, string odcień, bool testowanyDermatologicznie, string wykończenie, 
            int trwałośćWMiesiącach, bool wegańskie,string dlaKogo, string działanie)
            : base( numer, nazwaMarki,  rodzajKosmetyku, cena, numerProduktu, 
            odcień, testowanyDermatologicznie, wykończenie,trwałośćWMiesiącach)
        {
            this.pojemność =100;
            this.dlaKogo="Każdy typ cery";
            this.wegańskie = true;
            this.działanie= "Nawilża i oczyszcza skórę twarzy.";
        }
        public ArtykulyPielegnacyjne(ArtykulyPielegnacyjne o):base(o)
        {

            this.pojemność = o.pojemność;
            this.dlaKogo =   o.dlaKogo;
            this.wegańskie = o.wegańskie;
            this.działanie = o.działanie;
        }
        public new void Wypisz(ListBox lblPielegnacja)
        {
            base.Wypisz(lblPielegnacja); //wywołanie metody Write Z KLASY BAZOWEJ (Person)
            lblPielegnacja.Items.Add("Pojemność: " + pojemność);
            lblPielegnacja.Items.Add("Dla kogo: " + dlaKogo);
            lblPielegnacja.Items.Add("Wegański produkt: " + wegańskie);
            lblPielegnacja.Items.Add("Działanie: " + działanie);
        }


        /*internal class ArtykulyPielegnacyjne
        {
            int numer;
            string nazwaMarki;
            string rodzajKosmetyku;
            int pojemność;
            float cena;
            int kodProduktu;
            string dlaKogo;
            bool testowanyDermatologicznie;
            string działanie;
            int trwałośćWMiesiącach;
            bool wegańskie;
            static int liczbaKosmetykow = 0;


            public ArtykulyPielegnacyjne()
            {
                liczbaKosmetykow += 1;
                this.numer = liczbaKosmetykow;
                this.nazwaMarki = "The ordinary";
                this.rodzajKosmetyku = "Krem do twarzy";
                this.pojemność = 100;
                this.cena = 45.99f;
                this.kodProduktu = 234;
                this.dlaKogo = "Dla wszystkich typów cery.";
                this.testowanyDermatologicznie = true;
                this.działanie = "Nawilża skórę twarzy.";
                this.trwałośćWMiesiącach = 6;
                this.wegańskie = true;
            }
            public ArtykulyPielegnacyjne(int numer, string nazwaMarki, string rodzajKosmetyku, int pojemność, float cena, int kodProduktu, string dlaKogo, bool testowanyDermatologicznie, string działanie, int trwałośćWMiesiącach, bool wegańskie)
            {
                liczbaKosmetykow += 1;
                this.numer = liczbaKosmetykow;
                this.nazwaMarki = "The ordinary";
                this.rodzajKosmetyku = "Krem do twarzy";
                this.pojemność = 100;
                this.cena = 19.99f;
                this.kodProduktu = 234;
                this.dlaKogo = "Dla wszystkich typów cery.";
                this.testowanyDermatologicznie = true;
                this.działanie = "Nawilża skórę twarzy.";
                this.trwałośćWMiesiącach = 6;
                this.wegańskie = true;

            }
            public ArtykulyPielegnacyjne(ArtykulyPielegnacyjne artykuł)
            {
                liczbaKosmetykow += 1;
                this.numer = liczbaKosmetykow;
                this.nazwaMarki = artykuł.nazwaMarki;
                this.rodzajKosmetyku = artykuł.rodzajKosmetyku;
                this.pojemność = artykuł.pojemność;
                this.cena = artykuł.cena;
                this.kodProduktu = artykuł.kodProduktu;
                this.dlaKogo = artykuł.dlaKogo;
                this.testowanyDermatologicznie = artykuł.testowanyDermatologicznie;
                this.działanie = artykuł.działanie;
                this.trwałośćWMiesiącach = artykuł.trwałośćWMiesiącach;
                this.wegańskie = artykuł.wegańskie;

            }
            public void Wypisz(ListBox lblPielegnacja)
            {

                var kosmetyk = new Kosmetyk();
                lblPielegnacja.Items.Add("Numer kosmetyku(kolejno):\t" + numer);
                lblPielegnacja.Items.Add("Nazwa marki:" + nazwaMarki);
                lblPielegnacja.Items.Add("Rodzaj kosmetyku:" + rodzajKosmetyku);
                lblPielegnacja.Items.Add("Pojemność: " + pojemność);
                lblPielegnacja.Items.Add("Cena produktu: " + cena);
                lblPielegnacja.Items.Add("Kod produktu: " + kodProduktu + kosmetyk.NowyProdukt());//metoda
                lblPielegnacja.Items.Add("Dla kogo: " + dlaKogo);
                lblPielegnacja.Items.Add("Testowany dermatologicznie: " + kosmetyk.Uczulenie());//metody
                lblPielegnacja.Items.Add("Działanie: " + działanie);
                lblPielegnacja.Items.Add("Trwałość (w miesiącach): " + trwałośćWMiesiącach);
                lblPielegnacja.Items.Add("Wegański produkt: " + wegańskie);

            }
        */
        public void ObliczanieRabatu(Label lblRabat)
        {

            var kosmetyk = new ArtykulyPielegnacyjne();
            float rabat;
            float cenaPoRabacie;
            if (kodProduktu > 200)
            {
                rabat = ((20 * cena) / 100);
                cenaPoRabacie = cena - rabat;
                lblRabat.Text = "Produkt nie jest nowy, \n więc rabat wynosi 10%, \n cena po zniżce to: " + kosmetyk.zaokraglij_2(cenaPoRabacie) + " zł!";
            }
            else
                rabat = ((10 * cena) / 100);
            cenaPoRabacie = cena - rabat;
            lblRabat.Text = "Produkt jest nowy,\n więc rabat wynosi 20%, \n  cena po zniżce to:" + kosmetyk.zaokraglij_2(cenaPoRabacie) + " zł!";
        }
        public float zaokraglij_2(float cenaPoRabacie)
        {
            var kosmetyk = new ArtykulyPielegnacyjne();
            float wynik = cenaPoRabacie * 100;
            int a = (int)wynik;
            wynik = (float)a / 100;
            return wynik;
        }

    }
}


