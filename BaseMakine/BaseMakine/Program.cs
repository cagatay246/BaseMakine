using BaseMakine;

class Program
{
    static void Main(string[] args)
    {
        bool devamEt = true;

        while (devamEt)
        {
            // Kullanıcıdan telefon veya bilgisayar seçmesini isteyelim
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basın.");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                // Telefon üretme
                Telefon telefon = new Telefon();

                Console.Write("Telefonun Seri Numarasını girin: ");
                telefon.SeriNo = Console.ReadLine();

                Console.Write("Telefonun adını girin: ");
                telefon.Ad = Console.ReadLine();

                Console.Write("Telefon açıklamasını girin: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi girin: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("Türk Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisansli = Console.ReadLine().ToLower() == "evet";

                // Ürünü başarıyla oluşturduktan sonra bilgilerini yazdır
                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();

                Console.WriteLine("Telefon başarıyla üretildi!");

            }
            else if (secim == "2")
            {
                // Bilgisayar üretme
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Bilgisayarın Seri Numarasını girin: ");
                bilgisayar.SeriNo = Console.ReadLine();

                Console.Write("Bilgisayarın adını girin: ");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Bilgisayar açıklamasını girin: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi girin: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("USB giriş sayısını girin (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

                Console.Write("Bluetooth var mı? (Evet/Hayır): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet";

                // Ürünü başarıyla oluşturduktan sonra bilgilerini yazdır
                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();

                Console.WriteLine("Bilgisayar başarıyla üretildi!");
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 girin.");
                continue;
            }

            // Yeni ürün üretmek isteyip istemediğini sor
            Console.WriteLine("Başka bir ürün üretmek ister misiniz? (Evet/Hayır)");
            string devamSecim = Console.ReadLine().ToLower();
            if (devamSecim == "hayir")
            {
                devamEt = false;
                Console.WriteLine("İyi günler!");
            }
        }
    }
}
