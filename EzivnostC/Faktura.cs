using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace EzivnostC
{
    public class FakturaVystavena
    {
        public string path_toFile;

        public float castka;

        public bool prijem;

        string poznamka;
        string typ;
        int ev_cislo;
        string dat_sp;

        public FakturaVystavena(string path_toFile, float castka, bool prijem, string poznamka, string typ,int ev_cislo,string dat_sp )
        {
            this.path_toFile = path_toFile;
            this.castka = castka;
            this.prijem = prijem;
            this.poznamka = poznamka;
            this.typ = typ;
            this.ev_cislo = ev_cislo;
            this.dat_sp = dat_sp;

            
        }




        public byte[] nacistPDF()
        {
            FileStream fStream = File.OpenRead(this.path_toFile);
            byte[] contents = new byte[fStream.Length];
            fStream.Read(contents, 0, (int)fStream.Length);
            fStream.Close();
            return contents;



        }

      



        public void Ulozit_do_db(User u)
        {
            SqlConnection c = DatabaseHelper.createconnection();


            string query = "insert into faktury values (@data, @castka, @prijem, @typ, @poznamka, @id_user,@ev_cislo,@dat_sp)";

            using (SqlCommand command = new SqlCommand(query, c))
            {

                command.Parameters.Add("@data", SqlDbType.VarBinary).Value = nacistPDF();
                command.Parameters.Add("@castka", SqlDbType.Decimal).Value = castka;
                command.Parameters.Add("@prijem", SqlDbType.Bit).Value = prijem;
                command.Parameters.Add("@typ", SqlDbType.NVarChar).Value = typ;
                command.Parameters.Add("@poznamka", SqlDbType.NVarChar).Value = poznamka;
                command.Parameters.Add("id_user", SqlDbType.Int).Value = u.id;
                command.Parameters.Add("ev_cislo", SqlDbType.Int).Value = ev_cislo;
                command.Parameters.Add("@dat_sp", SqlDbType.Date).Value = dat_sp;

                c.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ulozeni do databáze se nepovedlo");
                    return;
                }
                c.Close();




            }
        }
    }
}
