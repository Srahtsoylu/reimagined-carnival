namespace OtelOtomasyonu
{
    partial class FormAna
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.btnRezervasyonIslemleri = new System.Windows.Forms.Button();
            this.btnPersonelIslemleri = new System.Windows.Forms.Button();
            this.btnUcretHesaplama = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriIslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(12, 202);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(200, 72);
            this.btnMusteriIslemleri.TabIndex = 0;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = true;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnMusteriIslemleri_Click);
            // 
            // btnRezervasyonIslemleri
            // 
            this.btnRezervasyonIslemleri.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonIslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRezervasyonIslemleri.Location = new System.Drawing.Point(218, 202);
            this.btnRezervasyonIslemleri.Name = "btnRezervasyonIslemleri";
            this.btnRezervasyonIslemleri.Size = new System.Drawing.Size(200, 72);
            this.btnRezervasyonIslemleri.TabIndex = 1;
            this.btnRezervasyonIslemleri.Text = "Rezervasyon İşlemleri";
            this.btnRezervasyonIslemleri.UseVisualStyleBackColor = true;
            this.btnRezervasyonIslemleri.Click += new System.EventHandler(this.btnRezervasyonIslemleri_Click);
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelIslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(218, 280);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(200, 72);
            this.btnPersonelIslemleri.TabIndex = 2;
            this.btnPersonelIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelIslemleri.UseVisualStyleBackColor = true;
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnUcretHesaplama
            // 
            this.btnUcretHesaplama.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcretHesaplama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUcretHesaplama.Location = new System.Drawing.Point(12, 280);
            this.btnUcretHesaplama.Name = "btnUcretHesaplama";
            this.btnUcretHesaplama.Size = new System.Drawing.Size(200, 72);
            this.btnUcretHesaplama.TabIndex = 3;
            this.btnUcretHesaplama.Text = "Ücret Hesaplama";
            this.btnUcretHesaplama.UseVisualStyleBackColor = true;
            this.btnUcretHesaplama.Click += new System.EventHandler(this.btnUcretHesaplama_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(438, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUcretHesaplama);
            this.Controls.Add(this.btnPersonelIslemleri);
            this.Controls.Add(this.btnRezervasyonIslemleri);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Name = "FormAna";
            this.Text = "FormAna";
            this.Load += new System.EventHandler(this.FormAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button btnRezervasyonIslemleri;
        private System.Windows.Forms.Button btnPersonelIslemleri;
        private System.Windows.Forms.Button btnUcretHesaplama;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

