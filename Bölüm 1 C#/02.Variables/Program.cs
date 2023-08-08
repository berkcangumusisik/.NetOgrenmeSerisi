
Console.WriteLine(5000 * 1.08);
Console.WriteLine(6000 * 1.08);
Console.WriteLine(7000 * 1.08);

// 1.08'i 1.20 yapmak istersem tek tek güncellemem gerekir. Ama değişken kullanırsam tek bir yerden güncelleyebilirim.

var kdvOrani = 1.20;
var urunA = 5000;
var urunB = 6000;
var urunC = 7000;
Console.WriteLine(urunA * kdvOrani);
Console.WriteLine(urunB * kdvOrani);
Console.WriteLine(urunC * kdvOrani);



/**
 Değişken Nedir?
 * Değer alabilen yapılardır.
 * Her seferinde değiştirilebilirler.
 * Geçici bellekte saklanır. Uygulama sonlandırıldığında veriler bellekten silinir.
 * Bellekte daha az veri saklar.
 * Değişkenin veri tipleri vardır. Saklanan veriye göre farklı boyutlarda yer tutarlar.
 
Değişken Tanımlama Kuralları
 * Değişken tanımlama şekli veriTürü degiskenAdi = deger; seklinde tanımlanır.
 * Türkce karakter kullanılmaz.
 * Boşluk olamaz.
 * Değişkenin adı sayı ile başlayamaz. Harf ya da _ ile başlayabilir.
 * _ hariç özel karakter kullanılmaz.
 * camelCase ya da degisken_ismi şekline kullanılabilir.
 * Büyük küçük harf duyarlıdır.
 * 
 */