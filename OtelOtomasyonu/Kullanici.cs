using System;

namespace OtelOtomasyonu
{
    public abstract class Kullanici
                                   
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Gorev { get; set; }

        // Polimorfizm için soyut bir metot //Polimorfizm, aynı isimdeki metodların farklı sınıflarda farklı işlevler gerçekleştirmesi yeteneğidir.
        //Bu durumda, Kullanici sınıfı alt sınıflarına bu metodun nasıl çalıştığını kendilerinin tanımlamalarını zorunlu kılar.
        public abstract string BilgiGoster();
    }
}
