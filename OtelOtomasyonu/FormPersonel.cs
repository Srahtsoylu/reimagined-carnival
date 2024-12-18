using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OtelOtomasyonu;

namespace OtelOtomasyonu
{
    public partial class FormPersonel : Form
    {
        private string connectionString = "Server=.;Database=OtelOtomasyonu;Trusted_Connection=True;";

        public FormPersonel()
        {
            InitializeComponent();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            this.personellerTableAdapter.Fill(this.otelOtomasyonuDataSet.Personeller);
            PersonelListesiDoldur();
        }

        private void PersonelListesiDoldur()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personeller", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPersoneller.DataSource = dt;
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel
            {
                Ad = txtPersonelAd.Text,
                Soyad = txtPersonelSoyad.Text,
                Telefon = txtPersonelTelefon.Text,
                Gorev = txtPersonelGorev.Text
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Personeller (Ad, Soyad, Telefon, Gorev) VALUES (@Ad, @Soyad, @Telefon, @Gorev)", conn);
                cmd.Parameters.AddWithValue("@Ad", personel.Ad);
                cmd.Parameters.AddWithValue("@Soyad", personel.Soyad);
                cmd.Parameters.AddWithValue("@Telefon", personel.Telefon);
                cmd.Parameters.AddWithValue("@Gorev", personel.Gorev);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Personel başarıyla eklendi!");
            PersonelListesiDoldur();
        }
    }
}
