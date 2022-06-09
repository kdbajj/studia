using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolinaDbaj_Kosmetyki
{
    public partial class Przeglad : Form
    {

        public static int currentIndex = -1;

        public Przeglad()
        {
            InitializeComponent();
            //labelInfo.Text = "";
            currentIndex = -1;
            UpdateButtons();

        }
        //Przeglad przeglad1 = new Przeglad();
        // Przeglad przeglad = new Przeglad();

        private int indexStart; // wielkość listy Program.Transactions
        private int index; // aktualny wybrany index z listy Program.Transactions

        AkcesoriaKosmetyczneFormatka akcesoria = new AkcesoriaKosmetyczneFormatka(); // OBIEKT formatki do dodawania studentów do listy
        ArtykulyPielegnacyjneFormatka artykuly = new ArtykulyPielegnacyjneFormatka(); // OBIEKT formatki do dodawania wykładowców do listy
        private void UpdateButtons()
        {
            if (currentIndex == 0) //jeżeli wyświetlamy pierwszy element na liście
                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (currentIndex >= Form1.kosmetyki.Count - 1) //jeżeli wyświetlamy ostatni element na liście
                button2.Enabled = false;
            else
                button2.Enabled = true;
            if (currentIndex < 0) //nic nie wyświetlamy
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void Przeglad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Przeglad_Load(object sender, EventArgs e)
        {

            indexStart = Form1.kosmetyki.Count - 1;
            index = indexStart;
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            currentIndex--;
            listBox1.Items.Clear();
            Form1.kosmetyki[currentIndex].Wypisz(listBox1, pictureBox2);
            UpdateButtons();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            currentIndex++;

            listBox1.Items.Clear();
            Form1.kosmetyki[currentIndex].Wypisz(listBox1, pictureBox2);
            UpdateButtons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.kosmetyki.Count > 0) //jeżeli lista nie jest pusta
            {
                currentIndex = 0; //wyświetlamy pierwszy obiekt
                listBox1.Items.Clear();
                Form1.kosmetyki[currentIndex].Wypisz(listBox1, pictureBox2);
                UpdateButtons();
            }
            else
                MessageBox.Show("Lista jest pusta!");
        }
        private void Przeglad_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox2.Image = null;
            //labelInfo.Text = "";
            currentIndex = -1;
            UpdateButtons();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 formatkaGłówna = new Form1();
            formatkaGłówna.Show();
            this.Hide();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {

        }
        private void button4_Click_2(object sender, EventArgs e)
        {

            if (Form1.kosmetyki.Count == 0)
            {
                MessageBox.Show("Brak obiektu do usunięcia!");
                return;
            }

            Form1.kosmetyki.RemoveAt(index);
            UpdateButtons();
            listBox1.Items.Clear();
            pictureBox2.Image = null;
            MessageBox.Show("Pomyślnie usunięto obiekt!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ///float kosmetyk1 = GetInputValidator.ConvertToFloat(textBox1.Text);//metoda obliczająca dla wszystkich obiektów z listy
           // float kosmetyk2 = GetInputValidator.ConvertToFloat(textBox2.Text);
            float temp1 = GetInputValidator.ConvertToFloat(textBox1.Text);
            float temp2 = GetInputValidator.ConvertToFloat(textBox2.Text);

            if (temp1 == -1 || temp2 == -1)
            {
                return;
            }
            AkcesoriaKosmetyczne produkt1;
            AkcesoriaKosmetyczne produkt2 = new AkcesoriaKosmetyczne(temp1);
            AkcesoriaKosmetyczne produkt3 = new AkcesoriaKosmetyczne(temp2);

            produkt1 = produkt2 + produkt3;

            label3.Text = ($"Wydasz: {produkt1.cena} PLN");
            //listBox1.Items.Add("");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mamy promocję dla stałych klientów, szczegóły");
            listBox1.Items.Add("sprawdzisz na zakładce 'oferty specjalne' :) ");
            //listBox1.Items.Add("");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik tekstowy|*.txt";
            saveFileDialog.Title = "Podaj nazwę pliku do zapisu danych";

            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                foreach (Kosmetyk kosmetyk in Form1.kosmetyki)
                {
                    kosmetyk.WriteToFile(streamWriter);
                }
                streamWriter.Close();
            }
            /* string pathPhotos = textBox1.Text;
             bool exists = System.IO.Directory.Exists(pathPhotos);
             if (!exists)
                 System.IO.Directory.CreateDirectory(pathPhotos);
             SaveFileDialog sfd = new SaveFileDialog(); //okno dialogowe do wyboru pliku do zapisu
             sfd.Filter = "Plik tekstowy|*.txt";
             sfd.Title = "Podaj nazwę pliku do zapisu danych osób";
             sfd.ShowDialog();
             if (sfd.FileName != "")
             {
                 StreamWriter sw = new StreamWriter(sfd.FileName);
                 for (int i = 0; i < Form1.kosmetyki.Count; i++) //dla każdego obiektu na liście list
                 {
                     Form1.kosmetyki[i].WriteToFile(sw); //wywołaj odpowiednią wersję metody (wirtualnej)
                                                   //zapisującej do pliku
                     Form1.kosmetyki[i].WritePhotoToFile(pathPhotos + "//" + i + ".bmp"); //wywołaj metodę zapisującą
                                                                                    //zdjęcie do katalogu
                 }
                 sw.Close();*/

        }
        string plik = "testowy.txt";

        private void button8_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Plik tekstowy|*.txt";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                List<string> lineOfText = new List<string>();

                string line;
                bool first = true;
                bool temp1 = false;
                bool temp2 = false;
                bool temp3 = false;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (first)
                    {
                        first = false; continue;
                    }

                    if (line == "")
                    {
                        temp1 = false;
                        if (temp2)
                        {
                            AkcesoriaKosmetyczne akcesoria = new AkcesoriaKosmetyczne();
                            akcesoria.ReadFromFile(lineOfText);
                            Form1.kosmetyki.Add(akcesoria);

                            lineOfText.Clear();
                        }
                    }

                    if (line == "")
                    {
                        temp1 = false;
                        if (temp3)
                        {
                            ArtykulyPielegnacyjne artykuly = new ArtykulyPielegnacyjne();
                            artykuly.ReadFromFile(lineOfText);

                            Form1.kosmetyki.Add(artykuly);

                            lineOfText.Clear();
                        }
                    }

                    if (line == "Artykuły pielęgnacyjne")
                    {
                        temp1 = true;
                        temp2 = true;
                        temp3 = false;
                    }

                    if (line == "Akcesoria kosmetyczne")
                    {
                        temp1 = true;
                        temp2 = false;
                        temp3 = true;
                    }

                    if (temp1 && temp2)
                    {
                        lineOfText.Add(line);
                    }

                    if (temp1 && temp3)
                    {
                        lineOfText.Add(line);
                    }


                    //lineOfText.Add(line);


                }
                currentIndex = Form1.kosmetyki.Count - 1;
                index = currentIndex;                 
                //foreach (Kosmetyk a in Form1.kosmetyki)
                //    a.Wypisz(listBox1);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Form1.kosmetyki.Count == 0) return;
            Form1.kosmetyki[Form1.kosmetyki.Count-1].Wypisz(listBox1,pictureBox2);

        }
    }
}