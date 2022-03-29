using System.Windows.Forms;

namespace EzivnostC
{
    partial class Main
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
        private void InitializeComponent()
        {
            this.Menu_pan = new System.Windows.Forms.Panel();
            this.Ulozeni_faktur_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableProfil = new System.Windows.Forms.TableLayoutPanel();
            this.datavydelekzatotoobdobílabel = new System.Windows.Forms.Label();
            this.dataprumernyvydelek = new System.Windows.Forms.Label();
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
            this.Menu_pan.SuspendLayout();
            this.tableProfil.SuspendLayout();
            this.MenuTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_pan
            // 
            this.Menu_pan.Controls.Add(this.tableProfil);
            this.Menu_pan.Controls.Add(this.Ulozeni_faktur_panel);
            this.Menu_pan.Controls.Add(this.MenuTablePanel);
            this.Menu_pan.Location = new System.Drawing.Point(1, 8);
            this.Menu_pan.Name = "Menu_pan";
            this.Menu_pan.Size = new System.Drawing.Size(1183, 745);
            this.Menu_pan.TabIndex = 8;
            this.Menu_pan.Visible = false;
            // 
            // Ulozeni_faktur_panel
            // 
            this.Ulozeni_faktur_panel.BackColor = System.Drawing.Color.White;
            this.Ulozeni_faktur_panel.Location = new System.Drawing.Point(193, 0);
            this.Ulozeni_faktur_panel.Margin = new System.Windows.Forms.Padding(10);
            this.Ulozeni_faktur_panel.Name = "Ulozeni_faktur_panel";
            this.Ulozeni_faktur_panel.Size = new System.Drawing.Size(990, 745);
            this.Ulozeni_faktur_panel.TabIndex = 1;
            this.Ulozeni_faktur_panel.Visible = false;
            // 
            // tableProfil
            // 
            this.tableProfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableProfil.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableProfil.ColumnCount = 2;
            this.tableProfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProfil.Controls.Add(this.datavydelekzatotoobdobílabel, 0, 9);
            this.tableProfil.Controls.Add(this.dataprumernyvydelek, 0, 9);
            this.tableProfil.Controls.Add(this.labeltelcis, 1, 2);
            this.tableProfil.Controls.Add(this.labelemail, 0, 2);
            this.tableProfil.Controls.Add(this.dataprijmenilabel, 1, 1);
            this.tableProfil.Controls.Add(this.datajmenolabel, 0, 1);
            this.tableProfil.Controls.Add(this.labelPrijmeni, 1, 0);
            this.tableProfil.Controls.Add(this.labelJmeno, 0, 0);
            this.tableProfil.Controls.Add(this.dataemaillabel, 0, 3);
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
            this.tableProfil.Controls.Add(this.datatelcislolabel, 1, 3);
            this.tableProfil.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableProfil.ForeColor = System.Drawing.Color.White;
            this.tableProfil.Location = new System.Drawing.Point(222, 25);
            this.tableProfil.Name = "tableProfil";
            this.tableProfil.RowCount = 10;
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableProfil.Size = new System.Drawing.Size(597, 575);
            this.tableProfil.TabIndex = 0;
            // 
            // datavydelekzatotoobdobílabel
            // 
            this.datavydelekzatotoobdobílabel.AutoSize = true;
            this.datavydelekzatotoobdobílabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datavydelekzatotoobdobílabel.ForeColor = System.Drawing.Color.White;
            this.datavydelekzatotoobdobílabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datavydelekzatotoobdobílabel.Location = new System.Drawing.Point(13, 510);
            this.datavydelekzatotoobdobílabel.Margin = new System.Windows.Forms.Padding(10);
            this.datavydelekzatotoobdobílabel.Name = "datavydelekzatotoobdobílabel";
            this.datavydelekzatotoobdobílabel.Size = new System.Drawing.Size(55, 24);
            this.datavydelekzatotoobdobílabel.TabIndex = 10;
            this.datavydelekzatotoobdobílabel.Text = "label12";
            // 
            // dataprumernyvydelek
            // 
            this.dataprumernyvydelek.AutoSize = true;
            this.dataprumernyvydelek.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataprumernyvydelek.ForeColor = System.Drawing.Color.White;
            this.dataprumernyvydelek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataprumernyvydelek.Location = new System.Drawing.Point(310, 510);
            this.dataprumernyvydelek.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.dataprumernyvydelek.Name = "dataprumernyvydelek";
            this.dataprumernyvydelek.Size = new System.Drawing.Size(50, 24);
            this.dataprumernyvydelek.TabIndex = 9;
            this.dataprumernyvydelek.Text = "label9";
            // 
            // labeltelcis
            // 
            this.labeltelcis.AutoSize = true;
            this.labeltelcis.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltelcis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeltelcis.Location = new System.Drawing.Point(310, 129);
            this.labeltelcis.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labeltelcis.Name = "labeltelcis";
            this.labeltelcis.Size = new System.Drawing.Size(118, 20);
            this.labeltelcis.TabIndex = 7;
            this.labeltelcis.Text = "Telefonní číslo:";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelemail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelemail.Location = new System.Drawing.Point(13, 129);
            this.labelemail.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(55, 20);
            this.labelemail.TabIndex = 6;
            this.labelemail.Text = "Email:";
            // 
            // dataprijmenilabel
            // 
            this.dataprijmenilabel.AutoSize = true;
            this.dataprijmenilabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataprijmenilabel.ForeColor = System.Drawing.Color.White;
            this.dataprijmenilabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataprijmenilabel.Location = new System.Drawing.Point(310, 46);
            this.dataprijmenilabel.Margin = new System.Windows.Forms.Padding(10);
            this.dataprijmenilabel.Name = "dataprijmenilabel";
            this.dataprijmenilabel.Size = new System.Drawing.Size(50, 24);
            this.dataprijmenilabel.TabIndex = 4;
            this.dataprijmenilabel.Text = "label8";
            // 
            // datajmenolabel
            // 
            this.datajmenolabel.AutoSize = true;
            this.datajmenolabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datajmenolabel.ForeColor = System.Drawing.Color.White;
            this.datajmenolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datajmenolabel.Location = new System.Drawing.Point(13, 46);
            this.datajmenolabel.Margin = new System.Windows.Forms.Padding(10);
            this.datajmenolabel.Name = "datajmenolabel";
            this.datajmenolabel.Size = new System.Drawing.Size(49, 24);
            this.datajmenolabel.TabIndex = 3;
            this.datajmenolabel.Text = "label7";
            // 
            // labelPrijmeni
            // 
            this.labelPrijmeni.AutoSize = true;
            this.labelPrijmeni.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrijmeni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPrijmeni.Location = new System.Drawing.Point(310, 13);
            this.labelPrijmeni.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelPrijmeni.Name = "labelPrijmeni";
            this.labelPrijmeni.Size = new System.Drawing.Size(76, 20);
            this.labelPrijmeni.TabIndex = 1;
            this.labelPrijmeni.Text = "Prijmeni:";
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJmeno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelJmeno.Location = new System.Drawing.Point(13, 13);
            this.labelJmeno.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(58, 20);
            this.labelJmeno.TabIndex = 0;
            this.labelJmeno.Text = "Jmeno:";
            // 
            // dataemaillabel
            // 
            this.dataemaillabel.AutoSize = true;
            this.dataemaillabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataemaillabel.ForeColor = System.Drawing.Color.White;
            this.dataemaillabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataemaillabel.Location = new System.Drawing.Point(13, 162);
            this.dataemaillabel.Margin = new System.Windows.Forms.Padding(10);
            this.dataemaillabel.Name = "dataemaillabel";
            this.dataemaillabel.Size = new System.Drawing.Size(55, 24);
            this.dataemaillabel.TabIndex = 11;
            this.dataemaillabel.Text = "label13";
            // 
            // datatelcislolabel
            // 
            this.datatelcislolabel.AutoSize = true;
            this.datatelcislolabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datatelcislolabel.ForeColor = System.Drawing.Color.White;
            this.datatelcislolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datatelcislolabel.Location = new System.Drawing.Point(310, 162);
            this.datatelcislolabel.Margin = new System.Windows.Forms.Padding(10);
            this.datatelcislolabel.Name = "datatelcislolabel";
            this.datatelcislolabel.Size = new System.Drawing.Size(56, 24);
            this.datatelcislolabel.TabIndex = 12;
            this.datatelcislolabel.Text = "label14";
            // 
            // labelICO
            // 
            this.labelICO.AutoSize = true;
            this.labelICO.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelICO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelICO.Location = new System.Drawing.Point(13, 245);
            this.labelICO.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelICO.Name = "labelICO";
            this.labelICO.Size = new System.Drawing.Size(40, 20);
            this.labelICO.TabIndex = 13;
            this.labelICO.Text = "IČO:";
            // 
            // labelDIC
            // 
            this.labelDIC.AutoSize = true;
            this.labelDIC.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDIC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDIC.Location = new System.Drawing.Point(310, 245);
            this.labelDIC.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelDIC.Name = "labelDIC";
            this.labelDIC.Size = new System.Drawing.Size(40, 20);
            this.labelDIC.TabIndex = 14;
            this.labelDIC.Text = "DIČ:";
            // 
            // dataicolabel
            // 
            this.dataicolabel.AutoSize = true;
            this.dataicolabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataicolabel.ForeColor = System.Drawing.Color.White;
            this.dataicolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataicolabel.Location = new System.Drawing.Point(13, 278);
            this.dataicolabel.Margin = new System.Windows.Forms.Padding(10);
            this.dataicolabel.Name = "dataicolabel";
            this.dataicolabel.Size = new System.Drawing.Size(55, 24);
            this.dataicolabel.TabIndex = 15;
            this.dataicolabel.Text = "label17";
            // 
            // datadiclabel
            // 
            this.datadiclabel.AutoSize = true;
            this.datadiclabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datadiclabel.ForeColor = System.Drawing.Color.White;
            this.datadiclabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datadiclabel.Location = new System.Drawing.Point(310, 278);
            this.datadiclabel.Margin = new System.Windows.Forms.Padding(10);
            this.datadiclabel.Name = "datadiclabel";
            this.datadiclabel.Size = new System.Drawing.Size(56, 24);
            this.datadiclabel.TabIndex = 16;
            this.datadiclabel.Text = "label18";
            // 
            // labeladresa
            // 
            this.labeladresa.AutoSize = true;
            this.labeladresa.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeladresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeladresa.Location = new System.Drawing.Point(13, 361);
            this.labeladresa.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labeladresa.Name = "labeladresa";
            this.labeladresa.Size = new System.Drawing.Size(63, 20);
            this.labeladresa.TabIndex = 17;
            this.labeladresa.Text = "Adresa:";
            // 
            // labelvydelekzamesic
            // 
            this.labelvydelekzamesic.AutoSize = true;
            this.labelvydelekzamesic.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelvydelekzamesic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelvydelekzamesic.Location = new System.Drawing.Point(310, 361);
            this.labelvydelekzamesic.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labelvydelekzamesic.Name = "labelvydelekzamesic";
            this.labelvydelekzamesic.Size = new System.Drawing.Size(178, 20);
            this.labelvydelekzamesic.TabIndex = 18;
            this.labelvydelekzamesic.Text = "Výdělek za tento měsic:";
            // 
            // dataadresalabel
            // 
            this.dataadresalabel.AutoSize = true;
            this.dataadresalabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataadresalabel.ForeColor = System.Drawing.Color.White;
            this.dataadresalabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataadresalabel.Location = new System.Drawing.Point(13, 394);
            this.dataadresalabel.Margin = new System.Windows.Forms.Padding(10);
            this.dataadresalabel.Name = "dataadresalabel";
            this.dataadresalabel.Size = new System.Drawing.Size(55, 24);
            this.dataadresalabel.TabIndex = 19;
            this.dataadresalabel.Text = "label21";
            // 
            // datavydelekzamesiclabel
            // 
            this.datavydelekzamesiclabel.AutoSize = true;
            this.datavydelekzamesiclabel.Font = new System.Drawing.Font("Sitka Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datavydelekzamesiclabel.ForeColor = System.Drawing.Color.White;
            this.datavydelekzamesiclabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datavydelekzamesiclabel.Location = new System.Drawing.Point(310, 394);
            this.datavydelekzamesiclabel.Margin = new System.Windows.Forms.Padding(10);
            this.datavydelekzamesiclabel.Name = "datavydelekzamesiclabel";
            this.datavydelekzamesiclabel.Size = new System.Drawing.Size(57, 24);
            this.datavydelekzamesiclabel.TabIndex = 20;
            this.datavydelekzamesiclabel.Text = "label22";
            // 
            // labevydelekzarok
            // 
            this.labevydelekzarok.AutoSize = true;
            this.labevydelekzarok.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labevydelekzarok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labevydelekzarok.Location = new System.Drawing.Point(13, 477);
            this.labevydelekzarok.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labevydelekzarok.Name = "labevydelekzarok";
            this.labevydelekzarok.Size = new System.Drawing.Size(234, 20);
            this.labevydelekzarok.TabIndex = 21;
            this.labevydelekzarok.Text = "Výdělek za toto danove období:";
            // 
            // LabelPrůměrnyvydelek
            // 
            this.LabelPrůměrnyvydelek.AutoSize = true;
            this.LabelPrůměrnyvydelek.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPrůměrnyvydelek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPrůměrnyvydelek.Location = new System.Drawing.Point(310, 477);
            this.LabelPrůměrnyvydelek.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LabelPrůměrnyvydelek.Name = "LabelPrůměrnyvydelek";
            this.LabelPrůměrnyvydelek.Size = new System.Drawing.Size(207, 20);
            this.LabelPrůměrnyvydelek.TabIndex = 22;
            this.LabelPrůměrnyvydelek.Text = "Průměrný měsiční výdělek:";
            // 
            // MenuTablePanel
            // 
            this.MenuTablePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuTablePanel.ColumnCount = 1;
            this.MenuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MenuTablePanel.Controls.Add(this.button10, 0, 5);
            this.MenuTablePanel.Controls.Add(this.button9, 0, 4);
            this.MenuTablePanel.Controls.Add(this.button8, 0, 3);
            this.MenuTablePanel.Controls.Add(this.button7, 0, 2);
            this.MenuTablePanel.Controls.Add(this.button6, 0, 1);
            this.MenuTablePanel.Controls.Add(this.profilmenubutton, 0, 0);
            this.MenuTablePanel.Location = new System.Drawing.Point(0, 0);
            this.MenuTablePanel.Name = "MenuTablePanel";
            this.MenuTablePanel.RowCount = 6;
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MenuTablePanel.Size = new System.Drawing.Size(193, 600);
            this.MenuTablePanel.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(25, 525);
            this.button10.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 50);
            this.button10.TabIndex = 5;
            this.button10.Text = "Nastavení";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(25, 425);
            this.button9.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 50);
            this.button9.TabIndex = 4;
            this.button9.Text = "Tipy";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(25, 325);
            this.button8.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 50);
            this.button8.TabIndex = 3;
            this.button8.Text = "Co platím?";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(25, 225);
            this.button7.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 50);
            this.button7.TabIndex = 2;
            this.button7.Text = "Psolat fakturu";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(25, 125);
            this.button6.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 50);
            this.button6.TabIndex = 1;
            this.button6.Text = "Uložení faktur";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // profilmenubutton
            // 
            this.profilmenubutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profilmenubutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.profilmenubutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profilmenubutton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profilmenubutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profilmenubutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.profilmenubutton.Location = new System.Drawing.Point(25, 25);
            this.profilmenubutton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.profilmenubutton.Name = "profilmenubutton";
            this.profilmenubutton.Size = new System.Drawing.Size(150, 50);
            this.profilmenubutton.TabIndex = 0;
            this.profilmenubutton.Text = "Profil";
            this.profilmenubutton.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Menu_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Registrace";
            this.Menu_pan.ResumeLayout(false);
            this.tableProfil.ResumeLayout(false);
            this.tableProfil.PerformLayout();
            this.MenuTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Menu_pan;
        private FlowLayoutPanel Ulozeni_faktur_panel;
        private TableLayoutPanel tableProfil;
        private Label datavydelekzatotoobdobílabel;
        private Label dataprumernyvydelek;
        private Label labeltelcis;
        private Label labelemail;
        private Label dataprijmenilabel;
        private Label datajmenolabel;
        private Label labelPrijmeni;
        private Label labelJmeno;
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
        private TableLayoutPanel MenuTablePanel;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button profilmenubutton;
    }
}