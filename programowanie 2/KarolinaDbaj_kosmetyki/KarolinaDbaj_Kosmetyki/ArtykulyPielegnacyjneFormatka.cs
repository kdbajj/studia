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
            lblRabat.Text = "Promocja! Jeśli kupisz produkt o pojemności 50 g \n otrzymasz rabat!";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ArtykulyPielegnacyjne artykuly = new ArtykulyPielegnacyjne();
            artykuly.Wypisz(lblPielegnacja);
           
        }

        private void ArtykulyPielegnacyjneFormatka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnUżytkownikPielegnacja_Click(object sender, EventArgs e)
        {
            var artykulyPielegnacyjne = new ArtykulyPielegnacyjne(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(comboBox2.SelectedItem), GetInputValidator.ConvertToFloat(textBox3.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, Kosmetyk.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()), textBox9.Text, Convert.ToInt32(textBox10.Text), Kosmetyk.SetTestowanyDermatologicznie(comboBox3.SelectedItem.ToString()), textBox11.Text, textBox12.Text);
            artykulyPielegnacyjne.Wypisz(lblPielegnacja);
            lblPielegnacja.Items.Add("");

        }


        private void btnkPielegnacja_Click(object sender, EventArgs e)
        {

            var artykul = new ArtykulyPielegnacyjne();
            artykul.ObliczanieRabatu(lblRabat);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var artykuł = new ArtykulyPielegnacyjne();
            artykuł.ObliczanieRabatu(lblRabat);
           
        }
    }
}
