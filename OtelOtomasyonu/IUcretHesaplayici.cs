using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OtelOtomasyonu
{
    public interface IUcretHesaplayici
    {
        decimal UcretHesapla(int gunSayisi, decimal odaFiyati);  //IUcretHesaplayici adlı bir arayüz tanımlanmış:
                                                                 //Arayüz, bir sınıfın uygulamak zorunda olduğu metodların bir sözleşmesini sağlar.
       // Bu kodda IUcretHesaplayici arayüzü, herhangi bir ücret hesaplama işleminde kullanılacak bir sözleşme sunar.Farklı ücret hesaplama stratejileri gerektiğinde, bu arayüzü implement eden yeni sınıflar tanımlanabilir.
    }
    public class UcretHesaplama : IUcretHesaplayici
    {
        public decimal UcretHesapla(int gunSayisi, decimal odaFiyati)
        {
            return gunSayisi * odaFiyati;
        }
    }

}
