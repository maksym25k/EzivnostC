
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EzivnostC
{
    public partial class Welcome : Form
    {
        User u = new User();
 
        public Welcome()
        {
            InitializeComponent();
        }
        FlowLayoutPanel lp =  new FlowLayoutPanel();

       private void back_Click(object sender, EventArgs e)
        {
            loginp.Visible = false;
            signupp.Visible = false;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            loginp.Visible = true;
        }
        private void signup_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            signupp.Visible = true;
            
        }
        private void signup2_Click(object sender, EventArgs e)
        {


            u.setEmail(emailRegistrace.Text);
             this.heslo = hesloRegistrace.Text;
            string pheslo = PHesloRegistrace.Text;
            if (this.heslo == pheslo &&pheslo.Length >=8 && this.email.Length >=5)
            {
                signupp.Visible = false;
                infot.Visible = true;
                infolabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Potvrzeni hesla a heslo se neschoduji nebo heslo je moc krátke");
                return;
                
            }
        }

        private void Prihlasení_click(object sender, EventArgs e)
        {
            this.email = TextBoxEmailP.Text;
            this.heslo = TextBoxHesloP.Text;
            try
            {
                this.u.Prihlaseni(this.email, this.heslo);
            }
            catch(Exception ex)
            {
                MessageBox.Show("špatnì zadané údaje");
                return ;
            }
            start_menu();
        }
        string email;
        string heslo;

        private void Ulozit_Click(object sender, EventArgs e)
        {
            string ico = textBoxIÈO.Text;
            string dic = textBoxDIÈ.Text;
            string jmeno = TextBoxJmeno.Text;
            string prijmeni = TextBoxPrijmeni.Text;
            string zalohasoc = textBoxZaloha_soc.Text;
            string zalohazdr =textBoxZalohaZdr.Text;   
            bool hlC = Hlavnicinnostcheck.Checked;
            string dat_nar = TextBoxDatNar.Text;
            string adresa = TextBoxAdresa.Text;
            try
            {
                u = new User(jmeno,prijmeni,this.email,textBoxTelCislo.Text,dat_nar,hlC,float.Parse(zalohazdr),float.Parse(zalohasoc),int.Parse(ico), dic,this.heslo,TextBoxAdresa.Text);

            }
            catch (Exception )
            {
                MessageBox.Show("Nìjaký z údajù je zadaný špatnì");
                return; 
            }
            try
            {
                u.ulozit_do_databaze(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            start_menu();


        }

        public void start_menu()
        {
            Main m = new Main(this.u);
            this.Hide();
            Application.Run(m);

        }

      
    }
}