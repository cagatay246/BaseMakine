using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMakine
{
    public abstract class BaseMakine1
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNo { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        // Constructor: Üretim Tarihi otomatik olarak atanır
        public BaseMakine1()
        {
            UretimTarihi = DateTime.Now;
        }

        // Polymorphism: Bilgileri yazdırma metodu
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNo}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }

        
        public abstract void UrunAdiGetir();
    }


















}
