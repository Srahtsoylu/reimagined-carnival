using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()//Main metodu, Program sınıfı içinde tanımlıdır ve dışarıdan yalnızca belirli bir şekilde çağrılabilir.
                          //Bu durum kapsüllemeye örnektir
                          //KAPSÜLLEME
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new admingiris());//Uygulamanın başlangıç noktası olan Application.Run(new admingiris()); çağrısı, detayları gizler.
                                              //Bu satır, bir formun (admingiris) başlatıldığını belirtir ancak formun içindeki detaylara dair bir bilgi vermez.
                                              //SOYUTLAMA
        }
    }
}
