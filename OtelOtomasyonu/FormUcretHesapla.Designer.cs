namespace OtelOtomasyonu
{
    partial class FormUcretHesapla
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUcretHesapla));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.txtOdaFiyati = new System.Windows.Forms.TextBox();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnUcretHesapla = new System.Windows.Forms.Button();
            this.lblUcret = new System.Windows.Forms.Label();
            this.dataGridViewOdalar = new System.Windows.Forms.DataGridView();
            this.odaNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelOtomasyonuDataSet = new OtelOtomasyonu.OtelOtomasyonuDataSet();
            this.odalarTableAdapter = new OtelOtomasyonu.OtelOtomasyonuDataSetTableAdapters.OdalarTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(42, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(39, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(50, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oda Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(23, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Ücret:";
            // 
            // txtOdaNumarasi
            // 
            this.txtOdaNumarasi.Location = new System.Drawing.Point(165, 239);
            this.txtOdaNumarasi.Name = "txtOdaNumarasi";
            this.txtOdaNumarasi.Size = new System.Drawing.Size(200, 22);
            this.txtOdaNumarasi.TabIndex = 5;
            // 
            // txtOdaFiyati
            // 
            this.txtOdaFiyati.Location = new System.Drawing.Point(165, 323);
            this.txtOdaFiyati.Name = "txtOdaFiyati";
            this.txtOdaFiyati.Size = new System.Drawing.Size(200, 22);
            this.txtOdaFiyati.TabIndex = 6;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(165, 267);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpGirisTarihi.TabIndex = 7;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(165, 295);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpCikisTarihi.TabIndex = 8;
            // 
            // btnUcretHesapla
            // 
            this.btnUcretHesapla.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcretHesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUcretHesapla.Location = new System.Drawing.Point(165, 374);
            this.btnUcretHesapla.Name = "btnUcretHesapla";
            this.btnUcretHesapla.Size = new System.Drawing.Size(200, 42);
            this.btnUcretHesapla.TabIndex = 9;
            this.btnUcretHesapla.Text = "ÜCRET HESAPLA";
            this.btnUcretHesapla.UseVisualStyleBackColor = true;
            this.btnUcretHesapla.Click += new System.EventHandler(this.btnUcretHesapla_Click);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(194, 347);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(126, 16);
            this.lblUcret.TabIndex = 10;
            this.lblUcret.Text = "_________________";
            // 
            // dataGridViewOdalar
            // 
            this.dataGridViewOdalar.AutoGenerateColumns = false;
            this.dataGridViewOdalar.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaNumarasiDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.dataGridViewOdalar.DataSource = this.odalarBindingSource;
            this.dataGridViewOdalar.Location = new System.Drawing.Point(371, 12);
            this.dataGridViewOdalar.Name = "dataGridViewOdalar";
            this.dataGridViewOdalar.RowHeadersWidth = 51;
            this.dataGridViewOdalar.RowTemplate.Height = 24;
            this.dataGridViewOdalar.Size = new System.Drawing.Size(430, 405);
            this.dataGridViewOdalar.TabIndex = 11;
            // 
            // odaNumarasiDataGridViewTextBoxColumn
            // 
            this.odaNumarasiDataGridViewTextBoxColumn.DataPropertyName = "OdaNumarasi";
            this.odaNumarasiDataGridViewTextBoxColumn.HeaderText = "OdaNumarasi";
            this.odaNumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNumarasiDataGridViewTextBoxColumn.Name = "odaNumarasiDataGridViewTextBoxColumn";
            this.odaNumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            this.durumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.otelOtomasyonuDataSet;
            // 
            // otelOtomasyonuDataSet
            // 
            this.otelOtomasyonuDataSet.DataSetName = "OtelOtomasyonuDataSet";
            this.otelOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormUcretHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(815, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewOdalar);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.btnUcretHesapla);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.txtOdaFiyati);
            this.Controls.Add(this.txtOdaNumarasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUcretHesapla";
            this.Text = "FormUcretHesapla";
            this.Load += new System.EventHandler(this.FormUcretHesapla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdaNumarasi;
        private System.Windows.Forms.TextBox txtOdaFiyati;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Button btnUcretHesapla;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.DataGridView dataGridViewOdalar;
        private OtelOtomasyonuDataSet otelOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private OtelOtomasyonuDataSetTableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}