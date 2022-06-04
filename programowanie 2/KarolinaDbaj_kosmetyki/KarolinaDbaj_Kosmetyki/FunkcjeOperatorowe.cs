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
    public partial class FunkcjeOperatorowe : Form
    {
        public FunkcjeOperatorowe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kosmetyk1 = Convert.ToInt32(textBox1.Text);
            int kosmetyk2 = Convert.ToInt32(textBox2.Text);
           
            AkcesoriaKosmetyczne akcesoria1 = new AkcesoriaKosmetyczne(kosmetyk1);
            AkcesoriaKosmetyczne akcesoria2 = new AkcesoriaKosmetyczne(kosmetyk2);
            AkcesoriaKosmetyczne akcesoria=new AkcesoriaKosmetyczne();
            akcesoria = akcesoria1 + akcesoria2;
            akcesoria = akcesoria1 == akcesoria2;
            akcesoria = akcesoria1 !=akcesoria2;
            listBox1.Items.Add ( "Ilość zakupów to:" + akcesoria.waga);
            listBox1.Items.Add("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 formatkaGłówna = new Form1();
            formatkaGłówna.Show();
            this.Hide();
        }

        private void FunkcjeOperatorowe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
