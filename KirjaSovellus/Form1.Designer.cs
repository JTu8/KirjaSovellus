namespace KirjaSovellus
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbKirjailija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKirja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.dateLainaus = new System.Windows.Forms.DateTimePicker();
            this.btnNaytaKirjat = new System.Windows.Forms.Button();
            this.dateOsto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisää kirja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kirjailija";
            // 
            // tbKirjailija
            // 
            this.tbKirjailija.Location = new System.Drawing.Point(115, 75);
            this.tbKirjailija.Name = "tbKirjailija";
            this.tbKirjailija.Size = new System.Drawing.Size(125, 20);
            this.tbKirjailija.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kirja";
            // 
            // tbKirja
            // 
            this.tbKirja.Location = new System.Drawing.Point(115, 123);
            this.tbKirja.Name = "tbKirja";
            this.tbKirja.Size = new System.Drawing.Size(125, 20);
            this.tbKirja.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lainauspäivämäärä";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(40, 310);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(136, 48);
            this.btnLisaa.TabIndex = 7;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // dateLainaus
            // 
            this.dateLainaus.Location = new System.Drawing.Point(40, 190);
            this.dateLainaus.Name = "dateLainaus";
            this.dateLainaus.Size = new System.Drawing.Size(200, 20);
            this.dateLainaus.TabIndex = 8;
            // 
            // btnNaytaKirjat
            // 
            this.btnNaytaKirjat.Location = new System.Drawing.Point(382, 310);
            this.btnNaytaKirjat.Name = "btnNaytaKirjat";
            this.btnNaytaKirjat.Size = new System.Drawing.Size(136, 48);
            this.btnNaytaKirjat.TabIndex = 9;
            this.btnNaytaKirjat.Text = "Näytä kirjat";
            this.btnNaytaKirjat.UseVisualStyleBackColor = true;
            this.btnNaytaKirjat.Click += new System.EventHandler(this.btnNaytaKirjat_Click);
            // 
            // dateOsto
            // 
            this.dateOsto.Location = new System.Drawing.Point(40, 265);
            this.dateOsto.Name = "dateOsto";
            this.dateOsto.Size = new System.Drawing.Size(200, 20);
            this.dateOsto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Osto/saantipäivämäärä";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOsto);
            this.Controls.Add(this.btnNaytaKirjat);
            this.Controls.Add(this.dateLainaus);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKirja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKirjailija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kirjan lisäys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKirjailija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKirja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.DateTimePicker dateLainaus;
        private System.Windows.Forms.Button btnNaytaKirjat;
        private System.Windows.Forms.DateTimePicker dateOsto;
        private System.Windows.Forms.Label label5;
    }
}

