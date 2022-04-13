using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzivnostC
{
    public partial class Menu : Form
    {
        public User user = new User();
        public Menu( User u)
        {
            
            InitializeComponent();
            this.user = u;
            SetProfileLabels();
           
            
        }

        public void adduser(User u) {
            user = u;
        }
        private void SetProfileLabels()
        {
            datajmenolabel.Text = user.Jmeno;
            dataprijmenilabel.Text = user.Prijmeni;
            labelEmailProfil.Text = user.Email;
           
            dataprumernyvydelek.Text = "coming soon...";
            

        }

        public void set_combo_box(bool typ)
            
        {
            comboBoxTyp.Items.Clear();
            var listP = TypController.nacistTypyPrijmu();
            var listV = TypController.nacistTypyVydaju();

            if (typ&& listP.Count>0)
            {
                foreach (string x in listP)
                {
                    comboBoxTyp.Items.Add(x);

                }
            }
            else
            { if (listV.Count > 0)
                {
                    foreach (string x in listV)
                    {
                        comboBoxTyp.Items.Add(x);

                    }
                }

            }


        }


        private void buttonUlozitfakturu_f_Click(object sender, EventArgs e)
        {
            if ((radioButtonPrijem.Checked||radioButtonVydaj.Checked)&& textBoxCastka_Faktura.Text.Length>0)
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    FakturaVystavena f = new FakturaVystavena(this.pathToFile, int.Parse(textBoxCastka_Faktura.Text), radioButtonPrijem.Checked, textBoxPoznamka.Text, comboBoxTyp.Text, int.Parse(textBoxEv_cislo.Text),Datum_Splatnosti_Textbox.Text);
                    f.Ulozit_do_db(this.user);
                    MessageBox.Show("Faktura byla uložená");
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Spatné vstupní údaje");

                }
                Cursor = Cursors.Default;



            }
        }

        private void Ulozenifaktury_menu_button_Click(object sender, EventArgs e)
        {
            tableProfil.Visible = false;
           
            FormularProUlozeniFaktury.Visible = true;
        }

        private void profilmenubutton_Click(object sender, EventArgs e)
        {
            tableProfil.Visible = true;
           
            FormularProUlozeniFaktury.Visible=false;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string pathToFile = "";
        private void Vybrat_soubor_Button_f_Click(object sender, EventArgs e)
        {
            openFileSkenFaktury.ShowDialog();
            if (openFileSkenFaktury.FileName.Contains(".pdf"))
            {
                this.pathToFile = openFileSkenFaktury.FileName;
            }
            else
            {
                MessageBox.Show("Soubor musí být ve formátu pdf");

                return;
            }        }

        private void tableProfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrehledyButton_Click(object sender, EventArgs e)
        {
           PrehledyF prehledy = new PrehledyF(user);
           prehledy.Show();
           
        }

        private void Ulozeni_faktur_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPřehledCastky_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void PrehledyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PridaniTypu pt = new PridaniTypu(); 
            pt.ShowDialog();
            if (radioButtonPrijem.Checked)
            {
                set_combo_box(true);
            }
            else
            {
                set_combo_box(false);
            }
            
            
        }

        private void radioButtonPrijem_CheckedChanged(object sender, EventArgs e)
        {
            set_combo_box(true);
        }

        private void radioButtonVydaj_CheckedChanged(object sender, EventArgs e)
        {
            set_combo_box(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
