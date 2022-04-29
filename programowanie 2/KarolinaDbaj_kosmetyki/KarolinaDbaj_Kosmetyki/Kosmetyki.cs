using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyki
{

    public class Kosmetyk
    {
        int numer;
        string nazwaMarki;
        string rodzajKosmetyku;
        public float cena;
        public int kodProduktu;
        bool testowanyDermatologicznie;
        string wykończenie;
        int trwałośćWMiesiącach;
        static int liczbaKosmetykow = 0;
        private int numerProduktu;
        private string odcień;

        public Kosmetyk()
        {
            liczbaKosmetykow += 1;
            this.numer = liczbaKosmetykow;
            this.nazwaMarki = "Maybelline";
            this.rodzajKosmetyku = "pomadka";
            this.cena = 36.99f;
            this.kodProduktu = 232;
            this.testowanyDermatologicznie = true;
            this.wykończenie = "matowe";
            this.trwałośćWMiesiącach = 12;

        }
        public Kosmetyk(int numer, string nazwaMarki, string rodzajKosmetyku, int pojemność, float cena, int numerProduktu, string odcień, bool testowanyDermatologicznie, string wykończenie, int trwałośćWMiesiącach, bool wegańskie)
        {
            liczbaKosmetykow += 1;
            this.numer = liczbaKosmetykow;
            this.nazwaMarki = "Maybelline";
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
            this.numer = liczbaKosmetykow;
            this.nazwaMarki = O.nazwaMarki;
            this.rodzajKosmetyku = O.rodzajKosmetyku;
           
            this.cena = O.cena;
            this.kodProduktu = O.kodProduktu;
            
            this.testowanyDermatologicznie = O.testowanyDermatologicznie;
            this.wykończenie = O.wykończenie;
            this.trwałośćWMiesiącach = O.trwałośćWMiesiącach;
            

        }

        public Kosmetyk(int numer, string nazwaMarki, string rodzajKosmetyku, float cena, int numerProduktu, string odcień, bool testowanyDermatologicznie, string wykończenie, int trwałośćWMiesiącach)
        {
            this.numer = numer;
            this.nazwaMarki = nazwaMarki;
            this.rodzajKosmetyku = rodzajKosmetyku;
            this.cena = cena;
            this.numerProduktu = numerProduktu;
            this.odcień = odcień;
            this.testowanyDermatologicznie = testowanyDermatologicznie;
            this.wykończenie = wykończenie;
            this.trwałośćWMiesiącach = trwałośćWMiesiącach;
        }

        private int TrwałośćWLatach()
        {
            int lata = trwałośćWMiesiącach / 12;
            if (lata != 1)
            {
                MessageBox.Show("Uwaga!", "Trwałość jest krótka(poniżej roku)", MessageBoxButtons.OK, MessageBoxIcon.Warning);//wyskakuje powiadomienie ostrzegające, że produkt nie ma długiego terminu przydatności

            }
            return lata;
        }
        public int NowyProdukt()
        {
            if (kodProduktu > 200)
            {
                MessageBox.Show("Jest to jeden z naszych najnowszych produktów w promocyjnej cenie.", "Okazja!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return 0;
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



        public virtual void Wypisz (ListBox lb)
        {
            lb.Items.Add("Numer kosmetyku(kolejno):\t" + numer);
            lb.Items.Add("Nazwa marki:" + nazwaMarki);
            lb.Items.Add("rodzaj kosmetyku:" + rodzajKosmetyku);
            
            lb.Items.Add("Cena produktu: " + cena);
            lb.Items.Add("Kod produktu: " + kodProduktu + NowyProdukt());
           
            lb.Items.Add("Testowany dermatologicznie: " + testowanyDermatologicznie + Uczulenie());
            lb.Items.Add("Wykończenie: " + wykończenie);
            lb.Items.Add("Trwałość (w miesiącach): " + trwałośćWMiesiącach);
            lb.Items.Add("Trwałość w latach: " + TrwałośćWLatach());

        }

        ~Kosmetyk()
        {
            MessageBox.Show("Likwidacja obiektu klasy Kosmetyk.");
        }
        public float ObliczZniżkę(int liczbaProduktów)
        {

            var kosmetyk = new Kosmetyk();
            var textBoxZniżka = new TextBox();
            var lblZniżka = new Label();
            textBoxZniżka.Text = "" + liczbaProduktów;
            float cenaKońcowa;

                int ilość = (Convert.ToInt32(textBoxZniżka.Text));

                if ((liczbaProduktów % 2) == 0)
                {
                    ilość = (liczbaProduktów / 2);
                    cenaKońcowa = ilość * cena;
                    lblZniżka.Text = "Cena za taką ilość produktów z wliczoną promocją to:" + cenaKońcowa;
                }
                else
                    ilość = (liczbaProduktów / 2) + 1;
                cenaKońcowa = ilość * cena;

                lblZniżka.Text = "Cena za taką ilość produktów z wliczoną promocją to:";

                return cenaKońcowa;
            

        }
    }
}
