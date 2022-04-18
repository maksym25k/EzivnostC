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

        User u ;

        public StahovaniFaktur(User u)
        {
            this.u = u;


        } 
        public byte[] NacistFakturu(int id)
        {
            SqlConnection c = DatabaseHelper.createconnection();

            string query = "select pdf from faktury where id_pdf = @dat_sp";
            byte[] pdf = null;
            using (SqlCommand command = new SqlCommand(query, c))
            {
                command.Parameters.Add("@dat_sp", SqlDbType.Int).Value = id;
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pdf = (byte[])reader[0];
                    
                }

            }

            return pdf;

        }


        public void stahnout_fakturu(int id, string cesta)
        {
            FileStream fStream = new FileStream(cesta , FileMode.Create, FileAccess.Write);
            byte[] contents = NacistFakturu(id);
            fStream.Write(contents, 0, (int)contents.Length);
            fStream.Close();

        }
    }
}

