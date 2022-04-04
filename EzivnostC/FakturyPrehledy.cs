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
    public class FakturyPrehledy
    {
        public byte[] NacistFakturu(string datum_splatnosti)
        {
            SqlConnection c = DatabaseHelper.createconnection();

            string query = "select pdf from faktury where datum_splatnosti = @dat_sp";

            using (SqlCommand command = new SqlCommand(query, c))
            {
                command.Parameters.Add("@dat_sp", SqlDbType.Date).Value = datum_splatnosti;
                c.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SequentialAccess);
                byte[] chunk = new byte[0x10000];
                long read;
                long offset = 0;
                read = reader.GetBytes(0, offset, chunk, 0, chunk.Length);
                if (read > 0)
                {
                /*Response.OutputStream.Write(chunk, 0, (int)read);*/
               /* https://www.aspsnippets.com/Articles/Read-and-Write-Binary-data-files-in-ASPNet-using-C-and-VBNet.aspx*/
                    offset += read;
                }

                
                
                return pdf;




            }
        }

        public void stahnout_fakturu(string datum, string cesta)
        {
            FileStream fStream = File.OpenWrite(cesta);
            byte[] contents = NacistFakturu(datum);
            fStream.Write(contents, 0, (int)fStream.Length);



        }
    }
}
