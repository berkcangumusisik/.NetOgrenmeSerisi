// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(5000 * 1.08);
Console.WriteLine(6000 * 1.08);
Console.WriteLine(7000 * 1.08);

// 1.08'i 1.20 yapmak istersem tek tek güncellemem gerekir. Ama değişken kullanırsam tek bir yerden güncelleyebilirim.

var kdvOrani = 1.20

Console.WriteLine(5000 * kdvOrani);
Console.WriteLine(6000 * kdvOrani);
Console.WriteLine(7000 * kdvOrani);
/**
 Değişken Nedir?
 * Değer alabilen yapılardır.
 * Her seferinde değiştirilebilirler.
 * Geçici bellekte saklanır. Uygulama sonlandırıldığında veriler bellekten silinir.
 * Bellekte daha az veri saklar.
 * Değişkenin veri tipleri vardır. Saklanan veriye göre farklı boyutlarda yer tutarlar.
 * 
 */