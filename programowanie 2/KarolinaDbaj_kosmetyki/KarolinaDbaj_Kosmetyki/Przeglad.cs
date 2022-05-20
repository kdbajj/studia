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
    public partial class Przeglad : Form
    {
        public Przeglad()
        {
            InitializeComponent();
        }

        private void Przeglad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
