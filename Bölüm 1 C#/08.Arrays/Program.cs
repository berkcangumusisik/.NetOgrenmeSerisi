using System.Reflection.Metadata;

String[] names = new String[3];
names[0] = "Ali";
names[1] = "Veli";
names[2] = "Ahmet";
foreach (String name in names)
{
    Console.WriteLine(name);
}

Console.Write("Dizinin eleman sayısı: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Sayı giriniz: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Girilen sayılar: ");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}


// Dizideki elemanların toplamı
int[] numbers1 = { 1, 2, 3, 4, 5 };
int sum = 0;
foreach (var number in numbers1)
{
    sum += number;
}

Console.WriteLine("Toplam: " + sum);


int[] numbers2 = { 1, 2, 3, 4, 5 };
Console.WriteLine("Dizinin eleman sayısı: " + numbers2.Length);
Console.WriteLine("Dizinin ilk elemanı: " + numbers2[0]);
Console.WriteLine("Dizinin son elemanı: " + numbers2[numbers2.Length - 1]);
numbers2.SetValue(99, 0);
Console.WriteLine("Dizinin ilk elemanı: " + numbers2[0]);
Console.WriteLine("5'in indexi: " + Array.IndexOf(numbers2, 5));
Array.Sort(numbers2);
Console.WriteLine("Dizi" + numbers2);
Array.Reverse(numbers2);
Console.WriteLine("Dizi" + numbers2);
Array.Clear(numbers2, 0, numbers2.Length);
Console.WriteLine("Dizi" + numbers2);


string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa" };
Console.WriteLine(sehirler[0..3]);


string[] students = { "Ali", "Veli", "Ahmet"};
int[,] grades = new int[3, 3];
for (int i = 0; i < students.Length; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(students[i] + " isimli öğrencinin " + (j + 1) + ". notunu giriniz: ");
        grades[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int x = 10;
int y = x;


Console.WriteLine("x: " + x); // 10
Console.WriteLine("y: " + y); // 10

x = 20;
Console.WriteLine("x: " + x); // 20
Console.WriteLine("y: " + y); // 10


int[] a = { 1, 2, 3 };
int[] b = a;
Console.WriteLine("a: " + a[0]); // 1
Console.WriteLine("b: " + b[0]); // 1

a[0] = 99;
Console.WriteLine("a: " + a[0]); // 99
Console.WriteLine("b: " + b[0]); // 99
/**
 Arrays (Diziler)
 * Diziler birbirine benzeyen verileri tutmak için kullanılır.
 * Dizi tanımlanırken veri tipi ve eleman sayısı belirtilir. veri tipi[] diziAdi = new veri tipi[eleman sayısı];
 * Dizinin elemanlarına erişmek için diziAdi[eleman indexi] şeklinde erişilir.
 * Generic Dizi  tanımlama: veri tipi[] diziAdi = {eleman1, eleman2, eleman3, ...}; Generic dizi tanımlamada eleman sayısı belirtilmez.
 Dizi Metotları
 - Length: Dizinin eleman sayısını verir.
 - SetValue: Dizinin elemanlarını değiştirir.
 - Array.IndexOf: Dizinin elemanının indexini verir.
 - Array.Sort: Diziyi sıralar.
 - Array.Clear: Dizinin elemanlarını temizler.
 - Array.Reverse: Dizinin elemanlarını ters çevirir.

 Array Slices (Dizi Dilimleri)
 - Dizinin bir kısmını almak için kullanılır.
 - DiziAdi[başlangıç indexi..bitiş indexi] şeklinde kullanılır.
  

  Çok Boyutlu Diziler
  - Dizilerin içinde dizi tutan dizilerdir.
  - DiziAdi[0][0] şeklinde erişilir.
  - 
 */