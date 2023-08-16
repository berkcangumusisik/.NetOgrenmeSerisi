Console.Write("1.Sayıyı Giriniz: ");
string sayi1 = Console.ReadLine();
int number1 = int.Parse(sayi1);
Console.Write("2.Sayıyı Giriniz:");
string sayi2 = Console.ReadLine();
int number2 = int.Parse(sayi2);

Console.WriteLine(number1 + number2);
Console.WriteLine(number1 - number2);
Console.WriteLine(number1 * number2);
Console.WriteLine(number1 / number2);
Console.WriteLine(number1 % number2);
Console.WriteLine(number1++);
Console.WriteLine(number2--);


Console.WriteLine(number1 == number2);
Console.WriteLine(number1 != number2);
Console.WriteLine(number1 > number2);
Console.WriteLine(number1 < number2);
Console.WriteLine(number1 >= number2);
Console.WriteLine(number1 <= number2);
Console.WriteLine(number1 >= number2);

Console.WriteLine(number1 > 0 && number2 > 0);
Console.WriteLine(number1 > 0 || number2 > 0);
Console.WriteLine(!(number1 > 0 && number2 > 0));


Console.Write("Kullanıcı Adınızı Giriniz: ");
string userName = Console.ReadLine();
Console.Write("Şifrenizi Giriniz: ");
string password = Console.ReadLine();
bool isLogin = userName == "admin" && password == "1234";
Console.WriteLine(isLogin);
/**
     Console.ReadLine() : Kullanıcıdan veri almak için kullanılır. String türünde veri alır.
     Console.Write() : Aynı satırda yazdırır.
     Aritmetik Operatörler
     + Toplama
     - Çıkarma
     * Çarpma
     / Bölme
     % Mod Alma
     ++ Bir arttırma
     -- Bir azaltma 

    Karşılaştırma Operatörleri
    == Eşittir
    != Eşit Değildir
    > Büyüktür
    "<" Küçüktür
    >= Büyük Eşittir
    <= Küçük Eşittir

    Mantıksal Operatörler
    && Ve => eğer biri false ise sonuç false olur. Her ikisi de true ise sonuç true olur.
    || Veya => eğer biri true ise sonuç true olur. Her ikisi de false ise sonuç false olur.
    ! Değil => true ise false, false ise true yapar.

*/