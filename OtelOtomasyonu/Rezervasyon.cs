using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int OdaNumarasi { get; set; }
        public DateTime GirisTarihi { get; set; }//Tüm özellikler (Id, MusteriId, OdaNumarasi, GirisTarihi, CikisTarihi, Ucret)
                                                 //public erişim belirleyicisiyle tanımlanmış olsa da,
                                                 //özelliklerin sınıf içinde tanımlı olması kapsüllemeye bir örnektir.
                                                 //Kapsülleme, verileri sınıf içinde tutar ve gerektiğinde dış dünyaya açar.
                                                 //Bu özelliklerin doğrudan erişilebilir olması, sınıfın sade bir veri taşıyıcı (DTO - Data Transfer Object) gibi çalıştığını gösterir

        public DateTime CikisTarihi { get; set; }
        public decimal Ucret { get; set; }
    }
}
