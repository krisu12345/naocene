
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
            this.aktualny_czas.ValueChanged += new System.EventHandler(this.aktualny_czas_ValueChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

