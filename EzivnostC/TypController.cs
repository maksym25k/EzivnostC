using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace EzivnostC
{
    public static class TypController
    {

        public static List<string> typyV = new List<string>();
        public static List<string> typyP = new List<string>();
        public static void serializeVydaje(string typ)
        {



            try
            {


                System.IO.StreamWriter file = new System.IO.StreamWriter(@"souborstypyVydaj.txt", append: true);
                file.WriteLine(typ);
                file.Close();
            }
            catch 
            {
                return;
            }



        }
        public static void serializePrijmy(string typ)
        {



            try
            {







                foreach (string x in typyP)
                {
                    if (x == typ)
                    {
                        throw new Exception("takový typ již existuje");
                    }
                    else
                    {



                    }


                }




                System.IO.StreamWriter file = new System.IO.StreamWriter(@"souborstypyPrijem.txt", append: true);

                file.WriteLine(typ);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        public static List<string> nacistTypyVydaju(User u)
        {
            deserializeVydaje(u);
            return typyV;

        }
        public static List<string> nacistTypyPrijmu(User u)
        {
            deserializePrijmy(u);
            return typyP;

        }


        public static void deserializeVydaje(User u)
        {
            typyV.Clear();
            SqlConnection conn = DatabaseHelper.createconnection();
            string query = "select distinct typ from faktury where id_user = " + u.id + " and prijem = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                typyV.Add(r.GetString(0));


            }


            r.Close();
            conn.Close();
        }
        public static void deserializePrijmy(User u)
        {
            {
                typyP.Clear();
                SqlConnection conn = DatabaseHelper.createconnection();
                string query = "select distinct typ from faktury where id_user = " + u.id + " and prijem = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    typyP.Add(r.GetString(0));


                }


                r.Close();
                conn.Close();
            }






        }
    }
}
