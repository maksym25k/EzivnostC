using System;
using System.Collections.Generic;
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
                deserializeVydaje();
                if (typyV.Contains(typ))
                {
                    MessageBox.Show("Tento typ jiz existuje");
                    return;

                }
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"souborstypyVydaj.txt", append: true);
                file.WriteLine(typ);
                file.Close();
            }
            catch (Exception ex)
            {
                return;
            }



        }
        public static void serializePrijmy(string typ)
        {


           
            try
            {

                bool equal = false;


                typyP = nacistTypyPrijmu();
                if (typyP.Equals(null))
                {
                   
                }


                foreach(string x in typyP)
                {
                    if (x == typ)
                    {
                        throw new Exception("takový typ již existuje");
                    }
                    else
                    {
                        
                       
                        
                    }


                }
                



                System.IO.StreamWriter file = new System.IO.StreamWriter(@"souborstypyPrijem.txt",append:true);

                file.WriteLine(typ);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        public static List<string> nacistTypyVydaju()
        {   
            deserializeVydaje();
            return typyV;

        }
        public static List<string> nacistTypyPrijmu()
        {
            deserializePrijmy();
            return typyP;

        }


        public static void deserializeVydaje()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(@"souborstypyVydaj.txt");
            typyV.Clear();
            do
            {
                
                typyV.Add(reader.ReadLine());
                

            }
            while(!reader.EndOfStream);

            reader.Close();

        }
        public static void deserializePrijmy()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(@"souborstypyPrijem.txt");
            typyP.Clear();
            do
            {
                
                
                    
                    typyP.Add(reader.ReadLine());
                
                


            }
            while (!reader.EndOfStream);
            reader.Close();


        }






    }
}
