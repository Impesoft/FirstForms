
namespace _20210112Dag1AdvandedC
{
    partial class Rommelzin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayLabels = new System.Windows.Forms.Button();
            this.Naam = new System.Windows.Forms.TextBox();
            this.FavoFilm = new System.Windows.Forms.TextBox();
            this.FavoKleur = new System.Windows.Forms.TextBox();
            this.CorrecteZin = new System.Windows.Forms.Label();
            this.RommelZin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leeftijd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uw naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uw favoriete film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uw favoriete kleur";
            // 
            // DisplayLabels
            // 
            this.DisplayLabels.Enabled = false;
            this.DisplayLabels.Location = new System.Drawing.Point(121, 177);
            this.DisplayLabels.Name = "DisplayLabels";
            this.DisplayLabels.Size = new System.Drawing.Size(100, 23);
            this.DisplayLabels.TabIndex = 3;
            this.DisplayLabels.Text = "info missing";
            this.DisplayLabels.UseVisualStyleBackColor = true;
            this.DisplayLabels.Click += new System.EventHandler(this.DisplayLabels_Click);
            // 
            // Naam
            // 
            this.Naam.Location = new System.Drawing.Point(121, 14);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(100, 23);
            this.Naam.TabIndex = 4;
            this.Naam.TextChanged += new System.EventHandler(this.Naam_TextChanged);
            // 
            // FavoFilm
            // 
            this.FavoFilm.Location = new System.Drawing.Point(121, 43);
            this.FavoFilm.Name = "FavoFilm";
            this.FavoFilm.Size = new System.Drawing.Size(100, 23);
            this.FavoFilm.TabIndex = 5;
            this.FavoFilm.TextChanged += new System.EventHandler(this.FavoFilm_TextChanged);
            // 
            // FavoKleur
            // 
            this.FavoKleur.Location = new System.Drawing.Point(121, 72);
            this.FavoKleur.Name = "FavoKleur";
            this.FavoKleur.Size = new System.Drawing.Size(100, 23);
            this.FavoKleur.TabIndex = 6;
            this.FavoKleur.TextChanged += new System.EventHandler(this.FavoKleur_TextChanged);
            // 
            // CorrecteZin
            // 
            this.CorrecteZin.AutoSize = true;
            this.CorrecteZin.Location = new System.Drawing.Point(121, 225);
            this.CorrecteZin.Name = "CorrecteZin";
            this.CorrecteZin.Size = new System.Drawing.Size(70, 15);
            this.CorrecteZin.TabIndex = 7;
            this.CorrecteZin.Text = "Correcte zin";
            // 
            // RommelZin
            // 
            this.RommelZin.AutoSize = true;
            this.RommelZin.Location = new System.Drawing.Point(121, 277);
            this.RommelZin.Name = "RommelZin";
            this.RommelZin.Size = new System.Drawing.Size(70, 15);
            this.RommelZin.TabIndex = 8;
            this.RommelZin.Text = "Rommel zin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Uw leeftijd";
            // 
            // leeftijd
            // 
            this.leeftijd.Location = new System.Drawing.Point(121, 101);
            this.leeftijd.Name = "leeftijd";
            this.leeftijd.Size = new System.Drawing.Size(100, 23);
            this.leeftijd.TabIndex = 10;
            this.leeftijd.TextChanged += new System.EventHandler(this.leeftijd_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leeftijd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RommelZin);
            this.Controls.Add(this.CorrecteZin);
            this.Controls.Add(this.FavoKleur);
            this.Controls.Add(this.FavoFilm);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.DisplayLabels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rommelzin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DisplayLabels;
        private System.Windows.Forms.TextBox Naam;
        private System.Windows.Forms.TextBox FavoFilm;
        private System.Windows.Forms.TextBox FavoKleur;
        private System.Windows.Forms.Label CorrecteZin;
        private System.Windows.Forms.Label RommelZin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox leeftijd;
    }
}

