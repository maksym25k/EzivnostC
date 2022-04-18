using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzivnostC
{

   
    public class User
    {
       




        public int id;
        public string Jmeno { set; get; }
        public string Prijmeni { set; get; }
        public string Heslo { set; get; }
        public string Email { set; get; }
        
       
        public User()
        {

        }

        public User(string jmeno, string Prijmeni, string Email, string Password)

        {
            setJmeno(jmeno);
            setPrijmeni(Prijmeni);
            setEmail(Email);

            this.Heslo = Password;
            
      
        }
        public void setJmeno(string jmeno)
        {
                this.Jmeno = jmeno;
        }
        public void setPrijmeni(string prijmeni)
        {
            if (char.IsUpper(prijmeni[0]) && Regex.IsMatch(prijmeni, @"^[a-zA-Z]+$"))
            {
                this.Prijmeni = prijmeni;
            }
            else
            {
                MessageBox.Show("Prijmeni muze obsahovat jenom znaky a musi zacinat velkým písmenem");
            }

        }
        public void setHeslo(string inp)
        {
            if (inp.Length > 8)
            {
                this.Heslo = Heslo;
            }
            else
            {
                MessageBox.Show("Heslo musi mit alespon 8 znaků");

            }
        }
        public void setEmail(string inp)
        {
            if (inp.Contains("@") && inp.Contains("."))
            {
                this.Email = inp;

            }
            else
            {
                throw (new Exception("Email je neplatný"));

            }
        }
       



       

        public void ulozit_do_databaze()
            
        { 
            string query1 = "INSERT INTO Usersr VALUES (@email ,@heslo,@jmeno,@prijmeni)";
            
            using (SqlConnection connection = DatabaseHelper.createconnection())
            {
                using (SqlCommand command = new SqlCommand(query1, connection))
                {

                    command.Parameters.Add("@jmeno", SqlDbType.VarChar).Value = this.Jmeno;
                    command.Parameters.Add("@prijmeni", SqlDbType.VarChar).Value = this.Prijmeni;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = this.Email;
                    command.Parameters.Add("@heslo", SqlDbType.NVarChar).Value = this.Heslo;
                   

                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();

              
                    if (result < 0)
                    {
                        throw new Exception("Nepodařilo se přidat data do databaze");
                    }
                }
            }
        }

        public void Prihlaseni(string email, string heslo)
        {
            
            string select_Query = "select * from usersr where email = @email and heslo = @heslo";

            using (SqlConnection connection = DatabaseHelper.createconnection()) 
            {
                using (SqlCommand command = new SqlCommand(select_Query, connection))
                 {
                    command.Parameters.Add("@email",SqlDbType.NVarChar).Value = email;
                    command.Parameters.Add("@heslo",SqlDbType.NVarChar).Value = heslo;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    this.id = Int32.Parse(reader["id_user"].ToString());
                    this.Email= reader["email"].ToString();
                    this.Heslo= reader["heslo"].ToString();
                    
                    this.Prijmeni = reader["prijmeni"].ToString();
                    this.Jmeno = reader["jmeno"].ToString() ;
                  
        
               
                    reader.Close(); 
                    connection.Close();


                }

            }
            }


        }

    }


   