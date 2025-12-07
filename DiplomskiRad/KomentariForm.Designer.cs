namespace DiplomskiRad
{
    partial class KomentariForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KomentariForm));
            this.lbxKomentari = new System.Windows.Forms.ListBox();
            this.txtNoviKomentar = new System.Windows.Forms.TextBox();
            this.btnPostaviKomentar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOcena = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxKomentari
            // 
            this.lbxKomentari.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxKomentari.FormattingEnabled = true;
            this.lbxKomentari.Location = new System.Drawing.Point(12, 45);
            this.lbxKomentari.Name = "lbxKomentari";
            this.lbxKomentari.Size = new System.Drawing.Size(627, 264);
            this.lbxKomentari.TabIndex = 0;
            // 
            // txtNoviKomentar
            // 
            this.txtNoviKomentar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNoviKomentar.Location = new System.Drawing.Point(152, 315);
            this.txtNoviKomentar.Multiline = true;
            this.txtNoviKomentar.Name = "txtNoviKomentar";
            this.txtNoviKomentar.Size = new System.Drawing.Size(391, 125);
            this.txtNoviKomentar.TabIndex = 2;
            // 
            // btnPostaviKomentar
            // 
            this.btnPostaviKomentar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPostaviKomentar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostaviKomentar.Location = new System.Drawing.Point(549, 315);
            this.btnPostaviKomentar.Name = "btnPostaviKomentar";
            this.btnPostaviKomentar.Size = new System.Drawing.Size(90, 125);
            this.btnPostaviKomentar.TabIndex = 3;
            this.btnPostaviKomentar.Text = "Postavi komentar";
            this.btnPostaviKomentar.UseVisualStyleBackColor = false;
            this.btnPostaviKomentar.Click += new System.EventHandler(this.btnPostaviKomentar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "Komentari";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(656, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(778, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 46);
            this.button2.TabIndex = 26;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(698, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 46);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ocena";
            // 
            // cmbOcena
            // 
            this.cmbOcena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcena.FormattingEnabled = true;
            this.cmbOcena.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbOcena.Location = new System.Drawing.Point(24, 383);
            this.cmbOcena.Name = "cmbOcena";
            this.cmbOcena.Size = new System.Drawing.Size(121, 21);
            this.cmbOcena.TabIndex = 28;
            // 
            // KomentariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(920, 449);
            this.Controls.Add(this.cmbOcena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPostaviKomentar);
            this.Controls.Add(this.txtNoviKomentar);
            this.Controls.Add(this.lbxKomentari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KomentariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KomentariForm";
            this.Load += new System.EventHandler(this.KomentariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKomentari;
        private System.Windows.Forms.TextBox txtNoviKomentar;
        private System.Windows.Forms.Button btnPostaviKomentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOcena;
    }
}