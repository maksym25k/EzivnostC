namespace EzivnostC
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Drawing;
    using global::System.IO;
    using global::System.Linq;
    using global::System.Net.Http;
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
            this.TextBoxDic = new System.Windows.Forms.TextBox();
            this.TextBoxICO = new System.Windows.Forms.TextBox();
            this.TextBoxDatNar = new System.Windows.Forms.TextBox();
            this.TextBoxAdresa = new System.Windows.Forms.TextBox();
            this.TextBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.TextBoxJmeno = new System.Windows.Forms.TextBox();
            this.TextBoxZalohaZP = new System.Windows.Forms.TextBox();
            this.TextBoxZalohaSOC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Hlavnicinnostcheck = new System.Windows.Forms.CheckBox();
            this.labelHLC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxTelCislo = new System.Windows.Forms.TextBox();
            this.Menu_pan = new System.Windows.Forms.Panel();
            this.Ulozeni_faktur_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableProfil = new System.Windows.Forms.TableLayoutPanel();
            this.datavydelekzatotoobdobílabel = new System.Windows.Forms.Label();
            this.dataprumernyvydelek = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labeltelcis = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.dataprijmenilabel = new System.Windows.Forms.Label();
            this.datajmenolabel = new System.Windows.Forms.Label();
            this.labelPrijmeni = new System.Windows.Forms.Label();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.dataemaillabel = new System.Windows.Forms.Label();
            this.datatelcislolabel = new System.Windows.Forms.Label();
            this.labelICO = new System.Windows.Forms.Label();
            this.labelDIC = new System.Windows.Forms.Label();
            this.dataicolabel = new System.Windows.Forms.Label();
            this.datadiclabel = new System.Windows.Forms.Label();
            this.labeladresa = new System.Windows.Forms.Label();
            this.labelvydelekzamesic = new System.Windows.Forms.Label();
            this.dataadresalabel = new System.Windows.Forms.Label();
            this.datavydelekzamesiclabel = new System.Windows.Forms.Label();
            this.labevydelekzarok = new System.Windows.Forms.Label();
            this.LabelPrůměrnyvydelek = new System.Windows.Forms.Label();
            this.MenuTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.profilmenubutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.loginp.SuspendLayout();
            this.signupp.SuspendLayout();
            this.infot.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Menu_pan.SuspendLayout();
            this.tableProfil.SuspendLayout();
            this.MenuTablePanel.SuspendLayout();
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
            this.infot.Controls.Add(this.TextBoxDic, 1, 2);
            this.infot.Controls.Add(this.TextBoxICO, 0, 2);
            this.infot.Controls.Add(this.TextBoxDatNar, 1, 1);
            this.infot.Controls.Add(this.TextBoxAdresa, 0, 1);
            this.infot.Controls.Add(this.TextBoxPrijmeni, 1, 0);
            this.infot.Controls.Add(this.TextBoxJmeno, 0, 0);
            this.infot.Controls.Add(this.TextBoxZalohaZP, 0, 3);
            this.infot.Controls.Add(this.TextBoxZalohaSOC, 1, 3);
            this.infot.Controls.Add(this.panel2, 0, 4);
            this.infot.Controls.Add(this.button1, 1, 5);
            this.infot.Controls.Add(this.TextBoxTelCislo, 1, 4);
            this.infot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infot.Name = "infot";
            this.infot.Tag = "infot";
            this.infot.Paint += new System.Windows.Forms.PaintEventHandler(this.infot_Paint);
            // 
            // TextBoxDic
            // 
            resources.ApplyResources(this.TextBoxDic, "TextBoxDic");
            this.TextBoxDic.Name = "TextBoxDic";
            // 
            // TextBoxICO
            // 
            resources.ApplyResources(this.TextBoxICO, "TextBoxICO");
            this.TextBoxICO.Name = "TextBoxICO";
            // 
            // TextBoxDatNar
            // 
            resources.ApplyResources(this.TextBoxDatNar, "TextBoxDatNar");
            this.TextBoxDatNar.Name = "TextBoxDatNar";
            // 
            // TextBoxAdresa
            // 
            resources.ApplyResources(this.TextBoxAdresa, "TextBoxAdresa");
            this.TextBoxAdresa.Name = "TextBoxAdresa";
            // 
            // TextBoxPrijmeni
            // 
            resources.ApplyResources(this.TextBoxPrijmeni, "TextBoxPrijmeni");
            this.TextBoxPrijmeni.Name = "TextBoxPrijmeni";
            // 
            // TextBoxJmeno
            // 
            resources.ApplyResources(this.TextBoxJmeno, "TextBoxJmeno");
            this.TextBoxJmeno.Name = "TextBoxJmeno";
            // 
            // TextBoxZalohaZP
            // 
            resources.ApplyResources(this.TextBoxZalohaZP, "TextBoxZalohaZP");
            this.TextBoxZalohaZP.Name = "TextBoxZalohaZP";
            // 
            // TextBoxZalohaSOC
            // 
            resources.ApplyResources(this.TextBoxZalohaSOC, "TextBoxZalohaSOC");
            this.TextBoxZalohaSOC.Name = "TextBoxZalohaSOC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Hlavnicinnostcheck);
            this.panel2.Controls.Add(this.labelHLC);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Hlavnicinnostcheck
            // 
            resources.ApplyResources(this.Hlavnicinnostcheck, "Hlavnicinnostcheck");
            this.Hlavnicinnostcheck.Checked = true;
            this.Hlavnicinnostcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Hlavnicinnostcheck.Name = "Hlavnicinnostcheck";
            this.Hlavnicinnostcheck.UseVisualStyleBackColor = true;
            // 
            // labelHLC
            // 
            resources.ApplyResources(this.labelHLC, "labelHLC");
            this.labelHLC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHLC.Name = "labelHLC";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ulozit_Click);
            // 
            // TextBoxTelCislo
            // 
            resources.ApplyResources(this.TextBoxTelCislo, "TextBoxTelCislo");
            this.TextBoxTelCislo.Name = "TextBoxTelCislo";
            // 
            // Menu_pan
            // 
            this.Menu_pan.Controls.Add(this.Ulozeni_faktur_panel);
            this.Menu_pan.Controls.Add(this.tableProfil);
            this.Menu_pan.Controls.Add(this.MenuTablePanel);
            resources.ApplyResources(this.Menu_pan, "Menu_pan");
            this.Menu_pan.Name = "Menu_pan";
            // 
            // Ulozeni_faktur_panel
            // 
            resources.ApplyResources(this.Ulozeni_faktur_panel, "Ulozeni_faktur_panel");
            this.Ulozeni_faktur_panel.Name = "Ulozeni_faktur_panel";
            // 
            // tableProfil
            // 
            this.tableProfil.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.tableProfil, "tableProfil");
            this.tableProfil.Controls.Add(this.datavydelekzatotoobdobílabel, 0, 9);
            this.tableProfil.Controls.Add(this.dataprumernyvydelek, 0, 9);
            this.tableProfil.Controls.Add(this.label6, 0, 9);
            this.tableProfil.Controls.Add(this.labeltelcis, 1, 2);
            this.tableProfil.Controls.Add(this.labelemail, 0, 2);
            this.tableProfil.Controls.Add(this.dataprijmenilabel, 1, 1);
            this.tableProfil.Controls.Add(this.datajmenolabel, 0, 1);
            this.tableProfil.Controls.Add(this.labelPrijmeni, 1, 0);
            this.tableProfil.Controls.Add(this.labelJmeno, 0, 0);
            this.tableProfil.Controls.Add(this.dataemaillabel, 0, 3);
            this.tableProfil.Controls.Add(this.datatelcislolabel, 1, 3);
            this.tableProfil.Controls.Add(this.labelICO, 0, 4);
            this.tableProfil.Controls.Add(this.labelDIC, 1, 4);
            this.tableProfil.Controls.Add(this.dataicolabel, 0, 5);
            this.tableProfil.Controls.Add(this.datadiclabel, 1, 5);
            this.tableProfil.Controls.Add(this.labeladresa, 0, 6);
            this.tableProfil.Controls.Add(this.labelvydelekzamesic, 1, 6);
            this.tableProfil.Controls.Add(this.dataadresalabel, 0, 7);
            this.tableProfil.Controls.Add(this.datavydelekzamesiclabel, 1, 7);
            this.tableProfil.Controls.Add(this.labevydelekzarok, 0, 8);
            this.tableProfil.Controls.Add(this.LabelPrůměrnyvydelek, 1, 8);
            this.tableProfil.Name = "tableProfil";
            this.tableProfil.Paint += new System.Windows.Forms.PaintEventHandler(this.tableProfil_Paint);
            // 
            // datavydelekzatotoobdobílabel
            // 
            resources.ApplyResources(this.datavydelekzatotoobdobílabel, "datavydelekzatotoobdobílabel");
            this.datavydelekzatotoobdobílabel.Name = "datavydelekzatotoobdobílabel";
            // 
            // dataprumernyvydelek
            // 
            resources.ApplyResources(this.dataprumernyvydelek, "dataprumernyvydelek");
            this.dataprumernyvydelek.Name = "dataprumernyvydelek";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // labeltelcis
            // 
            resources.ApplyResources(this.labeltelcis, "labeltelcis");
            this.labeltelcis.Name = "labeltelcis";
            // 
            // labelemail
            // 
            resources.ApplyResources(this.labelemail, "labelemail");
            this.labelemail.Name = "labelemail";
            // 
            // dataprijmenilabel
            // 
            resources.ApplyResources(this.dataprijmenilabel, "dataprijmenilabel");
            this.dataprijmenilabel.Name = "dataprijmenilabel";
            // 
            // datajmenolabel
            // 
            resources.ApplyResources(this.datajmenolabel, "datajmenolabel");
            this.datajmenolabel.Name = "datajmenolabel";
            // 
            // labelPrijmeni
            // 
            resources.ApplyResources(this.labelPrijmeni, "labelPrijmeni");
            this.labelPrijmeni.Name = "labelPrijmeni";
            // 
            // labelJmeno
            // 
            resources.ApplyResources(this.labelJmeno, "labelJmeno");
            this.labelJmeno.Name = "labelJmeno";
            // 
            // dataemaillabel
            // 
            resources.ApplyResources(this.dataemaillabel, "dataemaillabel");
            this.dataemaillabel.Name = "dataemaillabel";
            // 
            // datatelcislolabel
            // 
            resources.ApplyResources(this.datatelcislolabel, "datatelcislolabel");
            this.datatelcislolabel.Name = "datatelcislolabel";
            // 
            // labelICO
            // 
            resources.ApplyResources(this.labelICO, "labelICO");
            this.labelICO.Name = "labelICO";
            // 
            // labelDIC
            // 
            resources.ApplyResources(this.labelDIC, "labelDIC");
            this.labelDIC.Name = "labelDIC";
            // 
            // dataicolabel
            // 
            resources.ApplyResources(this.dataicolabel, "dataicolabel");
            this.dataicolabel.Name = "dataicolabel";
            // 
            // datadiclabel
            // 
            resources.ApplyResources(this.datadiclabel, "datadiclabel");
            this.datadiclabel.Name = "datadiclabel";
            // 
            // labeladresa
            // 
            resources.ApplyResources(this.labeladresa, "labeladresa");
            this.labeladresa.Name = "labeladresa";
            // 
            // labelvydelekzamesic
            // 
            resources.ApplyResources(this.labelvydelekzamesic, "labelvydelekzamesic");
            this.labelvydelekzamesic.Name = "labelvydelekzamesic";
            // 
            // dataadresalabel
            // 
            resources.ApplyResources(this.dataadresalabel, "dataadresalabel");
            this.dataadresalabel.Name = "dataadresalabel";
            // 
            // datavydelekzamesiclabel
            // 
            resources.ApplyResources(this.datavydelekzamesiclabel, "datavydelekzamesiclabel");
            this.datavydelekzamesiclabel.Name = "datavydelekzamesiclabel";
            // 
            // labevydelekzarok
            // 
            resources.ApplyResources(this.labevydelekzarok, "labevydelekzarok");
            this.labevydelekzarok.Name = "labevydelekzarok";
            // 
            // LabelPrůměrnyvydelek
            // 
            resources.ApplyResources(this.LabelPrůměrnyvydelek, "LabelPrůměrnyvydelek");
            this.LabelPrůměrnyvydelek.Name = "LabelPrůměrnyvydelek";
            // 
            // MenuTablePanel
            // 
            resources.ApplyResources(this.MenuTablePanel, "MenuTablePanel");
            this.MenuTablePanel.Controls.Add(this.button10, 0, 5);
            this.MenuTablePanel.Controls.Add(this.button9, 0, 4);
            this.MenuTablePanel.Controls.Add(this.button8, 0, 3);
            this.MenuTablePanel.Controls.Add(this.button7, 0, 2);
            this.MenuTablePanel.Controls.Add(this.button6, 0, 1);
            this.MenuTablePanel.Controls.Add(this.profilmenubutton, 0, 0);
            this.MenuTablePanel.Name = "MenuTablePanel";
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // profilmenubutton
            // 
            resources.ApplyResources(this.profilmenubutton, "profilmenubutton");
            this.profilmenubutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.profilmenubutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profilmenubutton.Name = "profilmenubutton";
            this.profilmenubutton.UseVisualStyleBackColor = false;
            this.profilmenubutton.Click += new System.EventHandler(this.profilmenubutton_Click);
            // 
            // Welcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infot);
            this.Controls.Add(this.signupp);
            this.Controls.Add(this.Menu_pan);
            this.Controls.Add(this.infolabel);
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
            this.infot.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Menu_pan.ResumeLayout(false);
            this.tableProfil.ResumeLayout(false);
            this.tableProfil.PerformLayout();
            this.MenuTablePanel.ResumeLayout(false);
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
        private TextBox TextBoxDic;
        private TextBox TextBoxICO;
        private TextBox TextBoxDatNar;
        private TextBox TextBoxAdresa;
        private TextBox TextBoxPrijmeni;
        private TextBox TextBoxJmeno;
        private Button button1;
        private Panel Menu_pan;
        private TableLayoutPanel MenuTablePanel;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button profilmenubutton;
        private FlowLayoutPanel Ulozeni_faktur_panel;
        private TableLayoutPanel tableProfil;
        private Label labeltelcis;
        private Label labelemail;
        private Label dataprijmenilabel;
        private Label datajmenolabel;
        private Label labelPrijmeni;
        private Label labelJmeno;
        private Label datavydelekzatotoobdobílabel;
        private Label dataprumernyvydelek;
        private Label label6;
        private Label dataemaillabel;
        private Label datatelcislolabel;
        private Label labelICO;
        private Label labelDIC;
        private Label dataicolabel;
        private Label datadiclabel;
        private Label labeladresa;
        private Label labelvydelekzamesic;
        private Label dataadresalabel;
        private Label datavydelekzamesiclabel;
        private Label labevydelekzarok;
        private Label LabelPrůměrnyvydelek;
        private TextBox TextBoxZalohaZP;
        private TextBox TextBoxZalohaSOC;
        private Panel panel2;
        private CheckBox Hlavnicinnostcheck;
        private Label labelHLC;
        private TextBox TextBoxTelCislo;
    }
}