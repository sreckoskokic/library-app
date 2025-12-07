namespace DiplomskiRad
{
    partial class UredjivanjeKnjigaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UredjivanjeKnjigaForm));
            this.dgvKnjigeEdit = new System.Windows.Forms.DataGridView();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtGodinaIzdanja = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodajNovi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKnjigeEdit
            // 
            this.dgvKnjigeEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKnjigeEdit.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKnjigeEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjigeEdit.Location = new System.Drawing.Point(18, 12);
            this.dgvKnjigeEdit.Name = "dgvKnjigeEdit";
            this.dgvKnjigeEdit.Size = new System.Drawing.Size(663, 326);
            this.dgvKnjigeEdit.TabIndex = 0;
            this.dgvKnjigeEdit.SelectionChanged += new System.EventHandler(this.dgvKnjigeEdit_SelectionChanged);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(157, 344);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(100, 20);
            this.txtNaslov.TabIndex = 0;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(263, 344);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(369, 344);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(100, 20);
            this.txtZanr.TabIndex = 2;
            // 
            // txtGodinaIzdanja
            // 
            this.txtGodinaIzdanja.Location = new System.Drawing.Point(475, 344);
            this.txtGodinaIzdanja.Name = "txtGodinaIzdanja";
            this.txtGodinaIzdanja.Size = new System.Drawing.Size(100, 20);
            this.txtGodinaIzdanja.TabIndex = 3;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(581, 344);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 4;
            // 
            // btnDodajNovi
            // 
            this.btnDodajNovi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDodajNovi.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnDodajNovi.Location = new System.Drawing.Point(23, 370);
            this.btnDodajNovi.Name = "btnDodajNovi";
            this.btnDodajNovi.Size = new System.Drawing.Size(212, 70);
            this.btnDodajNovi.TabIndex = 5;
            this.btnDodajNovi.Text = "Nova knjiga";
            this.btnDodajNovi.UseVisualStyleBackColor = false;
            this.btnDodajNovi.Click += new System.EventHandler(this.btnDodajNovi_Click_1);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSacuvaj.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnSacuvaj.Location = new System.Drawing.Point(241, 370);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(212, 70);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click_1);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnObrisi.Location = new System.Drawing.Point(459, 370);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(212, 70);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(803, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(687, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(723, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 46);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UredjivanjeKnjigaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(936, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dgvKnjigeEdit);
            this.Controls.Add(this.btnDodajNovi);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtGodinaIzdanja);
            this.Controls.Add(this.txtZanr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UredjivanjeKnjigaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UredjivanjeKnjigaForm";
            this.Load += new System.EventHandler(this.UredjivanjeKnjigaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKnjigeEdit;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtGodinaIzdanja;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnDodajNovi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}