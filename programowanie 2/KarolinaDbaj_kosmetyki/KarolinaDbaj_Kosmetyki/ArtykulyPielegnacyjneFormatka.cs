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
    public partial class ArtykulyPielegnacyjneFormatka : Form
    {
        public ArtykulyPielegnacyjneFormatka()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           // ArtykulyPielegnacyjne artykuł1 = new ArtykulyPielegnacyjne();
            //artykuł1.Wypisz(lblPielegnacja);

            //ArtykulyPielegnacyjne artykuł2 = new ArtykulyPielegnacyjne (2,"The ordinary", "Krem do twarzy", 100, 19.99f, 234, "Dla wszystkich typów cery.", true,"Nawilża skórę twarzy.", 6, true);
           // artykuł2.Wypisz(lblPielegnacja);

           // ArtykulyPielegnacyjne artykuł3 = new ArtykulyPielegnacyjne ();
            //artykuł3.Wypisz(lblPielegnacja);
            ArtykulyPielegnacyjne artykuly = new ArtykulyPielegnacyjne();
            
            lblRabat.Text = "Teraz możesz uzyskać rabat \n na nasze kosmetyki!";
        }

        private void ArtykulyPielegnacyjneFormatka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kosmetyk = new ArtykulyPielegnacyjne();
            kosmetyk.ObliczanieRabatu(lblRabat);
        }
       
    }
}
