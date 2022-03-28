using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EzivnostC
{

  
    public   class DatabaseHelper
    {
         

         
          
        public   void serialize(string servername, string database_name , string login , string password)
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


        public Dictionary<string,string> deserialize()
        {
            Dictionary<string,string> store = new Dictionary<string, string>();

            string i = File.ReadAllText(@"dbconf.json");
            store = JsonConvert.DeserializeObject<Dictionary<string, string>>(i);
           


            return store;
        }


        public string createConnString()
        {
            var a =deserialize();
            string ConnString = @"Server ="+a["servername"]+"; Database = "+a["database name"]+ ";User Id =" + a["login"]+";Password ="+a["Password"];
            /* return ConnString;*/
            return "Server = DESKTOP-91O4NAF; Database = Ezivnost; Trusted_Connection = True";

        }






    }
}
