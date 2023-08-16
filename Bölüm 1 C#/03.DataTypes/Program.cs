byte sayi = 5;
Console.WriteLine(sayi);
double kdvOrani = 0.18;
Console.WriteLine(kdvOrani);
char karakter = 'A';
Console.WriteLine(karakter);
String ad = "Ahmet";
Console.WriteLine(ad);
bool dogruMu = true;
Console.WriteLine(dogruMu);


string metin1 = "100";
int s1 = int.Parse(metin1);
int s2 = Convert.ToInt32(metin1);

string metin2 = "True";
bool b1 = bool.Parse(metin2);
bool b2 = Convert.ToBoolean(metin2);


/**
 Veri Türleri
 - Value Types (Değer Tipleri) : int, float, double, decimal, bool, char, byte, short, long, struct
 - Reference Types (Referans Tipleri) : string, class, interface, object, dynamic
 Tam Sayı Veri Tipleri
- int : 32 bit  
- long : 64 bit en büyük sayısal veri tipi
- short : 16 bit -32768 - 32767
- byte : 8 bit 0-255
 Ondalıklı Sayı Veri Tipleri
- float : 32 bit
- double : 64 bit   
- decimal : 128 bit en büyük ondalıklı sayısal veri tipi
    Mantıksal Veri Tipleri
- bool : true, false
Char Veri Tipi => Tek karakter tutar ve tek tırnak ile tanımlanır.

var anahtar kelimesi ile değişken tanımlanabilir. Ancak var ile değişken tanımlamak yerine veri tipini belirtmek daha doğrudur.

Parse ve Convert ile değişken dönüşümü yapılabilir.
 */

