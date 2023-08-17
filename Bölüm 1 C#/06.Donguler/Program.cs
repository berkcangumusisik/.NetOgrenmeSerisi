/**
 * Döngü : Bir işi tekrar tekrar yapmak için kullanılan yapılardır.
 For Döngüsü
 - Belirli bir şart sağlanana kadar döngüyü çalıştırır.
 for(başlangıç; koşul; artış)
 {
    // Yapılacak işlemler
 }
 */

for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------------------------------");
// 1 ile 100 arasındaki sayıların toplamını bulunuz.
int toplam = 0;
for(int i = 1; i <= 100; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);

// Klavyeden başlangıç ve bitiş değeri girilen iki sayının arasındaki sayıların toplamını bulunuz.
Console.Write("Başlangıç Değeri: ");
int baslangic = int.Parse(Console.ReadLine());
Console.Write("Bitiş Değeri: ");
int bitis = int.Parse(Console.ReadLine());
int toplam2 = 0;
for(int i = baslangic; i <= bitis; i++)
{
    toplam2 += i;
}
Console.WriteLine(toplam2);