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
            this.dlaKogo = o.dlaKogo;
            this.wegańskie = o.wegańskie;
            this.działanie = o.działanie;
        }
        public override void Wypisz(ListBox lblPielegnacja)
        {
            base.Wypisz(lblPielegnacja); //wywołanie metody Write Z KLASY BAZOWEJ (Person)
            lblPielegnacja.Items.Add("Pojemność: " + pojemność);
            lblPielegnacja.Items.Add("Dla kogo: " + dlaKogo);
            lblPielegnacja.Items.Add("Wegański produkt: " + wegańskie);
            lblPielegnacja.Items.Add("Działanie: " + działanie);
            NowyProdukt();
        }
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


