
namespace naocene
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imie = new System.Windows.Forms.Label();
            this.nazwa_badania = new System.Windows.Forms.Label();
            this.data_badania_pick = new System.Windows.Forms.DateTimePicker();
            this.data_badania = new System.Windows.Forms.Label();
            this.imie_box = new System.Windows.Forms.TextBox();
            this.nazwa_badania_box = new System.Windows.Forms.TextBox();
            this.aktualna_data = new System.Windows.Forms.DateTimePicker();
            this.aktualny_czas = new System.Windows.Forms.DateTimePicker();
            this.odswiezacz = new System.Windows.Forms.Timer(this.components);
            this.zatwierdz = new System.Windows.Forms.Button();
            this.pacjent_imie = new System.Windows.Forms.Label();
            this.pacjent_nazwa_badania = new System.Windows.Forms.Label();
            this.pacjent_data = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.naj_imie = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.naj_nazwa_badania = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Location = new System.Drawing.Point(192, 138);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(30, 15);
            this.imie.TabIndex = 0;
            this.imie.Text = "Imie";
            // 
            // nazwa_badania
            // 
            this.nazwa_badania.AutoSize = true;
            this.nazwa_badania.Location = new System.Drawing.Point(192, 179);
            this.nazwa_badania.Name = "nazwa_badania";
            this.nazwa_badania.Size = new System.Drawing.Size(87, 15);
            this.nazwa_badania.TabIndex = 1;
            this.nazwa_badania.Text = "Nazwa Badania";
            this.nazwa_badania.Click += new System.EventHandler(this.label1_Click);
            // 
            // data_badania_pick
            // 
            this.data_badania_pick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_badania_pick.Location = new System.Drawing.Point(323, 220);
            this.data_badania_pick.Name = "data_badania_pick";
            this.data_badania_pick.Size = new System.Drawing.Size(100, 23);
            this.data_badania_pick.TabIndex = 2;
            this.data_badania_pick.TabStop = false;
            // 
            // data_badania
            // 
            this.data_badania.AutoSize = true;
            this.data_badania.Location = new System.Drawing.Point(192, 226);
            this.data_badania.Name = "data_badania";
            this.data_badania.Size = new System.Drawing.Size(76, 15);
            this.data_badania.TabIndex = 3;
            this.data_badania.Text = "Data Badania";
            // 
            // imie_box
            // 
            this.imie_box.Location = new System.Drawing.Point(323, 130);
            this.imie_box.Name = "imie_box";
            this.imie_box.Size = new System.Drawing.Size(100, 23);
            this.imie_box.TabIndex = 4;
            // 
            // nazwa_badania_box
            // 
            this.nazwa_badania_box.Location = new System.Drawing.Point(323, 171);
            this.nazwa_badania_box.Name = "nazwa_badania_box";
            this.nazwa_badania_box.Size = new System.Drawing.Size(100, 23);
            this.nazwa_badania_box.TabIndex = 5;
            // 
            // aktualna_data
            // 
            this.aktualna_data.Enabled = false;
            this.aktualna_data.Location = new System.Drawing.Point(275, 30);
            this.aktualna_data.Name = "aktualna_data";
            this.aktualna_data.Size = new System.Drawing.Size(202, 23);
            this.aktualna_data.TabIndex = 6;
            // 
            // aktualny_czas
            // 
            this.aktualny_czas.Enabled = false;
            this.aktualny_czas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aktualny_czas.Location = new System.Drawing.Point(483, 30);
            this.aktualny_czas.Name = "aktualny_czas";
            this.aktualny_czas.Size = new System.Drawing.Size(95, 23);
            this.aktualny_czas.TabIndex = 7;
            // 
            // odswiezacz
            // 
            this.odswiezacz.Enabled = true;
            this.odswiezacz.Interval = 10000;
            this.odswiezacz.Tick += new System.EventHandler(this.odswiezacz_Tick);
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(323, 278);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(100, 23);
            this.zatwierdz.TabIndex = 8;
            this.zatwierdz.Text = "Dodaj wizyte";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // pacjent_imie
            // 
            this.pacjent_imie.AutoSize = true;
            this.pacjent_imie.Location = new System.Drawing.Point(599, 133);
            this.pacjent_imie.Name = "pacjent_imie";
            this.pacjent_imie.Size = new System.Drawing.Size(68, 15);
            this.pacjent_imie.TabIndex = 9;
            this.pacjent_imie.Text = "Imie klienta";
            // 
            // pacjent_nazwa_badania
            // 
            this.pacjent_nazwa_badania.AutoSize = true;
            this.pacjent_nazwa_badania.Location = new System.Drawing.Point(599, 171);
            this.pacjent_nazwa_badania.Name = "pacjent_nazwa_badania";
            this.pacjent_nazwa_badania.Size = new System.Drawing.Size(87, 15);
            this.pacjent_nazwa_badania.TabIndex = 10;
            this.pacjent_nazwa_badania.Text = "Nazwa badania";
            // 
            // pacjent_data
            // 
            this.pacjent_data.Enabled = false;
            this.pacjent_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pacjent_data.Location = new System.Drawing.Point(599, 218);
            this.pacjent_data.Name = "pacjent_data";
            this.pacjent_data.Size = new System.Drawing.Size(78, 23);
            this.pacjent_data.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dodany pacjent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Przyszły pacjent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Najbliższy pacjent";
            // 
            // naj_imie
            // 
            this.naj_imie.AutoSize = true;
            this.naj_imie.Location = new System.Drawing.Point(323, 407);
            this.naj_imie.Name = "naj_imie";
            this.naj_imie.Size = new System.Drawing.Size(51, 15);
            this.naj_imie.TabIndex = 16;
            this.naj_imie.Text = "naj_imie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Poprzedni pacjent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // naj_nazwa_badania
            // 
            this.naj_nazwa_badania.AutoSize = true;
            this.naj_nazwa_badania.Location = new System.Drawing.Point(323, 447);
            this.naj_nazwa_badania.Name = "naj_nazwa_badania";
            this.naj_nazwa_badania.Size = new System.Drawing.Size(38, 15);
            this.naj_nazwa_badania.TabIndex = 20;
            this.naj_nazwa_badania.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.naj_nazwa_badania);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.naj_imie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pacjent_data);
            this.Controls.Add(this.pacjent_nazwa_badania);
            this.Controls.Add(this.pacjent_imie);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.aktualny_czas);
            this.Controls.Add(this.aktualna_data);
            this.Controls.Add(this.nazwa_badania_box);
            this.Controls.Add(this.imie_box);
            this.Controls.Add(this.data_badania);
            this.Controls.Add(this.data_badania_pick);
            this.Controls.Add(this.nazwa_badania);
            this.Controls.Add(this.imie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label nazwa_badania;
        private System.Windows.Forms.DateTimePicker data_badania_pick;
        private System.Windows.Forms.Label data_badania;
        private System.Windows.Forms.TextBox imie_box;
        private System.Windows.Forms.TextBox nazwa_badania_box;
        private System.Windows.Forms.DateTimePicker aktualna_data;
        private System.Windows.Forms.DateTimePicker aktualny_czas;
        private System.Windows.Forms.Timer odswiezacz;
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.Label pacjent_imie;
        private System.Windows.Forms.Label pacjent_nazwa_badania;
        private System.Windows.Forms.DateTimePicker pacjent_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label naj_imie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label naj_nazwa_badania;
        private System.Windows.Forms.Label label10;
    }
}

