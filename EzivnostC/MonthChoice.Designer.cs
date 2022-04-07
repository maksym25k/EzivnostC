namespace EzivnostC
{
    partial class MonthChoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMesic = new System.Windows.Forms.TextBox();
            this.textBoxRok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OkButtonZadaniObdobí = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadejte prosím měsíc a rok";
            // 
            // textBoxMesic
            // 
            this.textBoxMesic.Location = new System.Drawing.Point(12, 85);
            this.textBoxMesic.Name = "textBoxMesic";
            
            this.textBoxMesic.Size = new System.Drawing.Size(100, 23);
            this.textBoxMesic.TabIndex = 1;
            // 
            // textBoxRok
            // 
            this.textBoxRok.Location = new System.Drawing.Point(172, 85);
            this.textBoxRok.Name = "textBoxRok";
            
            this.textBoxRok.Size = new System.Drawing.Size(100, 23);
            this.textBoxRok.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Měsíc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rok";
            // 
            // OkButtonZadaniObdobí
            // 
            this.OkButtonZadaniObdobí.Location = new System.Drawing.Point(172, 126);
            this.OkButtonZadaniObdobí.Name = "OkButtonZadaniObdobí";
            this.OkButtonZadaniObdobí.Size = new System.Drawing.Size(81, 23);
            this.OkButtonZadaniObdobí.TabIndex = 5;
            this.OkButtonZadaniObdobí.Text = "Ok";
            this.OkButtonZadaniObdobí.UseVisualStyleBackColor = true;
            this.OkButtonZadaniObdobí.Click += new System.EventHandler(this.OkButtonZadaniObdobí_Click);
            // 
            // MonthChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.OkButtonZadaniObdobí);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRok);
            this.Controls.Add(this.textBoxMesic);
            this.Controls.Add(this.label1);
            this.Name = "MonthChoice";
            this.Text = "MonthChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMesic;
        private System.Windows.Forms.TextBox textBoxRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OkButtonZadaniObdobí;
    }
}