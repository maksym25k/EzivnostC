namespace EzivnostC
{
    partial class Stahovani_faktur
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
            this.Zobrazení_faktur = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Zobrazení_faktur)).BeginInit();
            this.SuspendLayout();
            // 
            // Zobrazení_faktur
            // 
            this.Zobrazení_faktur.AllowUserToAddRows = false;
            this.Zobrazení_faktur.AllowUserToDeleteRows = false;
            this.Zobrazení_faktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Zobrazení_faktur.Location = new System.Drawing.Point(12, 103);
            this.Zobrazení_faktur.Name = "Zobrazení_faktur";
            this.Zobrazení_faktur.Size = new System.Drawing.Size(776, 335);
            this.Zobrazení_faktur.TabIndex = 0;
            this.Zobrazení_faktur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Zobrazení_faktur_CellClick_1);
            this.Zobrazení_faktur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Zobrazení_faktur_CellClick);
            this.Zobrazení_faktur.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Zobrazení_faktur_CellContentDoubleClick);
            this.Zobrazení_faktur.SelectionChanged += new System.EventHandler(this.Zobrazení_faktur_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vyberte fakturu pro provedení akce";
            // 
            // Stahovani_faktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zobrazení_faktur);
            this.Name = "Stahovani_faktur";
            this.Text = "Stahovani_faktur";
            ((System.ComponentModel.ISupportInitialize)(this.Zobrazení_faktur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Zobrazení_faktur;
        private System.Windows.Forms.Label label1;
    }
}