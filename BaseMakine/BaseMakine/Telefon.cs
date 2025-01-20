using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMakine
{
    public class Telefon : BaseMakine1
    {
        public bool TrLisansli { get; set; }

        // Polymorphism: Telefon bilgilerini yazdırma
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Türk Lisansı Durumu: {(TrLisansli ? "Evet" : "Hayır")}");
        }

        // Abstraction: Telefon adı getirme
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }













}
