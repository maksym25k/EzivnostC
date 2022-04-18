
using System;
using System.Windows.Forms;

namespace EzivnostC
{
    public partial class Welcome : Form
    {
        User u = new User();
        Menu m;

        public Welcome()
        {
            InitializeComponent();
            hesloRegistrace.PasswordChar = '*';
            PHesloRegistrace.PasswordChar = '*';
            TextBoxHesloP.PasswordChar = '*';
        }
        FlowLayoutPanel lp = new FlowLayoutPanel();

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
            panel1.Visible = false;
            signupp.Visible = true;

        }
        private void signup2_Click(object sender, EventArgs e)
        {


            u.setEmail(emailRegistrace.Text);
            this.heslo = hesloRegistrace.Text;
            string pheslo = PHesloRegistrace.Text;
            if (this.heslo == pheslo && pheslo.Length >= 8 && u.Email.Length >= 5)
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
            catch 
            {
                MessageBox.Show("špatnì zadané údaje");
                return;
            }
            start_menu();
        }
        string email;
        string heslo;

        private void Ulozit_Click(object sender, EventArgs e)
        {
         
            string jmeno = TextBoxJmeno.Text;
            string prijmeni = TextBoxPrijmeni.Text;
       
            try
            {
                u = new User(jmeno, prijmeni, u.Email,heslo);

            }
            catch (Exception)
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
             m = new Menu(this.u);
            this.Hide();
            m.Show();
        }
        /*  public  void ThreadProc()
          {
              Main m = new Main(this.u);
              Application.Run(m);
          }

          private void show_menu()
          {
              System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
              t.Start();
              this.Close();


          }*/
    }

   
}