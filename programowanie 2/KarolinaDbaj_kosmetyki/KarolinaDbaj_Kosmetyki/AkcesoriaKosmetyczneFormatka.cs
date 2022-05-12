using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyki
{
    public partial class AkcesoriaKosmetyczneFormatka : Form
    {
        public AkcesoriaKosmetyczneFormatka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AkcesoriaKosmetyczne produkt1 = new AkcesoriaKosmetyczne();
            //produkt1.Wypisz(lblAkcesoria);

            //AkcesoriaKosmetyczne produkt2 = new AkcesoriaKosmetyczne(2,"Tangle teezer", "Sczotka do włosów", 90, 39.99f, 189, "Dobrze rozczesuje włosy, masuje skórę głowy", true, "Tworzywo sztuczne", true, "Włosy normalne");
            // produkt2.Wypisz(lblAkcesoria);

            //AkcesoriaKosmetyczne produkt3 = new AkcesoriaKosmetyczne();
            //produkt3.Wypisz(lblAkcesoria);
            AkcesoriaKosmetyczne artykuly = new AkcesoriaKosmetyczne();
            artykuly.Wypisz(lblAkcesoria);
            lblRabat2.Text = "Teraz możesz uzyskać rabat \n na nasze kosmetyki!";
        }

        private void AkcesoriaKosmetyczneFormatka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            var kosmetyk = new ArtykulyPielegnacyjne();
            kosmetyk.ObliczanieRabatu(lblRabat2);
        }   
    }
}
