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
            aktualny_czas.Format = DateTimePickerFormat.Custom;
            aktualny_czas.CustomFormat = "hh:mm";
            aktualny_czas.Value = time;
        }
        private void odswiezacz_Tick(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void aktualny_czas_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
