using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzivnostC
{
    public partial class Menu
    {
        private void set_St3()
        {
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
            this.MenuTablePanel.Controls.Add(this.PrehledyButton, 0, 2);
            this.MenuTablePanel.Controls.Add(this.Ulozenifaktury_menu_button, 0, 1);
            this.MenuTablePanel.Controls.Add(this.profilmenubutton, 0, 0);
            this.MenuTablePanel.Controls.Add(this.button8, 0, 3);
            this.MenuTablePanel.Controls.Add(this.button10, 0, 4);
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
            // PrehledyButton
            // 
            this.PrehledyButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrehledyButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PrehledyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrehledyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.PrehledyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrehledyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrehledyButton.Location = new System.Drawing.Point(21, 189);
            this.PrehledyButton.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.PrehledyButton.Name = "PrehledyButton";
            this.PrehledyButton.Size = new System.Drawing.Size(129, 57);
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
            this.Ulozenifaktury_menu_button.Location = new System.Drawing.Point(21, 102);
            this.Ulozenifaktury_menu_button.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.Ulozenifaktury_menu_button.Name = "Ulozenifaktury_menu_button";
            this.Ulozenifaktury_menu_button.Size = new System.Drawing.Size(129, 56);
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
            this.profilmenubutton.Location = new System.Drawing.Point(21, 15);
            this.profilmenubutton.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.profilmenubutton.Name = "profilmenubutton";
            this.profilmenubutton.Size = new System.Drawing.Size(129, 56);
            this.profilmenubutton.TabIndex = 0;
            this.profilmenubutton.Text = "Profil";
            this.profilmenubutton.UseVisualStyleBackColor = false;
            this.profilmenubutton.Click += new System.EventHandler(this.profilmenubutton_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(21, 276);
            this.button8.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 56);
            this.button8.TabIndex = 3;
            this.button8.Text = "Správa faktur";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(21, 363);
            this.button10.Margin = new System.Windows.Forms.Padding(21, 3, 3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 56);
            this.button10.TabIndex = 5;
            this.button10.Text = "Nastavení";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // openFileSkenFaktury
            // 
            this.openFileSkenFaktury.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ve formátu: RRRR-MM-DD";



        }



    }
}
