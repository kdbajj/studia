﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyk
{
    class ArtykulyPielegnacyjne : Kosmetyk
    {
        private string derm;
        public ArtykulyPielegnacyjne(string nazwa,Bitmap bitmap) : base(nazwa, imageBitmap)
        {
           
        }

        public override void Write(ListBox listBox)
        {
            base.Write(listBox);

            listBox.Items.Add($"To jest: {derm}");
        }
    }
}
