using System;
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
        int numer;
        string nazwaMarki;
        string rodzajKosmetyku;
        public float cena;
        public int kodProduktu;
        bool testowanyDermatologicznie;
        string wykończenie;
        int trwałośćWMiesiącach;
        private DateTime dataZakupu;
        static int liczbaKosmetykow = 0;
        private int numerProduktu;
        private string odcień;
        Bitmap image;

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
            this.dataZakupu = DateTime.Now;
            //this.tak = true;
            //this.nie = false;
            //string value1 = tak.ToString();
            //string value2 = nie.ToString();
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
        public Kosmetyk(int numerProduktu, bool testowanyDermatologicznie)
        {

            this.numerProduktu = numerProduktu;
            this.testowanyDermatologicznie = testowanyDermatologicznie;

        }
        public Kosmetyk(int numer, string nazwaMarki, string rodzajKosmetyku, float cena, int numerProduktu,
            string odcień, bool testowanyDermatologicznie, string wykończenie, int trwałośćWMiesiącach)

        {
            this.numer = liczbaKosmetykow;
            this.nazwaMarki = nazwaMarki;
            this.rodzajKosmetyku = rodzajKosmetyku;

            this.cena = cena;
            this.kodProduktu = kodProduktu;

            this.testowanyDermatologicznie = testowanyDermatologicznie;
            this.wykończenie = wykończenie;
            this.trwałośćWMiesiącach = trwałośćWMiesiącach;
        }
        public Kosmetyk(string rodzajKosmetyku, string nazwaMarki, float cena, int numerProduktu, bool testowanyDermatologicznie, int trwałośćWMiesiącach, string wykończenie, DateTime dataZakupu)
        {
            numer += 1;
            this.rodzajKosmetyku = rodzajKosmetyku;
            this.nazwaMarki = nazwaMarki;
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



        public virtual void Wypisz(ListBox lb)//metoda wirtualna w klasie bazowej
        {
            lb.Items.Add("Numer kosmetyku(kolejno):\t" + numer);
            lb.Items.Add("Nazwa marki:" + nazwaMarki);
            lb.Items.Add("rodzaj kosmetyku:" + rodzajKosmetyku);

            lb.Items.Add("Cena produktu: " + cena);
            //lb.Items.Add("Kod produktu: " + kodProduktu + NowyProdukt());

            lb.Items.Add("Testowany dermatologicznie: " + (testowanyDermatologicznie ? "tak" : "nie"));
            lb.Items.Add("Wykończenie: " + wykończenie);
            lb.Items.Add("Trwałość (w miesiącach): " + trwałośćWMiesiącach);
            lb.Items.Add("Trwałość w latach: " + TrwałośćWLatach());
            lb.Items.Add("Data zakupu: " + dataZakupu);

        }

        ~Kosmetyk()
        {
            MessageBox.Show("Likwidacja obiektu klasy Kosmetyk.");
        }
        public float ObliczZniżkę(int liczbaProduktów)
        {

            //var kosmetyk = new Kosmetyk();
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
        public void ZaładujZdjęcie(PictureBox pictureBox1)
        {
            //PictureBox pictureBox = new PictureBox();
            string fileName = "kosmetyk.jpg";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            image = new Bitmap(path);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public static bool SetTestowanyDermatologicznie(string s)
        {
            if (s == "tak") return true;
            else return false;
        }
       
    }


}
