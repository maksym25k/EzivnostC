using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzivnostC
{
    public class Prehledy
    {

        User u;
        private string startdate;
        public Prehledy (User u)
        {
            this.u = u;
            

        }

        public decimal monthReportVydaje(int rok, int mesic)
        {
            SqlConnection c = DatabaseHelper.createconnection();
            c.Open();
            string query = "select sum(castka) as soucet_vydaju from faktury where month( datum_splatnosti) = @mesic and year(datum_splatnosti)  = @rok and prijem = 0 and id_user = @user;";
            SqlCommand cmd = new SqlCommand(query, c);
            cmd.Parameters.Add("@mesic", SqlDbType.Int).Value = mesic;
            cmd.Parameters.Add("@rok", SqlDbType.Int).Value = rok;
            cmd.Parameters.Add("@user", SqlDbType.Int).Value = u.id;
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                decimal a = 0;
                while (dr.Read())
                {

                    a = (decimal)dr[0];
                }
                c.Close();

                return a;
            }
            catch
            {


                c.Close();
                return 0;

            }
        }

            public decimal monthReportPrijmy(int rok, int mesic)
        {
            SqlConnection c = DatabaseHelper.createconnection();
            c.Open();
            string query = "select sum(castka) as soucet_vydaju from faktury where month( datum_splatnosti) = @mesic and year(datum_splatnosti)  = @rok and prijem = 1 and id_user = @user;";
            SqlCommand cmd = new SqlCommand(query, c);
            cmd.Parameters.Add("@mesic", SqlDbType.Int).Value = mesic;
            cmd.Parameters.Add("@rok", SqlDbType.Int).Value = rok;
            cmd.Parameters.Add("@user",SqlDbType.Int).Value = u.id;
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                decimal a = 0;
                while (dr.Read())
                {

                    a = (decimal)dr[0]; 
                }
                c.Close();

                return a;
            }
            catch
            {


                c.Close();
                return 0;

            }




        }



        public decimal get_report_by_type_Vydej(string type, int mesic,int rok, bool prijem) 

        {
            using( SqlConnection c = DatabaseHelper.createconnection())
            {
                string query = "select sum(castka) soucet from faktury where prijem = 0 and typ =  @typ and id_user = @user and month(datum_splatnosti) =@mesic and year(datum_splatnosti) =@rok;";




                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    cmd.Parameters.Add("@typ", SqlDbType.NVarChar).Value= type;
                  /*  cmd.Parameters.Add("@prijem", SqlDbType.Bit).Value = prijem;*/
                    cmd.Parameters.Add("@user",SqlDbType.Int).Value = this.u.id;
                    cmd.Parameters.Add("@mesic", SqlDbType.Int).Value= mesic;
                    cmd.Parameters.Add("@rok",SqlDbType.Int).Value= rok;
                    c.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    decimal a = 0;
                    try
                    {
                        while (reader.Read())
                        {

                            a = (decimal)reader[0];
                        }
                        c.Close();
                        return (a);
                    }
                    catch
                    {
                        reader.Close();
                        c.Close();
                        return 0;
                    }
                }


            }



        }





    }
}
