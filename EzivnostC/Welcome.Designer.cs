namespace EzivnostC
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Drawing;
    using global::System.IO;
    using global::System.Linq;
  
    using global::System.Threading;
    using global::System.Threading.Tasks;
    using global::System.Windows.Forms;
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginp = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.TextBoxHesloP = new System.Windows.Forms.TextBox();
            this.TextBoxEmailP = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.signupp = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.PHesloRegistrace = new System.Windows.Forms.TextBox();
            this.hesloRegistrace = new System.Windows.Forms.TextBox();
            this.emailRegistrace = new System.Windows.Forms.TextBox();
            this.signupb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.infot = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxJmeno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.loginp.SuspendLayout();
            this.signupp.SuspendLayout();
            this.infot.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Name = "panel1";
            this.panel1.Tag = "lp";
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.signup, "signup");
            this.signup.Name = "signup";
            this.signup.Tag = "singup";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            this.login.Tag = "login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Name = "label1";
            // 
            // loginp
            // 
            resources.ApplyResources(this.loginp, "loginp");
            this.loginp.BackColor = System.Drawing.Color.DarkBlue;
            this.loginp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginp.CausesValidation = false;
            this.loginp.Controls.Add(this.label10);
            this.loginp.Controls.Add(this.label9);
            this.loginp.Controls.Add(this.button4);
            this.loginp.Controls.Add(this.TextBoxHesloP);
            this.loginp.Controls.Add(this.TextBoxEmailP);
            this.loginp.Controls.Add(this.button2);
            this.loginp.Controls.Add(this.label2);
            this.loginp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginp.Name = "loginp";
            this.loginp.Tag = "lp";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.back_Click);
            // 
            // TextBoxHesloP
            // 
            resources.ApplyResources(this.TextBoxHesloP, "TextBoxHesloP");
            this.TextBoxHesloP.Name = "TextBoxHesloP";
            // 
            // TextBoxEmailP
            // 
            resources.ApplyResources(this.TextBoxEmailP, "TextBoxEmailP");
            this.TextBoxEmailP.Name = "TextBoxEmailP";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Tag = "login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Prihlasení_click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Name = "label2";
            // 
            // signupp
            // 
            resources.ApplyResources(this.signupp, "signupp");
            this.signupp.BackColor = System.Drawing.Color.DarkBlue;
            this.signupp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signupp.CausesValidation = false;
            this.signupp.Controls.Add(this.label8);
            this.signupp.Controls.Add(this.label7);
            this.signupp.Controls.Add(this.label6);
            this.signupp.Controls.Add(this.button3);
            this.signupp.Controls.Add(this.PHesloRegistrace);
            this.signupp.Controls.Add(this.hesloRegistrace);
            this.signupp.Controls.Add(this.emailRegistrace);
            this.signupp.Controls.Add(this.signupb);
            this.signupp.Controls.Add(this.label3);
            this.signupp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signupp.Name = "signupp";
            this.signupp.Tag = "lp";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.back_Click);
            // 
            // PHesloRegistrace
            // 
            resources.ApplyResources(this.PHesloRegistrace, "PHesloRegistrace");
            this.PHesloRegistrace.Name = "PHesloRegistrace";
            // 
            // hesloRegistrace
            // 
            resources.ApplyResources(this.hesloRegistrace, "hesloRegistrace");
            this.hesloRegistrace.Name = "hesloRegistrace";
            // 
            // emailRegistrace
            // 
            resources.ApplyResources(this.emailRegistrace, "emailRegistrace");
            this.emailRegistrace.Name = "emailRegistrace";
            // 
            // signupb
            // 
            this.signupb.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.signupb, "signupb");
            this.signupb.Name = "signupb";
            this.signupb.Tag = "signup";
            this.signupb.UseVisualStyleBackColor = false;
            this.signupb.Click += new System.EventHandler(this.signup2_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Name = "label3";
            // 
            // infolabel
            // 
            resources.ApplyResources(this.infolabel, "infolabel");
            this.infolabel.Name = "infolabel";
            this.infolabel.Tag = "infolabel";
            // 
            // infot
            // 
            resources.ApplyResources(this.infot, "infot");
            this.infot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infot.Controls.Add(this.panel5, 1, 0);
            this.infot.Controls.Add(this.panel3, 0, 0);
            this.infot.Controls.Add(this.button1, 1, 1);
            this.infot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infot.Name = "infot";
            this.infot.Tag = "infot";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.TextBoxPrijmeni);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // TextBoxPrijmeni
            // 
            resources.ApplyResources(this.TextBoxPrijmeni, "TextBoxPrijmeni");
            this.TextBoxPrijmeni.Name = "TextBoxPrijmeni";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TextBoxJmeno);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // TextBoxJmeno
            // 
            resources.ApplyResources(this.TextBoxJmeno, "TextBoxJmeno");
            this.TextBoxJmeno.Name = "TextBoxJmeno";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ulozit_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Name = "label10";
            // 
            // Welcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infot);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.signupp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginp);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginp.ResumeLayout(false);
            this.loginp.PerformLayout();
            this.signupp.ResumeLayout(false);
            this.signupp.PerformLayout();
            this.infot.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Panel panel1;
        private Label label1;
        private Button signup;
        private Button login;
        public Panel loginp;
        private Button button2;
        private Label label2;
        private TextBox TextBoxHesloP;
        private TextBox TextBoxEmailP;
        public Panel signupp;
        private TextBox hesloRegistrace;
        private TextBox emailRegistrace;
        private Button signupb;
        private Label label3;
        private TextBox PHesloRegistrace;
        private Button button3;
        private Button button4;
        private Label infolabel;
        private TableLayoutPanel infot;
        private TextBox TextBoxJmeno;
        private Button button1;
        private Panel panel3;
        private Panel panel5;
        private TextBox TextBoxPrijmeni;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}