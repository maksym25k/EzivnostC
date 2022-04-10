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
    public partial class PridaniTypu : Form
    {
        public PridaniTypu()
        {
            InitializeComponent();
        }

        private void Ulozit_button_Click(object sender, EventArgs e)
        {
            if (this.Prijem.Checked && this.typTextBox.Text.Length>0)
            {
                TypController.serializePrijmy(this.typTextBox.Text);
            }
            else
            {
                if (this.Vydaj.Checked)
                {
                    TypController.serializeVydaje(this.typTextBox.Text);

                }
                if (!(this.Vydaj.Checked || this.Prijem.Checked))
                {
                    MessageBox.Show("Zvolte zda je to typ příjmu nebo výdaje");
                    return;   
                }


            }
        }
    }
}
