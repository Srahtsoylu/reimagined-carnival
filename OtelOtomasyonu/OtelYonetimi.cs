using OtelOtomasyonu;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class OtelYonetimi
{
    private string connectionString = "Server=.;Database=OtelOtomasyonu;Trusted_Connection=True;";//connectionString özelliği private olarak tanımlanmıştır.
                                                                                                  //Dışarıdan doğrudan erişilemez; sadece sınıf içinde kullanılabilir.
                                                                                                  //KAPSÜLLEME

    
    public void MusteriEkle(Musteri musteri)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (Ad, Soyad, Telefon) VALUES (@Ad, @Soyad, @Telefon)", conn);
            cmd.Parameters.AddWithValue("@Ad", musteri.Ad);
            cmd.Parameters.AddWithValue("@Soyad", musteri.Soyad);
            cmd.Parameters.AddWithValue("@Telefon", musteri.Telefon);
            cmd.ExecuteNonQuery();
        }
    }

    public List<Musteri> MusterileriGetir()
    {
        List<Musteri> musteriler = new List<Musteri>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Musteriler", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                musteriler.Add(new Musteri
                {
                    Id = (int)reader["Id"],
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    Telefon = reader["Telefon"].ToString()
                });
            }
        }
        return musteriler;
    }

    public void RezervasyonYap(Rezervasyon rezervasyon)//RezervasyonYap metodu, hem oda ücretini hesaplar, hem rezervasyonu kaydeder, hem de oda durumunu günceller.
                                                       //Ancak kullanıcı bu detayların hiçbirini bilmek zorunda değildir.
                                                       //SOYUTLAMA
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            SqlCommand ucretCmd = new SqlCommand("SELECT Ucret FROM Odalar WHERE OdaNumarasi = @OdaNumarasi", conn);
            ucretCmd.Parameters.AddWithValue("@OdaNumarasi", rezervasyon.OdaNumarasi);
            decimal ucret = (decimal)ucretCmd.ExecuteScalar();

            TimeSpan konaklamaSuresi = rezervasyon.CikisTarihi - rezervasyon.GirisTarihi;
            rezervasyon.Ucret = ucret * konaklamaSuresi.Days;

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Rezervasyonlar (MusteriId, OdaNumarasi, GirisTarihi, CikisTarihi) VALUES (@MusteriId, @OdaNumarasi, @GirisTarihi, @CikisTarihi)", conn);
            cmd.Parameters.AddWithValue("@MusteriId", rezervasyon.MusteriId);
            cmd.Parameters.AddWithValue("@OdaNumarasi", rezervasyon.OdaNumarasi);
            cmd.Parameters.AddWithValue("@GirisTarihi", rezervasyon.GirisTarihi);
            cmd.Parameters.AddWithValue("@CikisTarihi", rezervasyon.CikisTarihi);
            cmd.ExecuteNonQuery();

            SqlCommand updateCmd = new SqlCommand("UPDATE Odalar SET Durum = 1 WHERE OdaNumarasi = @OdaNumarasi", conn);
            updateCmd.Parameters.AddWithValue("@OdaNumarasi", rezervasyon.OdaNumarasi);
            updateCmd.ExecuteNonQuery();
        }
    }

    public decimal RezervasyonUcretHesapla(int odaNumarasi, DateTime giris, DateTime cikis)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ucret FROM Odalar WHERE OdaNumarasi = @OdaNumarasi", conn);
            cmd.Parameters.AddWithValue("@OdaNumarasi", odaNumarasi);
            decimal ucret = (decimal)cmd.ExecuteScalar();

            TimeSpan sure = cikis - giris;
            return ucret * sure.Days;
        }
    }

    public double OdaDolulukOraniHesapla()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Odalar", conn);
            int toplamOda = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Odalar WHERE Durum = 1", conn);
            int doluOda = (int)cmd.ExecuteScalar();

            return (double)doluOda / toplamOda * 100;
        }
    }

    public void PersonelEkle(Personel personel)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Personeller (Ad, Soyad, Telefon, Gorev) VALUES (@Ad, @Soyad, @Telefon, @Gorev)", conn);
            cmd.Parameters.AddWithValue("@Ad", personel.Ad);
            cmd.Parameters.AddWithValue("@Soyad", personel.Soyad);
            cmd.Parameters.AddWithValue("@Telefon", personel.Telefon);
            cmd.Parameters.AddWithValue("@Gorev", personel.Gorev);
            cmd.ExecuteNonQuery();
        }
    }

    public List<Personel> PersonelleriGetir()
    {
        List<Personel> personeller = new List<Personel>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personeller", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                personeller.Add(new Personel
                {
                    Id = (int)reader["Id"],
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    Gorev = reader["Gorev"].ToString()
                });
            }
        }
        return personeller;
    }
    public void TarihiGecenRezervasyonlariSil()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Rezervasyonlar WHERE CikisTarihi < @Bugun", conn);
            cmd.Parameters.AddWithValue("@Bugun", DateTime.Now);
            cmd.ExecuteNonQuery();
        }
    }
}
