using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace naocene////
{
    public struct NFZ
    {
        public string imie;
        public string nazwa_badania;
        public DateTime data_badania;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }
        public void SetMyCustomFormat()
        {//
            DateTime time = DateTime.Now;
            DateTime day = DateTime.Today;
            aktualny_czas.Format = DateTimePickerFormat.Custom;
            aktualny_czas.CustomFormat = "HH:mm";
            aktualny_czas.Value = time;
            aktualna_data.Value = day;//
        }
        private void odswiezacz_Tick(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }
        /// <summary>
        /// 
        /// </summary>
        NFZ pacjent = new NFZ();
        private void zatwierdz_Click(object sender, EventArgs e)
        { //nadawanie wartosci strukturom
            pacjent.imie = imie_box.Text;
            pacjent.nazwa_badania = nazwa_badania_box.Text;
            pacjent.data_badania = data_badania_pick.Value;

            pacjent_imie.Text = pacjent.imie;
            pacjent_nazwa_badania.Text = pacjent.nazwa_badania;
            pacjent_data.Value = pacjent.data_badania;

            kolejka.Enqueue(pacjent); // dodawanie do kolejki

            var wypisanie = kolejka.ToArray()[kolejka.ToArray().Length -1]; //pobiera
            if (kolejka.ToArray().Length == 2)
            {
                var poprzednie = kolejka.ToArray()[kolejka.ToArray().Length - 2];
                pop_imie.Text = $"{poprzednie.imie} \n{poprzednie.nazwa_badania} \n{poprzednie.data_badania.ToString("d.MM.yyyy")}\n \n";
                naj_imie.Text = $"{wypisanie.imie} \n{wypisanie.nazwa_badania} \n{wypisanie.data_badania.ToString("d.MM.yyyy")}\n \n";
            }
            else if (kolejka.ToArray().Length > 2)
            {
                prz_imie.Text += $"{wypisanie.imie} \n{wypisanie.nazwa_badania} \n{wypisanie.data_badania.ToString("d.MM.yyyy")}\n \n";
            }
            else
            {
                naj_imie.Text = $"{wypisanie.imie} \n{wypisanie.nazwa_badania} \n{wypisanie.data_badania.ToString("d.MM.yyyy")}\n \n";
            }

        }

        Queue<NFZ> kolejka = new Queue<NFZ>();

        private void zapisz_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // zapisywanie do pliku
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "4 z plusem dla mnie.txt")))
            {
                foreach (var line in kolejka.ToArray())
                    outputFile.WriteLine($"{line.imie} \n{line.nazwa_badania} \n{line.data_badania.ToString("d.MM.yyyy")}\n \n");
            }
        }
    }
        }
    

