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
        private string connstring;




        public int id;
        public string Jmeno { set; get; } /*{ get { return Jmeno; } set { Jmeno = setJmeno(Jmeno); } }*/
        public string Prijmeni { set; get; }/*{ get { return Prijmeni; } set { Prijmeni = setPrijmeni(Prijmeni); } }*/
        private string Heslo { set; get; }
        public string Email { set; get; }
        public string tel_cislo { set; get; }
        public string Datum_narozeni;

        public bool hlavniCinnost { set; get; }
        public float zalohaZdrav { set; get; }
        public float zalohaSoc { set; get; }

        public int ico { set; get; }

        public string dic { set; get; }


        public string adresa { set; get; }

        public User()
        {

        }

        public User(string jmeno, string Prijmeni, string Email, string tel_cislo, string Dat_nar, bool hlavni_cinnost, float zaloha_zdrav, float zaloha_soc, int ico, string dic, string Password, string adresa)

        {
            setJmeno(jmeno);
            setPrijmeni(Prijmeni);
            setEmail(Email);
            setTelCislo(tel_cislo);

            this.Datum_narozeni = Dat_nar;
            setHl_Cinnost(hlavni_cinnost);
            set_Zaloha_zdr(zaloha_zdrav);
            set_Zaloha_soc(zaloha_soc);
            this.ico = ico;
            this.dic = dic;
            this.Heslo = Password;
            this.adresa = adresa;
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
        public void setTelCislo(string inp)
        {
            bool t = false;
            foreach (char c in inp)
            {
                if (c < '0' || c > '9')
                    t = false;
            }
            t = true;
            if (t)
            {
                this.tel_cislo = inp;
            }
            else { }
        }

        public void setDat_nar(string inp)
        {
            
                this.Datum_narozeni = inp;

            
        }
        public void setHl_Cinnost(bool cinnost)
        {
            this.hlavniCinnost = cinnost;

        }
        public void set_Zaloha_zdr(float vyse_zalohy)
        {
            if (vyse_zalohy >= 0)
            {
                this.zalohaZdrav = vyse_zalohy;

            }
            else
            {


            }
        }
        public void set_Zaloha_soc(float vyse_zalohy)
        {
            if (vyse_zalohy >= 0)
            {
                this.zalohaSoc = vyse_zalohy;
            }
            else
            {


            }

        }

       

        public void ulozit_do_databaze()
            
        { 
            string query1 = "INSERT INTO Users VALUES (@jmeno,@prijmeni,@email ,@tel_cislo,@dat_nar, @hlavni_cinnost, @zaloha_zdr,@zaloha_soc,@ico, @dic,@heslo, @adresa)";
            
            using (SqlConnection connection = DatabaseHelper.createconnection())
            {
                using (SqlCommand command = new SqlCommand(query1, connection))
                {

                    command.Parameters.Add("@jmeno", SqlDbType.VarChar).Value = this.Jmeno;
                    command.Parameters.Add("@prijmeni", SqlDbType.VarChar).Value = this.Prijmeni;
                    command.Parameters.Add("@tel_cislo", SqlDbType.VarChar).Value = this.tel_cislo;
                    command.Parameters.Add("@dat_nar", SqlDbType.Date).Value = this.Datum_narozeni;
                    command.Parameters.Add("@hlavni_cinnost", SqlDbType.Bit).Value = this.hlavniCinnost;
                    command.Parameters.Add("@zaloha_zdr", SqlDbType.Decimal).Value = this.zalohaZdrav;
                    command.Parameters.Add("@zaloha_soc", SqlDbType.Decimal).Value = this.zalohaSoc;
                    command.Parameters.Add("@ico", SqlDbType.NVarChar).Value = this.ico;
                    command.Parameters.Add("@dic", SqlDbType.NVarChar).Value = this.dic;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = this.Email;
                    command.Parameters.Add("@heslo", SqlDbType.NVarChar).Value = this.Heslo;
                    command.Parameters.Add("@adresa", SqlDbType.NVarChar).Value = this.adresa;

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
            
            string select_Query = "select * from users where email = @email and heslo = @heslo";

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
                    this.tel_cislo = reader["tel_cislo"].ToString();
                    this.Prijmeni = reader["prijmeni"].ToString();
                    this.Jmeno = reader["jmeno"].ToString() ;
                    this.Datum_narozeni = reader["dat_nar"].ToString();
                    this.zalohaSoc = float.Parse(reader["zaloha_soc"].ToString());
                    this.zalohaZdrav = float.Parse(reader["zaloha_zdr"].ToString());
                    this.ico = int.Parse(reader["ico"].ToString());
                    this.dic = reader["dic"].ToString();
                    bool a = bool.Parse(reader["hlavni_cinnost"].ToString());
                    this.adresa = reader["adresa"].ToString();
                    if (a)
                    {
                        this.hlavniCinnost = true;
                    }
                    else
                    {
                        this.hlavniCinnost= false;
                    }
                    reader.Close(); 
                    connection.Close();


                }

            }
            }


        }

    }


   