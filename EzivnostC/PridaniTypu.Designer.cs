namespace EzivnostC
{
    partial class PridaniTypu
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
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ulozit_button = new System.Windows.Forms.Button();
            this.Prijem = new System.Windows.Forms.RadioButton();
            this.Vydaj = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // typTextBox
            // 
            this.typTextBox.Location = new System.Drawing.Point(12, 72);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.Size = new System.Drawing.Size(219, 20);
            this.typTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Napište sem název nového typu:";
            // 
            // Ulozit_button
            // 
            this.Ulozit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ulozit_button.Location = new System.Drawing.Point(251, 72);
            this.Ulozit_button.Name = "Ulozit_button";
            this.Ulozit_button.Size = new System.Drawing.Size(75, 33);
            this.Ulozit_button.TabIndex = 2;
            this.Ulozit_button.Text = "Uložit";
            this.Ulozit_button.UseVisualStyleBackColor = true;
            this.Ulozit_button.Click += new System.EventHandler(this.Ulozit_button_Click);
            // 
            // Prijem
            // 
            this.Prijem.AutoSize = true;
            this.Prijem.Location = new System.Drawing.Point(24, 13);
            this.Prijem.Name = "Prijem";
            this.Prijem.Size = new System.Drawing.Size(56, 17);
            this.Prijem.TabIndex = 3;
            this.Prijem.TabStop = true;
            this.Prijem.Text = "Příjem";
            this.Prijem.UseVisualStyleBackColor = true;
            // 
            // Vydaj
            // 
            this.Vydaj.AutoSize = true;
            this.Vydaj.Location = new System.Drawing.Point(115, 13);
            this.Vydaj.Name = "Vydaj";
            this.Vydaj.Size = new System.Drawing.Size(51, 17);
            this.Vydaj.TabIndex = 4;
            this.Vydaj.TabStop = true;
            this.Vydaj.Text = "Výdaj";
            this.Vydaj.UseVisualStyleBackColor = true;
            // 
            // PridaniTypu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 117);
            this.Controls.Add(this.Vydaj);
            this.Controls.Add(this.Prijem);
            this.Controls.Add(this.Ulozit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typTextBox);
            this.Name = "PridaniTypu";
            this.Text = "PridaniTypu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ulozit_button;
        private System.Windows.Forms.RadioButton Prijem;
        private System.Windows.Forms.RadioButton Vydaj;
    }
}