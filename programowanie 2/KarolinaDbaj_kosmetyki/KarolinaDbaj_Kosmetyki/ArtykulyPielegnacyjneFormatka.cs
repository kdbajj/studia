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
            ArtykulyPielegnacyjne artykuly = new ArtykulyPielegnacyjne();
            artykuly.Wypisz(lblPielegnacja);
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
