namespace OtelOtomasyonu
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }//Personel sınıfındaki tüm özellikler (Id, Ad, Soyad, Telefon, Gorev) public olarak tanımlanmıştır.
                                         //Bu, özelliklere doğrudan erişimi sağlar
                                         //KAPSÜLLEME
        public string Telefon { get; set; }
        public string Gorev { get; set; }

        public override string ToString()//ToString() metodunun özelleştirilmesi, polimorfizme bir örnektir.
                                         //Bu metot, Personel nesnesinin kullanıcı dostu bir biçimde yazdırılmasını sağlar.
                                         //POLİMORFİZM
        {
            return $"{Ad} {Soyad} - Görev: {Gorev}"; 
        }
    }
}
