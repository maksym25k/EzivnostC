﻿using System.Windows.Forms;

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
        private void InitializeComponent()
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.PrehledyButton = new System.Windows.Forms.Button();
            this.Ulozenifaktury_menu_button = new System.Windows.Forms.Button();
            this.profilmenubutton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileSkenFaktury = new System.Windows.Forms.OpenFileDialog();
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
            // 
            // Menu_pan
            // 
            this.Menu_pan.Controls.Add(this.FormularProUlozeniFaktury);
            this.Menu_pan.Controls.Add(this.tableProfil);
            this.Menu_pan.Controls.Add(this.MenuTablePanel);
            this.Menu_pan.Location = new System.Drawing.Point(1, 7);
            this.Menu_pan.Name = "Menu_pan";
            this.Menu_pan.Size = new System.Drawing.Size(1014, 646);
            this.Menu_pan.TabIndex = 8;
            // 
            // FormularProUlozeniFaktury
            // 
            this.FormularProUlozeniFaktury.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FormularProUlozeniFaktury.ColumnCount = 4;
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.FormularProUlozeniFaktury.Controls.Add(this.panel6, 0, 1);
            this.FormularProUlozeniFaktury.Controls.Add(this.panel2, 2, 0);
            this.FormularProUlozeniFaktury.Controls.Add(this.panel4, 3, 0);
            this.FormularProUlozeniFaktury.Controls.Add(this.panel3, 0, 1);
            this.FormularProUlozeniFaktury.Controls.Add(this.Vybrat_soubor_Button_f, 0, 0);
            this.FormularProUlozeniFaktury.Controls.Add(this.panel5, 0, 1);
            this.FormularProUlozeniFaktury.Controls.Add(this.panel1, 1, 0);
            this.FormularProUlozeniFaktury.Controls.Add(this.button2, 3, 1);
            this.FormularProUlozeniFaktury.Location = new System.Drawing.Point(165, 0);
            this.FormularProUlozeniFaktury.Name = "FormularProUlozeniFaktury";
            this.FormularProUlozeniFaktury.RowCount = 2;
            this.FormularProUlozeniFaktury.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.FormularProUlozeniFaktury.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.FormularProUlozeniFaktury.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.FormularProUlozeniFaktury.Size = new System.Drawing.Size(838, 218);
            this.FormularProUlozeniFaktury.TabIndex = 0;
            this.FormularProUlozeniFaktury.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Datum_Splatnosti_Textbox);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(211, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 87);
            this.panel6.TabIndex = 8;
            // 
            // Datum_Splatnosti_Textbox
            // 
            this.Datum_Splatnosti_Textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Datum_Splatnosti_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Datum_Splatnosti_Textbox.Location = new System.Drawing.Point(3, 33);
            this.Datum_Splatnosti_Textbox.Name = "Datum_Splatnosti_Textbox";
            this.Datum_Splatnosti_Textbox.Size = new System.Drawing.Size(86, 20);
            this.Datum_Splatnosti_Textbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum splatnosti";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxCastka_Faktura);
            this.panel2.Controls.Add(this.LabelCastka);
            this.panel2.Location = new System.Drawing.Point(418, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 87);
            this.panel2.TabIndex = 2;
            // 
            // textBoxCastka_Faktura
            // 
            this.textBoxCastka_Faktura.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCastka_Faktura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCastka_Faktura.Location = new System.Drawing.Point(8, 33);
            this.textBoxCastka_Faktura.Name = "textBoxCastka_Faktura";
            this.textBoxCastka_Faktura.Size = new System.Drawing.Size(86, 20);
            this.textBoxCastka_Faktura.TabIndex = 1;
            // 
            // LabelCastka
            // 
            this.LabelCastka.AutoSize = true;
            this.LabelCastka.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.LabelCastka.Location = new System.Drawing.Point(3, 5);
            this.LabelCastka.Name = "LabelCastka";
            this.LabelCastka.Size = new System.Drawing.Size(55, 20);
            this.LabelCastka.TabIndex = 0;
            this.LabelCastka.Text = "Částka:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxPoznamka);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(640, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 87);
            this.panel4.TabIndex = 5;
            // 
            // textBoxPoznamka
            // 
            this.textBoxPoznamka.AcceptsTab = true;
            this.textBoxPoznamka.Location = new System.Drawing.Point(3, 34);
            this.textBoxPoznamka.Name = "textBoxPoznamka";
            this.textBoxPoznamka.Size = new System.Drawing.Size(185, 20);
            this.textBoxPoznamka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Poznámka:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxTyp);
            this.panel3.Location = new System.Drawing.Point(418, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 87);
            this.panel3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(9, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Přídat typ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vyberte typ příjmu/výdaje";
            // 
            // comboBoxTyp
            // 
            this.comboBoxTyp.FormattingEnabled = true;
            this.comboBoxTyp.Location = new System.Drawing.Point(9, 34);
            this.comboBoxTyp.Name = "comboBoxTyp";
            this.comboBoxTyp.Size = new System.Drawing.Size(104, 21);
            this.comboBoxTyp.TabIndex = 0;
            // 
            // Vybrat_soubor_Button_f
            // 
            this.Vybrat_soubor_Button_f.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Vybrat_soubor_Button_f.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Vybrat_soubor_Button_f.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Vybrat_soubor_Button_f.ForeColor = System.Drawing.Color.Black;
            this.Vybrat_soubor_Button_f.Location = new System.Drawing.Point(40, 40);
            this.Vybrat_soubor_Button_f.Margin = new System.Windows.Forms.Padding(39, 39, 3, 3);
            this.Vybrat_soubor_Button_f.Name = "Vybrat_soubor_Button_f";
            this.Vybrat_soubor_Button_f.Size = new System.Drawing.Size(129, 35);
            this.Vybrat_soubor_Button_f.TabIndex = 0;
            this.Vybrat_soubor_Button_f.Text = "Vybrat soubor";
            this.Vybrat_soubor_Button_f.UseVisualStyleBackColor = false;
            this.Vybrat_soubor_Button_f.Click += new System.EventHandler(this.Vybrat_soubor_Button_f_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxEv_cislo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(4, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 87);
            this.panel5.TabIndex = 6;
            // 
            // textBoxEv_cislo
            // 
            this.textBoxEv_cislo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxEv_cislo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEv_cislo.Location = new System.Drawing.Point(3, 32);
            this.textBoxEv_cislo.Name = "textBoxEv_cislo";
            this.textBoxEv_cislo.Size = new System.Drawing.Size(86, 20);
            this.textBoxEv_cislo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ev. číslo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonVydaj);
            this.panel1.Controls.Add(this.radioButtonPrijem);
            this.panel1.Location = new System.Drawing.Point(211, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 87);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonVydaj
            // 
            this.radioButtonVydaj.AutoSize = true;
            this.radioButtonVydaj.Location = new System.Drawing.Point(13, 48);
            this.radioButtonVydaj.Name = "radioButtonVydaj";
            this.radioButtonVydaj.Size = new System.Drawing.Size(51, 17);
            this.radioButtonVydaj.TabIndex = 1;
            this.radioButtonVydaj.TabStop = true;
            this.radioButtonVydaj.Text = "Výdaj";
            this.radioButtonVydaj.UseVisualStyleBackColor = true;
            this.radioButtonVydaj.CheckedChanged += new System.EventHandler(this.radioButtonVydaj_CheckedChanged);
            // 
            // radioButtonPrijem
            // 
            this.radioButtonPrijem.AutoSize = true;
            this.radioButtonPrijem.Location = new System.Drawing.Point(13, 18);
            this.radioButtonPrijem.Name = "radioButtonPrijem";
            this.radioButtonPrijem.Size = new System.Drawing.Size(56, 17);
            this.radioButtonPrijem.TabIndex = 0;
            this.radioButtonPrijem.TabStop = true;
            this.radioButtonPrijem.Text = "Příjem";
            this.radioButtonPrijem.UseVisualStyleBackColor = true;
            this.radioButtonPrijem.CheckedChanged += new System.EventHandler(this.radioButtonPrijem_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(680, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(43, 22, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Uložit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonUlozitfakturu_f_Click);
            // 
            // tableProfil
            // 
            this.tableProfil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableProfil.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableProfil.ColumnCount = 2;
            this.tableProfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableProfil.Controls.Add(this.labelemail, 0, 2);
            this.tableProfil.Controls.Add(this.dataprijmenilabel, 1, 1);
            this.tableProfil.Controls.Add(this.datajmenolabel, 0, 1);
            this.tableProfil.Controls.Add(this.labelPrijmeni, 1, 0);
            this.tableProfil.Controls.Add(this.labelJmeno, 0, 0);
            this.tableProfil.Controls.Add(this.dataprumernyvydelek, 1, 3);
            this.tableProfil.Controls.Add(this.Výnoszaměsic, 1, 2);
            this.tableProfil.Controls.Add(this.labelEmailProfil, 0, 3);
            this.tableProfil.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.tableProfil.ForeColor = System.Drawing.Color.White;
            this.tableProfil.Location = new System.Drawing.Point(171, 0);
            this.tableProfil.Name = "tableProfil";
            this.tableProfil.RowCount = 5;
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableProfil.Size = new System.Drawing.Size(512, 203);
            this.tableProfil.TabIndex = 0;
            this.tableProfil.Paint += new System.Windows.Forms.PaintEventHandler(this.tableProfil_Paint);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.labelemail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelemail.Location = new System.Drawing.Point(12, 113);
            this.labelemail.Margin = new System.Windows.Forms.Padding(9, 9, 3, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(55, 17);
            this.labelemail.TabIndex = 6;
            this.labelemail.Text = "Email:";
            // 
            // dataprijmenilabel
            // 
            this.dataprijmenilabel.AutoSize = true;
            this.dataprijmenilabel.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.dataprijmenilabel.ForeColor = System.Drawing.Color.White;
            this.dataprijmenilabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataprijmenilabel.Location = new System.Drawing.Point(266, 41);
            this.dataprijmenilabel.Margin = new System.Windows.Forms.Padding(9);
            this.dataprijmenilabel.Name = "dataprijmenilabel";
            this.dataprijmenilabel.Size = new System.Drawing.Size(60, 23);
            this.dataprijmenilabel.TabIndex = 4;
            this.dataprijmenilabel.Text = "label8";
            // 
            // datajmenolabel
            // 
            this.datajmenolabel.AutoSize = true;
            this.datajmenolabel.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.datajmenolabel.ForeColor = System.Drawing.Color.White;
            this.datajmenolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datajmenolabel.Location = new System.Drawing.Point(12, 41);
            this.datajmenolabel.Margin = new System.Windows.Forms.Padding(9);
            this.datajmenolabel.Name = "datajmenolabel";
            this.datajmenolabel.Size = new System.Drawing.Size(60, 23);
            this.datajmenolabel.TabIndex = 3;
            this.datajmenolabel.Text = "label7";
            // 
            // labelPrijmeni
            // 
            this.labelPrijmeni.AutoSize = true;
            this.labelPrijmeni.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.labelPrijmeni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPrijmeni.Location = new System.Drawing.Point(266, 12);
            this.labelPrijmeni.Margin = new System.Windows.Forms.Padding(9, 9, 3, 0);
            this.labelPrijmeni.Name = "labelPrijmeni";
            this.labelPrijmeni.Size = new System.Drawing.Size(76, 17);
            this.labelPrijmeni.TabIndex = 1;
            this.labelPrijmeni.Text = "Prijmeni:";
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.labelJmeno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelJmeno.Location = new System.Drawing.Point(12, 12);
            this.labelJmeno.Margin = new System.Windows.Forms.Padding(9, 9, 3, 0);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(58, 17);
            this.labelJmeno.TabIndex = 0;
            this.labelJmeno.Text = "Jmeno:";
            // 
            // dataprumernyvydelek
            // 
            this.dataprumernyvydelek.AutoSize = true;
            this.dataprumernyvydelek.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.dataprumernyvydelek.ForeColor = System.Drawing.Color.White;
            this.dataprumernyvydelek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataprumernyvydelek.Location = new System.Drawing.Point(266, 142);
            this.dataprumernyvydelek.Margin = new System.Windows.Forms.Padding(9, 9, 3, 0);
            this.dataprumernyvydelek.Name = "dataprumernyvydelek";
            this.dataprumernyvydelek.Size = new System.Drawing.Size(60, 23);
            this.dataprumernyvydelek.TabIndex = 9;
            this.dataprumernyvydelek.Text = "label9";
            // 
            // Výnoszaměsic
            // 
            this.Výnoszaměsic.AutoSize = true;
            this.Výnoszaměsic.Font = new System.Drawing.Font("Cambria", 12.75F);
            this.Výnoszaměsic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Výnoszaměsic.Location = new System.Drawing.Point(266, 113);
            this.Výnoszaměsic.Margin = new System.Windows.Forms.Padding(9, 9, 3, 0);
            this.Výnoszaměsic.Name = "Výnoszaměsic";
            this.Výnoszaměsic.Size = new System.Drawing.Size(167, 17);
            this.Výnoszaměsic.TabIndex = 22;
            this.Výnoszaměsic.Text = "Výnos za tenhle měsíc";
            // 
            // labelEmailProfil
            // 
            this.labelEmailProfil.AutoSize = true;
            this.labelEmailProfil.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F);
            this.labelEmailProfil.ForeColor = System.Drawing.Color.White;
            this.labelEmailProfil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmailProfil.Location = new System.Drawing.Point(12, 142);
            this.labelEmailProfil.Margin = new System.Windows.Forms.Padding(9);
            this.labelEmailProfil.Name = "labelEmailProfil";
            this.labelEmailProfil.Size = new System.Drawing.Size(70, 23);
            this.labelEmailProfil.TabIndex = 23;
            this.labelEmailProfil.Text = "label12";
            // 
            // MenuTablePanel
            // 
            this.MenuTablePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuTablePanel.ColumnCount = 1;
            this.MenuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.MenuTablePanel.Controls.Add(this.button10, 0, 5);
            this.MenuTablePanel.Controls.Add(this.PrehledyButton, 0, 2);
            this.MenuTablePanel.Controls.Add(this.Ulozenifaktury_menu_button, 0, 1);
            this.MenuTablePanel.Controls.Add(this.profilmenubutton, 0, 0);
            this.MenuTablePanel.Controls.Add(this.button9, 0, 4);
            this.MenuTablePanel.Controls.Add(this.button8, 0, 3);
            this.MenuTablePanel.Location = new System.Drawing.Point(0, 0);
            this.MenuTablePanel.Name = "MenuTablePanel";
            this.MenuTablePanel.RowCount = 6;
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.MenuTablePanel.Size = new System.Drawing.Size(165, 648);
            this.MenuTablePanel.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(21, 520);
            this.button10.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 43);
            this.button10.TabIndex = 5;
            this.button10.Text = "Nastavení";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(21, 283);
            this.button8.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 43);
            this.button8.TabIndex = 3;
            this.button8.Text = "Stažení faktur";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // PrehledyButton
            // 
            this.PrehledyButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrehledyButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PrehledyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrehledyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.PrehledyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrehledyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrehledyButton.Location = new System.Drawing.Point(21, 196);
            this.PrehledyButton.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.PrehledyButton.Name = "PrehledyButton";
            this.PrehledyButton.Size = new System.Drawing.Size(129, 43);
            this.PrehledyButton.TabIndex = 2;
            this.PrehledyButton.Text = "Přehled";
            this.PrehledyButton.UseVisualStyleBackColor = false;
            this.PrehledyButton.Click += new System.EventHandler(this.PrehledyButton_Click);
            // 
            // Ulozenifaktury_menu_button
            // 
            this.Ulozenifaktury_menu_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ulozenifaktury_menu_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Ulozenifaktury_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ulozenifaktury_menu_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Ulozenifaktury_menu_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ulozenifaktury_menu_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ulozenifaktury_menu_button.Location = new System.Drawing.Point(21, 109);
            this.Ulozenifaktury_menu_button.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.Ulozenifaktury_menu_button.Name = "Ulozenifaktury_menu_button";
            this.Ulozenifaktury_menu_button.Size = new System.Drawing.Size(129, 43);
            this.Ulozenifaktury_menu_button.TabIndex = 1;
            this.Ulozenifaktury_menu_button.Text = "Uložení faktur";
            this.Ulozenifaktury_menu_button.UseVisualStyleBackColor = false;
            this.Ulozenifaktury_menu_button.Click += new System.EventHandler(this.Ulozenifaktury_menu_button_Click);
            // 
            // profilmenubutton
            // 
            this.profilmenubutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profilmenubutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.profilmenubutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profilmenubutton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.profilmenubutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profilmenubutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.profilmenubutton.Location = new System.Drawing.Point(21, 22);
            this.profilmenubutton.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.profilmenubutton.Name = "profilmenubutton";
            this.profilmenubutton.Size = new System.Drawing.Size(129, 43);
            this.profilmenubutton.TabIndex = 0;
            this.profilmenubutton.Text = "Profil";
            this.profilmenubutton.UseVisualStyleBackColor = false;
            this.profilmenubutton.Click += new System.EventHandler(this.profilmenubutton_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(21, 370);
            this.button9.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 43);
            this.button9.TabIndex = 4;
            this.button9.Text = "Nápověda";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // openFileSkenFaktury
            // 
            this.openFileSkenFaktury.FileName = "openFileDialog1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1015, 660);
            this.Controls.Add(this.Menu_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private Button button9;
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
        private Button button1;
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
    }
}