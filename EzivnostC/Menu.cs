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
        User user = new User();
        public Menu( User u)
        {
            
            InitializeComponent();
            SetProfileLabels();
            this.user =  u;
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
    }
}
