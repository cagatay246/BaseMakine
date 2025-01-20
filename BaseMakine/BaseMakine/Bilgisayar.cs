using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMakine
{
    public class Bilgisayar : BaseMakine1
    {
        private int usbGirisSayisi;
        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; }
            set
            {
                // Kapsülleme: Usb giriş sayısının geçerli olup olmadığını kontrol et
                if (value == 2 || value == 4)
                {
                    usbGirisSayisi = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz USB giriş sayısı! -1 atanıyor.");
                    usbGirisSayisi = -1;
                }
            }
        }

        public bool Bluetooth { get; set; }

        // Polymorphism: Bilgisayar bilgilerini yazdırma
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth Durumu: {(Bluetooth ? "Evet" : "Hayır")}");
        }

        // Abstraction: Bilgisayar adı getirme
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }
}
