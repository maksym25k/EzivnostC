using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzivnostC
{
    public partial class Nastavení : Form
    {
        User user;
        public Nastavení(User u)
        {
            InitializeComponent();
            this.user = u;
            
        }

        private void radioButtonPrijem_CheckedChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            var p=  TypController.nacistTypyPrijmu(user);
            foreach (var t in p)
            {
                listBox1.Items.Add(t.ToString());
            }
        }

        private void radioButtonVydaj_CheckedChanged(object sender, EventArgs e)
        {

            this.listBox1.Items.Clear();

            var p = TypController.nacistTypyVydaju(user);
            foreach (var t in p)
            {
                listBox1.Items.Add(t.ToString());
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text.Length == 0)
            {
                MessageBox.Show("Nejdřív musite zvolit kategorii");


            }
            else
            {
                string query = @"update faktury set typ = 'nezařazeno' where typ = @typ and id_user = "  + this.user.id;
                SqlConnection con = DatabaseHelper.createconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@typ", SqlDbType.NVarChar).Value = listBox1.Items[listBox1.SelectedIndex].ToString ();
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Něco se nepovedlo");
                    return;

                }
                

                MessageBox.Show(@"Vymazání proběhlo uspěšně, všem fakturam s timto typem byl nastavený typ 'nepřířazeno'");



            }
        }

        private void buttonZmenitHeslo_Click(object sender, EventArgs e)
        {

            if (this.user.Heslo == textBoxStare_heslo.Text)
            {
                if(textBoxNoveHeslo.Text == textBoxOpakHesla.Text)
                {

                    if (  textBoxNoveHeslo.Text.Length > 5){
                            SqlConnection con = DatabaseHelper.createconnection();
                            string query = "update usersr set heslo = @noveheslo where id_user = @id";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add("@noveheslo", SqlDbType.NVarChar).Value = textBoxNoveHeslo.Text;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = user.id;
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        
                        catch
                        {
                            MessageBox.Show("něco se nepovedlo(");


                        }
                        textBoxNoveHeslo.Text = "";
                        textBoxOpakHesla.Text = "";
                        textBoxStare_heslo.Text = "";
                        }
                        else
                        {

                        MessageBox.Show("Nové heslo je příliš krátke");
                        }
                }
                else
                {
                    MessageBox.Show("Nové heslo a potvrzení hesla se neschoduji");

                }


            }
            else
            {
                MessageBox.Show("Staré heslo je nesprávné");

            }
        }

        private void buttonOdhlaseni_Click(object sender, EventArgs e)
        {

            Application.Restart();
        }
    }
}
