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
