using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        {
            pacjent.imie = imie_box.Text;
            pacjent.nazwa_badania = nazwa_badania_box.Text;
            pacjent.data_badania = data_badania_pick.Value;

            pacjent_imie.Text = pacjent.imie;
            pacjent_nazwa_badania.Text = pacjent.nazwa_badania;
            pacjent_data.Value = pacjent.data_badania;

            kolejka.Enqueue(pacjent); // dodawanie do kolejki

            var wypisanie = kolejka.ToArray()[kolejka.ToArray().Length -1]; //pobiera
            if (kolejka.ToArray().Length > 1) {
                var poprzednie = kolejka.ToArray()[kolejka.ToArray().Length - 2];
                pop_imie.Text = $"{poprzednie.imie} \n{poprzednie.nazwa_badania} \n{poprzednie.data_badania.ToString("d.MM.yyyy")}\n \n";
                naj_imie.Text = $"{wypisanie.imie} \n{wypisanie.nazwa_badania} \n{wypisanie.data_badania.ToString("d.MM.yyyy")}\n \n";
            }
            else
            {
                naj_imie.Text += $"{wypisanie.imie} \n{wypisanie.nazwa_badania} \n{wypisanie.data_badania.ToString("d.MM.yyyy")}\n \n";
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        Queue<NFZ> kolejka = new Queue<NFZ>();














        private void naj_imie_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        }
    

