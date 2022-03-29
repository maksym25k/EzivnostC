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
    public partial class Main : Form
    {
        User u;
        public Main(User u)
        {
            this.u = u;
            InitializeComponent();
            SetProfileLabels();
        }
        private void SetProfileLabels()
        {
            datajmenolabel.Text = u.Jmeno;
            dataprijmenilabel.Text = u.Prijmeni;
            dataemaillabel.Text = u.Email;
            dataicolabel.Text = u.ico.ToString();
            datadiclabel.Text = u.dic;
            datatelcislolabel.Text = u.tel_cislo;
            dataadresalabel.Text = "...";
            datavydelekzamesiclabel.Text = "...";
            datavydelekzatotoobdobílabel.Text = "...";
            dataadresalabel.Text = u.adresa;
            dataprumernyvydelek.Text = "...";

        }


        private void buttonUlozitfakturu_f_Click(object sender, EventArgs e)
        {

        }
    }
}
