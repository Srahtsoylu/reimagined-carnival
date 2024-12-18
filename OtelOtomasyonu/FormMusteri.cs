using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class FormMusteri : Form
    {
        private string connectionString = "Server=.;Database=OtelOtomasyonu;Trusted_Connection=True;";
        public FormMusteri()
        {
            InitializeComponent();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet.Musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.otelOtomasyonuDataSet.Musteriler);
            MusteriListesiDoldur();
            txtMusteriTelefon.Text = "0";
        }
        private void MusteriListesiDoldur()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Musteriler", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string telefon = txtMusteriTelefon.Text.Trim();  // TextBox'tan telefon numarasını al
                // Telefon numarasının 12 haneli olup olmadığını kontrol et
                if (telefon.Length != 11)
                {
                    MessageBox.Show("Telefon numarası 11 haneli olmalıdır.");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (Ad, Soyad, Telefon) VALUES (@Ad, @Soyad, @Telefon)", conn);
                    cmd.Parameters.AddWithValue("@Ad", txtMusteriAd.Text);
                    cmd.Parameters.AddWithValue("@Soyad", txtMusteriSoyad.Text);
                    cmd.Parameters.AddWithValue("@Telefon", txtMusteriTelefon.Text);
                    cmd.ExecuteNonQuery();
                    
                    // Telefon numarasının doğru uzunlukta olduğunu varsayalım
                    MessageBox.Show("Telefon numarası kaydedildi.");

                    // Veritabanına veya başka bir işleme geçebilirsiniz
                    MessageBox.Show("Müşteri başarıyla eklendi!");

                }
            }

            
            MusteriListesiDoldur();
            
        }
    }
    }

