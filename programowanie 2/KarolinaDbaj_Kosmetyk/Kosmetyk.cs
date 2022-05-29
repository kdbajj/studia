using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyk
{
    abstract class Kosmetyk
    {
        private int number;
        private string nazwa;
        Bitmap imageBitmap;

        public Kosmetyk(string nazwa, Bitmap imageBitmap)
        {
            number = Form1.number;
            Form1.number++;
            this.nazwa = nazwa;
            this.imageBitmap = imageBitmap;
        }

        public virtual void Write(ListBox listBox)
        {
            listBox.Items.Add($"Numer kosmetyku: {number}");
            listBox.Items.Add($"Nazwa kosmetyku: {nazwa}");
        }

        public static void LoadImageDialog(PictureBox pb)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap f = new Bitmap(open.OpenFile());
                pb.Image = f;
            }
        }
    }
}
