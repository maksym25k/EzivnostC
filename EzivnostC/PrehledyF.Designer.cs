namespace EzivnostC
{
    partial class PrehledyF
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
            this.tabPrehledy = new System.Windows.Forms.TabControl();
            this.MesicniPrehledyTab = new System.Windows.Forms.TabPage();
            this.Vydaje_pie_chart = new LiveCharts.WinForms.PieChart();
            this.PieChartPrijmy = new LiveCharts.WinForms.PieChart();
            this.Zmenit_mesic_p_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_Vynos_prehled = new System.Windows.Forms.Label();
            this.VynosyLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_vydaje_prehledy = new System.Windows.Forms.Label();
            this.VydajeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_prijmy_prehledy = new System.Windows.Forms.Label();
            this.PrijmyLabel = new System.Windows.Forms.Label();
            this.PrehledyPodleKategoriiTab = new System.Windows.Forms.TabPage();
            this.PrijmyKatTab = new System.Windows.Forms.TabPage();
            this.tabPrehledy.SuspendLayout();
            this.MesicniPrehledyTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrehledy
            // 
            this.tabPrehledy.Controls.Add(this.MesicniPrehledyTab);
            this.tabPrehledy.Controls.Add(this.PrehledyPodleKategoriiTab);
            this.tabPrehledy.Controls.Add(this.PrijmyKatTab);
            this.tabPrehledy.Location = new System.Drawing.Point(12, 55);
            this.tabPrehledy.Name = "tabPrehledy";
            this.tabPrehledy.SelectedIndex = 0;
            this.tabPrehledy.Size = new System.Drawing.Size(970, 530);
            this.tabPrehledy.TabIndex = 0;
            // 
            // MesicniPrehledyTab
            // 
            this.MesicniPrehledyTab.BackColor = System.Drawing.Color.White;
            this.MesicniPrehledyTab.Controls.Add(this.Vydaje_pie_chart);
            this.MesicniPrehledyTab.Controls.Add(this.PieChartPrijmy);
            this.MesicniPrehledyTab.Controls.Add(this.Zmenit_mesic_p_button);
            this.MesicniPrehledyTab.Controls.Add(this.tableLayoutPanel1);
            this.MesicniPrehledyTab.Location = new System.Drawing.Point(4, 22);
            this.MesicniPrehledyTab.Name = "MesicniPrehledyTab";
            this.MesicniPrehledyTab.Padding = new System.Windows.Forms.Padding(3);
            this.MesicniPrehledyTab.Size = new System.Drawing.Size(962, 504);
            this.MesicniPrehledyTab.TabIndex = 0;
            this.MesicniPrehledyTab.Text = "Mesiční přehledy";
            // 
            // Vydaje_pie_chart
            // 
            this.Vydaje_pie_chart.Location = new System.Drawing.Point(659, 266);
            this.Vydaje_pie_chart.Name = "Vydaje_pie_chart";
            this.Vydaje_pie_chart.Size = new System.Drawing.Size(303, 238);
            this.Vydaje_pie_chart.TabIndex = 3;
            this.Vydaje_pie_chart.Text = "Přehledy podle kategorii";
            this.Vydaje_pie_chart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.Vydaje_pie_chart_ChildChanged);
            // 
            // PieChartPrijmy
            // 
            this.PieChartPrijmy.Location = new System.Drawing.Point(659, 3);
            this.PieChartPrijmy.Name = "PieChartPrijmy";
            this.PieChartPrijmy.Size = new System.Drawing.Size(303, 248);
            this.PieChartPrijmy.TabIndex = 2;
            this.PieChartPrijmy.Text = "Přehledy podle kategorii";
            this.PieChartPrijmy.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // Zmenit_mesic_p_button
            // 
            this.Zmenit_mesic_p_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Zmenit_mesic_p_button.Location = new System.Drawing.Point(36, 297);
            this.Zmenit_mesic_p_button.Name = "Zmenit_mesic_p_button";
            this.Zmenit_mesic_p_button.Size = new System.Drawing.Size(141, 33);
            this.Zmenit_mesic_p_button.TabIndex = 1;
            this.Zmenit_mesic_p_button.Text = "Zvolit jiný měsíc";
            this.Zmenit_mesic_p_button.UseVisualStyleBackColor = true;
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
            this.PrehledyPodleKategoriiTab.Location = new System.Drawing.Point(4, 22);
            this.PrehledyPodleKategoriiTab.Name = "PrehledyPodleKategoriiTab";
            this.PrehledyPodleKategoriiTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrehledyPodleKategoriiTab.Size = new System.Drawing.Size(962, 504);
            this.PrehledyPodleKategoriiTab.TabIndex = 1;
            this.PrehledyPodleKategoriiTab.Text = "Výdaje podle typu";
            // 
            // PrijmyKatTab
            // 
            this.PrijmyKatTab.Location = new System.Drawing.Point(4, 22);
            this.PrijmyKatTab.Name = "PrijmyKatTab";
            this.PrijmyKatTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrijmyKatTab.Size = new System.Drawing.Size(962, 504);
            this.PrijmyKatTab.TabIndex = 2;
            this.PrijmyKatTab.Text = "Příjmy podle typu";
            this.PrijmyKatTab.UseVisualStyleBackColor = true;
            // 
            // PrehledyF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 597);
            this.Controls.Add(this.tabPrehledy);
            this.Name = "PrehledyF";
            this.Text = " ";
            this.tabPrehledy.ResumeLayout(false);
            this.MesicniPrehledyTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrehledy;
        private System.Windows.Forms.TabPage MesicniPrehledyTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Label_Vynos_prehled;
        private System.Windows.Forms.Label VynosyLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_vydaje_prehledy;
        private System.Windows.Forms.Label VydajeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_prijmy_prehledy;
        private System.Windows.Forms.Label PrijmyLabel;
        private System.Windows.Forms.TabPage PrehledyPodleKategoriiTab;
        private System.Windows.Forms.TabPage PrijmyKatTab;
        private System.Windows.Forms.Button Zmenit_mesic_p_button;
        private LiveCharts.WinForms.PieChart PieChartPrijmy;
        private LiveCharts.WinForms.PieChart Vydaje_pie_chart;
    }
}