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
            dataemaillabel.Text = user.Email;
            dataicolabel.Text = user.ico.ToString();
            datadiclabel.Text = user.dic;
            datatelcislolabel.Text = user.tel_cislo;
            dataadresalabel.Text = "...";
            datavydelekzamesiclabel.Text = "...";
            datavydelekzatotoobdobílabel.Text = "...";
            dataadresalabel.Text = user.adresa;
            dataprumernyvydelek.Text = "...";

        }


        private void buttonUlozitfakturu_f_Click(object sender, EventArgs e)
        {

        }

        private void Ulozenifaktury_menu_button_Click(object sender, EventArgs e)
        {
            tableProfil.Visible = false;
            Ulozeni_faktur_panel.Visible = true;
            FormularProUlozeniFaktury.Visible = true;
        }

        private void profilmenubutton_Click(object sender, EventArgs e)
        {
            tableProfil.Visible = true;
            Ulozeni_faktur_panel.Visible=false;
            FormularProUlozeniFaktury.Visible=false;
        }

        private void Ulozeni_faktur_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Vybrat_soubor_Button_f_Click(object sender, EventArgs e)
        {
            openFileSkenFaktury.ShowDialog();
            if (openFileSkenFaktury.FileName.Contains("pdf"))
            {



            }
            else
            {
                MessageBox.Show("Soubor musí být ve formátu pdf");

                return;
            }        }
    }
}
