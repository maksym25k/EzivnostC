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
    public partial class MonthChoice : Form
    {
        public int rok ;
        public int mesic;
        public MonthChoice()
        {
            InitializeComponent();
        }

        private void getDate()
        {
            try
            {
                this.rok = int.Parse(textBoxRok.Text);
                this.mesic = int.Parse(textBoxMesic.Text);
            }
            catch
            {
                MessageBox.Show("Špatné údaje");
                return;
            }
            


        }

        private void OkButtonZadaniObdobí_Click(object sender, EventArgs e)
        {
            getDate();
            this.Visible = false;
            this.Close();
        }
    }
}
