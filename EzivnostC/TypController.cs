using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzivnostC
{
    public static class TypController
    {   

        public static List<string> typy = new List<string>();
        public static void serialize(string typ)
        {
           
            
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"souborstypy.txt");
            try
            {
                file.Write(typ+",");
            }
            catch (Exception ex)
            {

            }



        }


        public static List<string> nacistTypy()
        {
            return typy;

        }



    }
}
