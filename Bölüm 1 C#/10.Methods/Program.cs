/**
 Metot (Fonksiyon)
 * Fonksiyonlar, bir işi yapmak için tasarlanmış kod bloklarıdır.
 * DRY (Don't Repeat Yourself) prensibine uygundur.
 * Bir fonksiyonu bir kere yazıp, istediğimiz kadar çağırabiliriz.
 Fonksiyon Tanımlama
 [ErişimBelirleyicisi] GeriDonusDegeri FonksiyonAdi(Varsa Parametreler)
 {
    // Fonksiyonun içinde yapılacak işlemler
 }

Erişim Belirleyicileri
    * public : Her yerden erişilebilir.
    * private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
    * protected : Sadece tanımlandığı sınıf içerisinden ve bu sınıftan türetilen sınıflardan erişilebilir.
    * internal : Sadece bulunduğu proje içerisinden erişilebilir.
    * internal protected : Sadece bulunduğu proje içerisinden ve bu sınıftan türetilen sınıflardan erişilebilir.
 Fonksiyon Çağırma : FonksiyonAdi();
 */


namespace _10.Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Selamla();
            Selamla();
            StudentInfo("Ali", "Veli");
            Console.WriteLine("Menü/n1-Toplama/n2-Çıkarma/n3-Çarpma/n4-Bölme");
            Console.WriteLine("Seçiminiz: ");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 1: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 2: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Average(5, 10, 15);
            Average();
            int sayi4 = 0;
            Numbers(out sayi4);

            Sum(5, 10, 15, 25, 64);
            Sum(5, 10);

            switch (select)
            {
                case 1:
                    Topla(sayi1, sayi2);
                    break;
                case 2:
                    int fark = Cikar(sayi1, sayi2);
                    Console.WriteLine("Fark : " + fark);
                    break;
                case 3:
                    Carp(sayi1, sayi2);
                    break;
                case 4:
                    int bolum = Bol(sayi1, sayi2);
                    Console.WriteLine("Bölüm : " + bolum);
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim");
                    break;
            }
        }
        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }

        static void StudentInfo(String studentName, string studentSurname)
        {
            Console.WriteLine("Öğrenci Adı : " + studentName);
            Console.WriteLine("Öğrenci Soyadı : " + studentSurname);
        }

        static void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);
        }

        static int Cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }

        static void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Çarpım : " + carpim);
        }

        static int Bol(int sayi1, int sayi2)
        {
            int bolum = sayi1 / sayi2;
            return bolum;
        }

        static void Average(int number1 = 10, int number2 = 20, int number3 = 30)
        {
            int ortalama = (number1 + number2 + number3) / 3;
            Console.WriteLine("Ortalama : " + ortalama);
        }

        static void Numbers(out int number)
        {
            number = 10;
        }

        static void Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

            }

            Console.WriteLine("Toplam : " + sum);
        }

        static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void Add(int number1, int number2, int number3)
        {
            Console.WriteLine(number1 + number2 + number3);
        }
    }
}


/**
 * return : Fonksiyonun geri dönüş değerini belirtir. Eğer return kullanılmışsa, fonksiyonun geri dönüş değeri olmalıdır. Ekrana yazdırna işlemleri fonksiyon çağırıldığı yerde yapılır.
 * Varsayılan değerler : Fonksiyonlara varsayılan değerler atanabilir. Bu değerler fonksiyon çağırıldığında parametre olarak verilmezse, varsayılan değerler kullanılır.
 * ref : çağrılan metotun, değişkenin değerini dışarıya aktarmasına izin verir.
 * out :  “out” anahtar kelimesi, çağrılan metotun, değişkenin değerini dışarıya aktarmasına ve aynı zamanda değişkenin ilk değerinin atanmasına izin verir.
 * .NET 7'de ref ve out farkı kalkmıştır. ref ve out kullanımı aynıdır.
 * params : Fonksiyonlara istediğimiz kadar parametre gönderebilmemizi sağlar. Fonksiyon çağırılırken, parametrelerin sonuna params anahtar kelimesi ile tanımlanan parametreler gönderilir.
 * Method Overloading : Aynı isimde fakat farklı parametreler alan fonksiyonlar tanımlanabilir. Bu işleme method overloading denir.
 */