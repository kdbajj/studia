using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KarolinaDbaj_Kosmetyki
{   
    //deklarowanie zmiennych w kasie AkcesoriaKosmetyczne
     internal class AkcesoriaKosmetyczne
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
        }
        //stworzenie metody odpowiadającej za sprawdzenie, czy produkt jest ekologiczny
        private int PrzyjazneŚrodowisku()
        {
            if (przyjazneŚrodowisku==true)
            {
                MessageBox.Show("Produkt został wykonany z ekologicnzych materiałów!", "Przyjazne środowisku!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return 0;
        }
    }
}