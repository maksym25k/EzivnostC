using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzivnostC
{
    public partial class Conf_download : Form
    {
        
        StahovaniFaktur sff;
        int id_faktury;
        User u;
        public Conf_download( int id_faktury, User u)
        {
            this.u
                = u;
            this.id_faktury = id_faktury;
            InitializeComponent();
            this.sff = new StahovaniFaktur(u);
            

        }

        private void no_Click(object sender, EventArgs e)
        {
            string query = "delete from faktury where id_pdf = " + id_faktury.ToString();
            SqlConnection con = DatabaseHelper.createconnection();
            SqlCommand com = new SqlCommand(query, con);
            try
            {
                con.Open(); 
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Faktura byla uspěšně vymazána");
                this.Close();
            }catch
            {

                MessageBox.Show("Pří vymazáni se něco nepovedlo");

            }

        }

        private void yes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fn = saveFileDialog1.FileName;
            string a= Path.GetFullPath(saveFileDialog1.FileName);
            sff.stahnout_fakturu(id_faktury, a );
            this.Close();
        }
    }
}
