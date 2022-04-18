using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzivnostC
{
    public partial class Menu
    {


        private void set_St2()
        {
            // 
            // Menu_pan
            // 
            this.Menu_pan.Controls.Add(this.FormularProUlozeniFaktury);
            this.Menu_pan.Controls.Add(this.tableProfil);
            this.Menu_pan.Controls.Add(this.MenuTablePanel);
            this.Menu_pan.Location = new System.Drawing.Point(1, 7);
            this.Menu_pan.Name = "Menu_pan";
            this.Menu_pan.Size = new System.Drawing.Size(1171, 646);
            this.Menu_pan.TabIndex = 8;
            // 
            // FormularProUlozeniFaktury
            // 
            this.FormularProUlozeniFaktury.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FormularProUlozeniFaktury.ColumnCount = 4;
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.FormularProUlozeniFaktury.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
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
            this.FormularProUlozeniFaktury.Size = new System.Drawing.Size(843, 218);
            this.FormularProUlozeniFaktury.TabIndex = 0;
            this.FormularProUlozeniFaktury.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
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
            this.Datum_Splatnosti_Textbox.TextChanged += new System.EventHandler(this.Datum_Splatnosti_Textbox_TextChanged);
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
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxTyp);
            this.panel3.Location = new System.Drawing.Point(418, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 87);
            this.panel3.TabIndex = 4;
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



        }

    }
}
