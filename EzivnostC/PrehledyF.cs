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
    public partial class PrehledyF : Form
    {

       public int rok { get; }
        public int mesic { get; }

        User user = new User();
        Prehledy p;
        public PrehledyF( User u)
        {   
            this.user = u;
            p = new Prehledy(this.user);
            MonthChoice choice = new MonthChoice();
            choice.ShowDialog();
            this.rok = choice.rok;
            this.mesic = choice.mesic;
            InitializeComponent();
            nacist_prijmy_a_vydje();
        }


        public void nacist_prijmy_a_vydje()
        {
           decimal prijmy= p.monthReportPrijmy(this.rok, this.mesic);
            decimal vydaje = p.monthReportVydaje(this.rok, this.mesic);

            this.Label_prijmy_prehledy.Text = prijmy.ToString() + " Kč";

            this.Label_vydaje_prehledy.Text = vydaje.ToString() + " Kč";

            this.Label_Vynos_prehled.Text = (prijmy - vydaje).ToString() + " Kč";


        }
    }
}
