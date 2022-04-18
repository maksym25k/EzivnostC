using System.Windows.Forms;

namespace EzivnostC
{
    partial class Menu

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private  void InitializeComponent()
        {
            this.Menu_pan = new System.Windows.Forms.Panel();
            this.FormularProUlozeniFaktury = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Datum_Splatnosti_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCastka_Faktura = new System.Windows.Forms.TextBox();
            this.LabelCastka = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPoznamka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTyp = new System.Windows.Forms.ComboBox();
            this.Vybrat_soubor_Button_f = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxEv_cislo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonVydaj = new System.Windows.Forms.RadioButton();
            this.radioButtonPrijem = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.tableProfil = new System.Windows.Forms.TableLayoutPanel();
            this.labelemail = new System.Windows.Forms.Label();
            this.dataprijmenilabel = new System.Windows.Forms.Label();
            this.datajmenolabel = new System.Windows.Forms.Label();
            this.labelPrijmeni = new System.Windows.Forms.Label();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.dataprumernyvydelek = new System.Windows.Forms.Label();
            this.Výnoszaměsic = new System.Windows.Forms.Label();
            this.labelEmailProfil = new System.Windows.Forms.Label();
            this.MenuTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.PrehledyButton = new System.Windows.Forms.Button();
            this.Ulozenifaktury_menu_button = new System.Windows.Forms.Button();
            this.profilmenubutton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.openFileSkenFaktury = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.Menu_pan.SuspendLayout();
            this.FormularProUlozeniFaktury.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableProfil.SuspendLayout();
            this.MenuTablePanel.SuspendLayout();
            this.SuspendLayout();
            set_St2();
            set_St3();
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Menu_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "Menu";
            this.Text = "Registrace";
            this.Menu_pan.ResumeLayout(false);
            this.FormularProUlozeniFaktury.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableProfil.ResumeLayout(false);
            this.tableProfil.PerformLayout();
            this.MenuTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Menu_pan;
        private TableLayoutPanel tableProfil;
        private Label dataprumernyvydelek;
        private Label labelemail;
        private Label dataprijmenilabel;
        private Label datajmenolabel;
        private Label labelPrijmeni;
        private Label labelJmeno;
        private Label Výnoszaměsic;
        private TableLayoutPanel MenuTablePanel;
        private Button button10;
        private Button button8;
        private Button PrehledyButton;
        private Button Ulozenifaktury_menu_button;
        private Button profilmenubutton;
        private TableLayoutPanel FormularProUlozeniFaktury;
        private Button Vybrat_soubor_Button_f;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxCastka_Faktura;
        private Label LabelCastka;
        private Panel panel3;
        private Label label1;
        private ComboBox comboBoxTyp;
        private Panel panel4;
        private Label label2;
        private RadioButton radioButtonVydaj;
        private RadioButton radioButtonPrijem;
        private TextBox textBoxPoznamka;
        private OpenFileDialog openFileSkenFaktury;
        private Label labelEmailProfil;
        private Panel panel5;
        private TextBox textBoxEv_cislo;
        private Label label3;
        private Button button2;
        private Panel panel6;
        private TextBox Datum_Splatnosti_Textbox;
        private Label label4;
        private Label label5;
    }
}