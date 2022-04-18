

namespace EzivnostC
{
    public  partial class PrehledyF
    {
        private void setSt()
        {
            // 
            // tabPrehledy
            // 
            this.tabPrehledy.Controls.Add(this.MesicniPrehledyTab);
            this.tabPrehledy.Controls.Add(this.PrehledyPodleKategoriiTab);
            this.tabPrehledy.Controls.Add(this.PrijmyKatTab);
            this.tabPrehledy.Location = new System.Drawing.Point(12, 55);
            this.tabPrehledy.Name = "tabPrehledy";
            this.tabPrehledy.SelectedIndex = 0;
            this.tabPrehledy.Size = new System.Drawing.Size(1135, 530);
            this.tabPrehledy.TabIndex = 0;
            // 
            // MesicniPrehledyTab
            // 
            this.MesicniPrehledyTab.BackColor = System.Drawing.Color.White;
            this.MesicniPrehledyTab.Controls.Add(this.label3);
            this.MesicniPrehledyTab.Controls.Add(this.label1);
            this.MesicniPrehledyTab.Controls.Add(this.Vydaje_pie_chart);
            this.MesicniPrehledyTab.Controls.Add(this.PieChartPrijmy);
            this.MesicniPrehledyTab.Controls.Add(this.Zmenit_mesic_p_button);
            this.MesicniPrehledyTab.Controls.Add(this.tableLayoutPanel1);
            this.MesicniPrehledyTab.Location = new System.Drawing.Point(4, 22);
            this.MesicniPrehledyTab.Name = "MesicniPrehledyTab";
            this.MesicniPrehledyTab.Padding = new System.Windows.Forms.Padding(3);
            this.MesicniPrehledyTab.Size = new System.Drawing.Size(1127, 504);
            this.MesicniPrehledyTab.TabIndex = 0;
            this.MesicniPrehledyTab.Text = "Mesiční přehledy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Výdaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Příjmy:";
            // 
            // Vydaje_pie_chart
            // 
            this.Vydaje_pie_chart.Location = new System.Drawing.Point(680, 43);
            this.Vydaje_pie_chart.Name = "Vydaje_pie_chart";
            this.Vydaje_pie_chart.Size = new System.Drawing.Size(276, 260);
            this.Vydaje_pie_chart.TabIndex = 3;
            this.Vydaje_pie_chart.Text = "Přehledy podle kategorii";
            // 
            // PieChartPrijmy
            // 
            this.PieChartPrijmy.Location = new System.Drawing.Point(401, 43);
            this.PieChartPrijmy.Name = "PieChartPrijmy";
            this.PieChartPrijmy.Size = new System.Drawing.Size(257, 266);
            this.PieChartPrijmy.TabIndex = 2;
            this.PieChartPrijmy.Text = "Přehledy podle kategorii";
            // 
            // Zmenit_mesic_p_button
            // 
            this.Zmenit_mesic_p_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Zmenit_mesic_p_button.Location = new System.Drawing.Point(466, 399);
            this.Zmenit_mesic_p_button.Name = "Zmenit_mesic_p_button";
            this.Zmenit_mesic_p_button.Size = new System.Drawing.Size(141, 33);
            this.Zmenit_mesic_p_button.TabIndex = 1;
            this.Zmenit_mesic_p_button.Text = "Zvolit jiný měsíc";
            this.Zmenit_mesic_p_button.UseVisualStyleBackColor = true;
            this.Zmenit_mesic_p_button.Click += new System.EventHandler(this.Zmenit_mesic_p_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Label_Vynos_prehled);
            this.panel3.Controls.Add(this.VynosyLabel);
            this.panel3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.panel3.Location = new System.Drawing.Point(3, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 93);
            this.panel3.TabIndex = 2;
            // 
            // Label_Vynos_prehled
            // 
            this.Label_Vynos_prehled.AutoSize = true;
            this.Label_Vynos_prehled.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.Label_Vynos_prehled.Location = new System.Drawing.Point(3, 46);
            this.Label_Vynos_prehled.Name = "Label_Vynos_prehled";
            this.Label_Vynos_prehled.Size = new System.Drawing.Size(52, 21);
            this.Label_Vynos_prehled.TabIndex = 3;
            this.Label_Vynos_prehled.Text = "label3";
            // 
            // VynosyLabel
            // 
            this.VynosyLabel.AutoSize = true;
            this.VynosyLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VynosyLabel.Location = new System.Drawing.Point(3, 10);
            this.VynosyLabel.Name = "VynosyLabel";
            this.VynosyLabel.Size = new System.Drawing.Size(56, 21);
            this.VynosyLabel.TabIndex = 1;
            this.VynosyLabel.Text = "Výnos:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Label_vydaje_prehledy);
            this.panel2.Controls.Add(this.VydajeLabel);
            this.panel2.Location = new System.Drawing.Point(177, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 87);
            this.panel2.TabIndex = 1;
            // 
            // Label_vydaje_prehledy
            // 
            this.Label_vydaje_prehledy.AutoSize = true;
            this.Label_vydaje_prehledy.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.Label_vydaje_prehledy.Location = new System.Drawing.Point(8, 43);
            this.Label_vydaje_prehledy.Name = "Label_vydaje_prehledy";
            this.Label_vydaje_prehledy.Size = new System.Drawing.Size(52, 21);
            this.Label_vydaje_prehledy.TabIndex = 1;
            this.Label_vydaje_prehledy.Text = "label1";
            // 
            // VydajeLabel
            // 
            this.VydajeLabel.AutoSize = true;
            this.VydajeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VydajeLabel.Location = new System.Drawing.Point(3, 10);
            this.VydajeLabel.Name = "VydajeLabel";
            this.VydajeLabel.Size = new System.Drawing.Size(60, 21);
            this.VydajeLabel.TabIndex = 0;
            this.VydajeLabel.Text = "Výdaje:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Label_prijmy_prehledy);
            this.panel1.Controls.Add(this.PrijmyLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 87);
            this.panel1.TabIndex = 0;
            // 
            // Label_prijmy_prehledy
            // 
            this.Label_prijmy_prehledy.AutoSize = true;
            this.Label_prijmy_prehledy.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.Label_prijmy_prehledy.Location = new System.Drawing.Point(3, 43);
            this.Label_prijmy_prehledy.Name = "Label_prijmy_prehledy";
            this.Label_prijmy_prehledy.Size = new System.Drawing.Size(52, 21);
            this.Label_prijmy_prehledy.TabIndex = 2;
            this.Label_prijmy_prehledy.Text = "label2";
            // 
            // PrijmyLabel
            // 
            this.PrijmyLabel.AutoSize = true;
            this.PrijmyLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PrijmyLabel.Location = new System.Drawing.Point(3, 10);
            this.PrijmyLabel.Name = "PrijmyLabel";
            this.PrijmyLabel.Size = new System.Drawing.Size(58, 21);
            this.PrijmyLabel.TabIndex = 1;
            this.PrijmyLabel.Text = "Příjmy:";
            // 
            // PrehledyPodleKategoriiTab
            // 
            this.PrehledyPodleKategoriiTab.BackColor = System.Drawing.Color.Transparent;
            this.PrehledyPodleKategoriiTab.Controls.Add(this.panel5);
            this.PrehledyPodleKategoriiTab.Controls.Add(this.panel4);
            this.PrehledyPodleKategoriiTab.Controls.Add(this.C_Podle_Typu);
            this.PrehledyPodleKategoriiTab.Location = new System.Drawing.Point(4, 22);
            this.PrehledyPodleKategoriiTab.Name = "PrehledyPodleKategoriiTab";
            this.PrehledyPodleKategoriiTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrehledyPodleKategoriiTab.Size = new System.Drawing.Size(1127, 504);
            this.PrehledyPodleKategoriiTab.TabIndex = 1;
            this.PrehledyPodleKategoriiTab.Text = "Roční přehled podle typu";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Nacist_graf);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.comboBoxTyp);
            this.panel5.Location = new System.Drawing.Point(212, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 87);
            this.panel5.TabIndex = 5;
            // 
            // Nacist_graf
            // 
            this.Nacist_graf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nacist_graf.Location = new System.Drawing.Point(9, 59);
            this.Nacist_graf.Name = "Nacist_graf";
            this.Nacist_graf.Size = new System.Drawing.Size(82, 20);
            this.Nacist_graf.TabIndex = 2;
            this.Nacist_graf.Text = "Načíst";
            this.Nacist_graf.UseVisualStyleBackColor = false;
            this.Nacist_graf.Click += new System.EventHandler(this.Nacist_graf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vyberte typ příjmu/výdaje";
            // 
            // comboBoxTyp
            // 
            this.comboBoxTyp.FormattingEnabled = true;
            this.comboBoxTyp.Location = new System.Drawing.Point(9, 34);
            this.comboBoxTyp.Name = "comboBoxTyp";
            this.comboBoxTyp.Size = new System.Drawing.Size(104, 21);
            this.comboBoxTyp.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioButtonVydaj);
            this.panel4.Controls.Add(this.radioButtonPrijem);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 87);
            this.panel4.TabIndex = 2;
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
            // C_Podle_Typu
            // 
            this.C_Podle_Typu.Location = new System.Drawing.Point(6, 161);
            this.C_Podle_Typu.Name = "C_Podle_Typu";
            this.C_Podle_Typu.Size = new System.Drawing.Size(1101, 337);
            this.C_Podle_Typu.TabIndex = 0;
            this.C_Podle_Typu.Text = "cartesianChart1";
            // 
            // PrijmyKatTab
            // 
            this.PrijmyKatTab.Controls.Add(this.label5);
            this.PrijmyKatTab.Controls.Add(this.C_prehled_vynosů);
            this.PrijmyKatTab.Location = new System.Drawing.Point(4, 22);
            this.PrijmyKatTab.Name = "PrijmyKatTab";
            this.PrijmyKatTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrijmyKatTab.Size = new System.Drawing.Size(1127, 504);
            this.PrijmyKatTab.TabIndex = 2;
            this.PrijmyKatTab.Text = "Roční přehled výnosů";
            this.PrijmyKatTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(32, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Přehled výnosů:";
            // 
            // C_prehled_vynosů
            // 
            this.C_prehled_vynosů.Location = new System.Drawing.Point(6, 139);
            this.C_prehled_vynosů.Name = "C_prehled_vynosů";
            this.C_prehled_vynosů.Size = new System.Drawing.Size(1091, 365);
            this.C_prehled_vynosů.TabIndex = 1;
            this.C_prehled_vynosů.Text = "cartesianChart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Přehledy:";
            // 
            // PrehledyF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabPrehledy);
            this.Name = "PrehledyF";
            this.Text = " ";
            this.tabPrehledy.ResumeLayout(false);
            this.MesicniPrehledyTab.ResumeLayout(false);
            this.MesicniPrehledyTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PrehledyPodleKategoriiTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PrijmyKatTab.ResumeLayout(false);
            this.PrijmyKatTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();


        }
    }
}
