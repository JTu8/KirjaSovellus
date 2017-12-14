namespace KirjaSovellus
{
    partial class NaytaKirjat
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
            this.dgShowKirjat = new System.Windows.Forms.DataGridView();
            this.btnNayta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowKirjat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjasi";
            // 
            // dgShowKirjat
            // 
            this.dgShowKirjat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowKirjat.Location = new System.Drawing.Point(107, 50);
            this.dgShowKirjat.Name = "dgShowKirjat";
            this.dgShowKirjat.Size = new System.Drawing.Size(369, 198);
            this.dgShowKirjat.TabIndex = 1;
            this.dgShowKirjat.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShowKirjat_RowValidated);
            // 
            // btnNayta
            // 
            this.btnNayta.Location = new System.Drawing.Point(107, 281);
            this.btnNayta.Name = "btnNayta";
            this.btnNayta.Size = new System.Drawing.Size(107, 39);
            this.btnNayta.TabIndex = 2;
            this.btnNayta.Text = "Näytä";
            this.btnNayta.UseVisualStyleBackColor = true;
            this.btnNayta.Click += new System.EventHandler(this.btnNayta_Click);
            // 
            // NaytaKirjat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 408);
            this.Controls.Add(this.btnNayta);
            this.Controls.Add(this.dgShowKirjat);
            this.Controls.Add(this.label1);
            this.Name = "NaytaKirjat";
            this.Text = "NaytaKirjat";
            ((System.ComponentModel.ISupportInitialize)(this.dgShowKirjat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgShowKirjat;
        private System.Windows.Forms.Button btnNayta;
    }
}