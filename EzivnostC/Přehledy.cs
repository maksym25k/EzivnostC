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



        public void GetStartDate()
        {
            



        }





    }
}
