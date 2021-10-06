using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naocene
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }
        public void SetMyCustomFormat()
        {
            DateTime time = DateTime.Now;
            DateTime day = DateTime.Today;
            aktualny_czas.Format = DateTimePickerFormat.Custom;
            aktualny_czas.CustomFormat = "HH:mm";
            aktualny_czas.Value = time;
            aktualna_data.Value = day;
        }
        private void odswiezacz_Tick(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }
        struct NFZ
        {
            public string imie;
            public string nazwa_badania;
            public DateTime data_badania;
        }
        NFZ pacjent;
        private void zatwierdz_Click(object sender, EventArgs e)
        {
            imie_box.Text = pacjent.imie;
            nazwa_badania_box.Text = pacjent.nazwa_badania;
            data_badania_pick.Value = pacjent.data_badania;

            pacjent_imie.Text = pacjent.imie;
            pacjent_nazwa_badania.Text = pacjent.nazwa_badania;
            pacjent_data.Value = pacjent.data_badania;
        }
        
        























        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void aktualny_czas_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
