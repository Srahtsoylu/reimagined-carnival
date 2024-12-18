using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class FormUcretHesapla : Form
    {
        private string connectionString = "Server=.;Database=OtelOtomasyonu;Trusted_Connection=True;";
        public FormUcretHesapla()
        {
            InitializeComponent();
        }

        private void FormUcretHesapla_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet.Odalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odalarTableAdapter.Fill(this.otelOtomasyonuDataSet.Odalar);
            OdaListesiDoldur();
        }
        private void OdaListesiDoldur()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Odalar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOdalar.DataSource = dt;
            }
        }

        private void btnUcretHesapla_Click(object sender, EventArgs e)
        {
            // Giriş ve çıkış tarihlerini al
            DateTime giris = dtpGirisTarihi.Value;
            DateTime cikis = dtpCikisTarihi.Value;

            // Tarihler arasındaki geçerliliği kontrol et
            if (cikis <= giris)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gün sayısını hesapla
            int gunSayisi = (cikis - giris).Days + 1;

            // Oda fiyatını al
            if (!decimal.TryParse(txtOdaFiyati.Text, out decimal odaFiyati) || odaFiyati <= 0)
            {
                MessageBox.Show("Geçerli bir oda fiyatı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ucret hesaplama sınıfından örnek oluştur
            IUcretHesaplayici ucretHesaplayici = new UcretHesaplama();
            decimal toplamUcret = ucretHesaplayici.UcretHesapla(gunSayisi, odaFiyati);

            // Ücreti label üzerinde göster
            lblUcret.Text = $"Hesaplanan Ücret: {toplamUcret:C2}";
           
            }
        }

    }

