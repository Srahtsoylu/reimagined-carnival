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
    public partial class FormRezervasyon : Form
    {
        private string connectionString = "Server=.;Database=OtelOtomasyonu;Trusted_Connection=True;";
        public FormRezervasyon()
        {
            InitializeComponent();
        }
        private void FormRezervasyon_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet.Rezervasyonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonlarTableAdapter.Fill(this.otelOtomasyonuDataSet.Rezervasyonlar);
            RezervasyonListesiDoldur();
        }

        private void RezervasyonListesiDoldur()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rezervasyonlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewRezervasyon.DataSource = dt;
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rezervasyonlar (MusteriId, OdaNumarasi, GirisTarihi, CikisTarihi) VALUES (@MusteriId, @OdaNumarasi, @GirisTarihi, @CikisTarihi)", conn);
                cmd.Parameters.AddWithValue("@MusteriId", Convert.ToInt32(txtMusteriId.Text));
                cmd.Parameters.AddWithValue("@OdaNumarasi", Convert.ToInt32(txtOdaNumarasi.Text));
                cmd.Parameters.AddWithValue("@GirisTarihi", dtpGirisTarihi.Value);
                cmd.Parameters.AddWithValue("@CikisTarihi", dtpCikisTarihi.Value);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Rezervasyon başarıyla yapıldı!");
            RezervasyonListesiDoldur();
        }
    }
}
