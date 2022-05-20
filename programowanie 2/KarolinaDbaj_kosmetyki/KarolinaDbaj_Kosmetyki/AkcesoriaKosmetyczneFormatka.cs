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
            AkcesoriaKosmetyczne artykuly = new AkcesoriaKosmetyczne();
            artykuly.Wypisz(lblAkcesoria);
           
        }
        private void AkcesoriaKosmetyczneFormatka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
          
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //string[] odcienieSzczotki = comboBox3.Items.Cast<Object>().Select(item => item.ToString()).ToArray();

            var artykul1 = new AkcesoriaKosmetyczne(Convert.ToInt32(textBox1.Text), Kosmetyk.SetTestowanyDermatologicznie(comboBox1.SelectedItem.ToString()),Convert.ToInt32(textBox3.Text),textBox4.Text, Kosmetyk.SetTestowanyDermatologicznie(comboBox3.SelectedItem.ToString()),textBox6.Text);
           artykul1.Wypisz(lblAkcesoria);
            lblAkcesoria.Items.Add("");
          
         
        }
        private void AkcesoriaKosmetyczneFormatka_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
