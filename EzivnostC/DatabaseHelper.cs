using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace EzivnostC
{

  
    public  static class DatabaseHelper
    {
         

         
          
        public  static void serialize(string servername, string database_name , string login , string password)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"servername",servername },
                {"database name",database_name},
                {"login",login},
                {"Password",password}
            };
            var json = JsonConvert.SerializeObject(dict);
            MessageBox.Show(json.ToString() );
            
            File.WriteAllText(@"dbconf.json", json);
        }


        public static Dictionary<string,string> deserialize()
        {
            string i = "";
            Dictionary<string,string> store = new Dictionary<string, string>();
            try
            {
                i = File.ReadAllText(@"dbconf.json");
            }
            catch
            {
                throw new Exception("Soubor konfigurace nenalezen");
            }
            store = JsonConvert.DeserializeObject<Dictionary<string, string>>(i);
           


            return store;
        }


        public  static string createConnString()
        {
          var a =deserialize();
            string ConnString = @"Server ="+a["servername"]+"; Database = "+a["database name"]+ ";User Id =" + a["login"]+";Password ="+a["Password"];
            return ConnString;
            



        }

        public  static SqlConnection createconnection()
        {
            return new SqlConnection(createConnString());

        }

        public static void testConnection()
        {
            var c = new SqlConnection();
            
                 c = createconnection();
            if (c != null)
            {
                try
                {
                    c.Open();
                    c.Close();
                }
                catch (Exception ){
                    throw new Exception("Nelze se pripojit k serveru");
                } }
                
            
        }

    }
}
