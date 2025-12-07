namespace DiplomskiRad
{
    partial class KnjigeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnjigeForm));
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.btnPrikaziKomentare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUrediKnjige = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKnjige.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(12, 12);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.ReadOnly = true;
            this.dgvKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjige.Size = new System.Drawing.Size(662, 427);
            this.dgvKnjige.TabIndex = 0;
            this.dgvKnjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKnjige_CellContentClick);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(703, 21);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOd.TabIndex = 1;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(703, 64);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDo.TabIndex = 2;
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRezervisi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRezervisi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRezervisi.Location = new System.Drawing.Point(703, 101);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(200, 32);
            this.btnRezervisi.TabIndex = 3;
            this.btnRezervisi.Text = "Rezerviši knjigu";
            this.btnRezervisi.UseVisualStyleBackColor = false;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click_1);
            // 
            // btnPrikaziKomentare
            // 
            this.btnPrikaziKomentare.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPrikaziKomentare.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrikaziKomentare.Location = new System.Drawing.Point(703, 139);
            this.btnPrikaziKomentare.Name = "btnPrikaziKomentare";
            this.btnPrikaziKomentare.Size = new System.Drawing.Size(200, 29);
            this.btnPrikaziKomentare.TabIndex = 4;
            this.btnPrikaziKomentare.Text = "Postavi/Prikaži komentar";
            this.btnPrikaziKomentare.UseVisualStyleBackColor = false;
            this.btnPrikaziKomentare.Click += new System.EventHandler(this.btnPrikaziKomentare_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(729, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 46);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(809, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 46);
            this.button2.TabIndex = 22;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnUrediKnjige
            // 
            this.btnUrediKnjige.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUrediKnjige.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUrediKnjige.Location = new System.Drawing.Point(697, 356);
            this.btnUrediKnjige.Name = "btnUrediKnjige";
            this.btnUrediKnjige.Size = new System.Drawing.Size(200, 29);
            this.btnUrediKnjige.TabIndex = 24;
            this.btnUrediKnjige.Text = "Uredi knjige";
            this.btnUrediKnjige.UseVisualStyleBackColor = false;
            this.btnUrediKnjige.Visible = false;
            this.btnUrediKnjige.Click += new System.EventHandler(this.btnUrediKnjige_Click);
            // 
            // KnjigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(920, 449);
            this.Controls.Add(this.btnUrediKnjige);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrikaziKomentare);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.dgvKnjige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KnjigeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnjigeForm";
            this.Load += new System.EventHandler(this.KnjigeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Button btnPrikaziKomentare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrediKnjige;
    }
}