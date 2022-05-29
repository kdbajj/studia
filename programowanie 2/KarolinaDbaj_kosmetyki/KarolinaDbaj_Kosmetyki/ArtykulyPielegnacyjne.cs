﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        public ArtykulyPielegnacyjne(int numerProduktu, string nazwa, int pojemność,
            bool wegańskie, string dlaKogo, string działanie, Bitmap image, bool testowanyDermatologicznie)
            : base(numerProduktu, testowanyDermatologicznie, image)
        {
            //this.numer = numer;
            this.nazwa = nazwa;
            this.pojemność = pojemność;
            this.dlaKogo = dlaKogo;
            this.wegańskie = wegańskie;
            this.działanie = działanie;
        }
        public ArtykulyPielegnacyjne(ArtykulyPielegnacyjne o):base(o)
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
            lblPielegnacja.Items.Add("Pojemność: " + pojemność+"g");
            lblPielegnacja.Items.Add("Dla kogo: " + dlaKogo);
            lblPielegnacja.Items.Add("Wegański produkt: " + wegańskie);
            lblPielegnacja.Items.Add("Działanie: " + działanie);
            NowyProdukt();
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
            NowyProdukt();
        }
        public void ObliczanieRabatu(Label lblRabat)
        {
            float rabat;
            float cenaPoRabacie;
            if (pojemność != 50)
            {
                rabat = ((20 * cena) / 100);
                cenaPoRabacie = cena - rabat;
                lblRabat.Text = "Produkt nie jest w pojemności 50g, \n więc rabat wynosi 10%, \n cena po zniżce to: " + zaokraglij_2(cenaPoRabacie) + " zł!";
            }
            else
                rabat = ((10 * cena) / 100);
            cenaPoRabacie = cena - rabat;
            lblRabat.Text = "Produkt jest w pojemności 50 g,\n więc rabat wynosi 20%, \n  cena po zniżce to:" + zaokraglij_2(cenaPoRabacie) + " zł!";
        }

        public float zaokraglij_2(float cenaPoRabacie)
        {
           
            float wynik = cenaPoRabacie * 100;
            int a = (int)wynik;
            wynik = (float)a / 100;
            return wynik;
        }

    }
}


