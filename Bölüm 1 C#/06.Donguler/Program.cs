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

// While Döngüsü
/**
 * Koşul sağlandığı sürece döngüyü çalıştırır.
 while(koşul)
 {
    // Yapılacak işlemler
 }
 */
 

int sayi6 = 0;
while(sayi6 < 10)
{
    Console.WriteLine(sayi6);
    sayi6++;
}


// Klavyeden girilen sayının faktöriyelini bulunuz.
Console.Write("Bir Sayı Giriniz: ");
int sayi7 = int.Parse(Console.ReadLine());
int faktoriyel = 1;
while(sayi7 > 0)
{
    faktoriyel *= sayi7;
    sayi7--;
}
Console.WriteLine(faktoriyel);

//break ve continue
//break : Döngüyü sonlandırmak için kullanılır.
//continue : Döngü o değeri atlayarak devam ettirmek için kullanılır.


for(int i = 0; i < 10; i++)
{
    if(i == 5)
        break;
    Console.WriteLine(i);
}

for(int i = 0; i < 10; i++)
{
    if(i == 5)
        continue;
    Console.WriteLine(i);
}


// Do While Döngüsü
/**
 * Koşul sağlansa da sağlanmasa da döngüyü en az bir kere çalıştırır.
 do
 {
    // Yapılacak işlemler
 } while(koşul);
 */


int sayi8 = 0;
do
{
    Console.WriteLine(sayi8);
    sayi8++;
} while(sayi8 < 10);

// Foreach Döngüsü
/** 
 foreach (değişken_türü değişken_ismi in dizi)
 {
    // Yapılacak işlemler
 }
 */

string ad = "Berkcan";
foreach(char harf in ad)
{
    Console.WriteLine(harf);
}