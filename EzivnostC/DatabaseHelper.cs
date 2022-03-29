using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
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
            var json = System.Text.Json.JsonSerializer.Serialize(dict);
            MessageBox.Show(json.ToString() );
            
            File.WriteAllText(@"dbconf.json", json);
        }


        public static Dictionary<string,string> deserialize()
        {
            Dictionary<string,string> store = new Dictionary<string, string>();

            string i = File.ReadAllText(@"dbconf.json");
            store = JsonConvert.DeserializeObject<Dictionary<string, string>>(i);
           


            return store;
        }


        public  static string createConnString()
        {
         /*   var a =deserialize();
            string ConnString = @"Server ="+a["servername"]+"; Database = "+a["database name"]+ ";User Id =" + a["login"]+";Password ="+a["Password"];
            /* return ConnString;*/
            return "Server = PC421; Database = Ezivnost; User id= sa; Password = student ";

        }

        public  static SqlConnection createconnection()
        {
            return new SqlConnection(createConnString());

        }

        public static void testConnection()
        {
            try
            {
                SqlConnection c = createconnection();
                c.Open();
                c.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Pripojeni k serveru selhalo, program se ukonci");
            }
        }

    }
}
