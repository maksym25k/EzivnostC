using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzivnostC
{
    public partial class Stahovani_faktur : Form
    {
        User user;
        public Stahovani_faktur( User u)
        {
            InitializeComponent();
            this.user = u;
            nacist_faktury();
            
            
        }

        string sqlQuery = @"   select id_pdf as 'id faktury', datum_splatnosti as 'Datum splatnosti', case when prijem =1 then 'Příjem' 
  when prijem = 0 then 'výdaj' 
  else 'Nezarazeno'
  end
  as ' ', castka as 'Částka', typ as 'Typ', poznamka as Poznámka from faktury where id_user = @user
  order by datum_splatnosti
  ;";

        public void nacist_faktury()
        {


            using (SqlConnection con = DatabaseHelper.createconnection())

            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                cmd.Parameters.Add("@user", SqlDbType.Int).Value = user.id;
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                               Zobrazení_faktur.DataSource = dt;
                            }
                        }
                    }
                }

      

        private void Zobrazení_faktur_SelectionChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Zobrazení_faktur_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Zobrazení_faktur_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Zobrazení_faktur_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            int ri = e.RowIndex;
            try
            {
            row= this.Zobrazení_faktur.Rows[ri];
            }
            catch
            {
                return;

            }
            
            string id_f = row.Cells["id faktury"].Value.ToString();
            int id_fi = int.Parse(id_f);


            Conf_download cd = new Conf_download(id_fi, user);
            cd.ShowDialog();
            nacist_faktury();
        }

       
    }
    }

