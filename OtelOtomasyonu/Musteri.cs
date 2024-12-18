using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad} - Tel: {Telefon1}"; //ToString() metodu, çok biçimliliğe örnektir. Musteri sınıfında,
                                                      //ToString() metodu özelleştirilmiş ve müşteri bilgilerini kullanıcı dostu bir formatta döndürmesi sağlanmıştır:
        }
        public string Telefon1//Telefon1 özelliği kapsülleme ilkesine örnektir. Kullanıcı doğrudan Telefon özelliğini değiştiremez; yalnızca Telefon1 aracılığıyla erişim sağlayabilir.
                              //Ayrıca, bir doğrulama mekanizması (telefon numarasının 11 haneli olması kontrolü) eklenmiştir.
        {
            get { return Telefon1; }
            set
            {
                if (value.Length == 11)
                    Telefon = value;
                else
                    throw new Exception("Telefon numarası 10 haneli olmalıdır.");
            }
        }
    }
}
