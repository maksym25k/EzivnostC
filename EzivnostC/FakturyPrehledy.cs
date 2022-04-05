using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzivnostC
{
    public class StahovaniFaktur


    {

        User u = null;

        public StahovaniFaktur(User u)
        {
            this.u = u;


        } 
        public byte[] NacistFakturu(string datum_splatnosti)
        {
            SqlConnection c = DatabaseHelper.createconnection();

            string query = "select pdf from faktury where datum_splatnosti = @dat_sp";
            byte[] pdf = null;
            using (SqlCommand command = new SqlCommand(query, c))
            {
                command.Parameters.Add("@dat_sp", SqlDbType.Date).Value = datum_splatnosti;
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pdf = (byte[])reader[0];
                    
                }

            }

            return pdf;

        }


        public void stahnout_fakturu(string datum, string cesta)
        {
            FileStream fStream = new FileStream(cesta + "soubor1", FileMode.Create, FileAccess.Write);
            byte[] contents = NacistFakturu(datum);
            fStream.Write(contents, 0, (int)contents.Length);

        }
    }
}

