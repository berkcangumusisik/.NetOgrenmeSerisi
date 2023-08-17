Console.Write("Kullanıcı Adınızı Giriniz: ");
string userName = Console.ReadLine();

Console.Write("Şifrenizi Giriniz: ");
string password = Console.ReadLine();

if (userName == "admin")
{
  if(password == "1234")
    {
        Console.WriteLine("Giriş Başarılı");
    }
    else
    {
        Console.WriteLine("Şifre Hatalı");
    }

}

else
{
    Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı");
}

Console.WriteLine("Menü");
Console.WriteLine("1 - Toplama");
Console.WriteLine("2 - Çıkarma");
Console.WriteLine("3 - Çarpma");
Console.WriteLine("4 - Bölme");
Console.WriteLine("5 - Mod Alma");
Console.WriteLine("6 - Çıkış");

Console.Write("Seçiminiz: ");
string secim = Console.ReadLine();

Console.Write("1.Sayıyı Giriniz: ");
string sayi1 = Console.ReadLine();
int number1 = int.Parse(sayi1);

Console.Write("2.Sayıyı Giriniz:");
string sayi2 = Console.ReadLine();
int number2 = int.Parse(sayi2);

if(secim == "1")
{
    Console.WriteLine(number1 + number2);
}
else if(secim == "2")
{
    Console.WriteLine(number1 - number2);
}
else if(secim == "3")
{
    Console.WriteLine(number1 * number2);
}
else if(secim == "4")
{
    Console.WriteLine(number1 / number2);
}
else if(secim == "5")
{
    Console.WriteLine(number1 % number2);
}
else if(secim == "6")
{
    Console.WriteLine("Çıkış Yapıldı");
}
else
{
    Console.WriteLine("Hatalı Seçim");
}

//Vize ve Final Notu Girilen öğrencinin harf notunu hesaplayan program
Console.Write("Vize Notunuzu Giriniz: ");
string vizeNotu = Console.ReadLine();
int vize = int.Parse(vizeNotu);

Console.Write("Final Notunuzu Giriniz: ");
string finalNotu = Console.ReadLine();
int final = int.Parse(finalNotu);

double ortalama = (vize * 0.4) + (final * 0.6);

if (ortalama < 50)
{
    Console.WriteLine("FF ile kaldınız");
}
else if (ortalama < 60)
{
    Console.WriteLine("DD ile geçtiniz");
}
else if (ortalama < 70)
{
    Console.WriteLine("CC ile geçtiniz");
}
else if (ortalama < 80)
{
    Console.WriteLine("BB ile geçtiniz");
}
else if (ortalama < 90)
{
    Console.WriteLine("BA ile geçtiniz");
}
else if (ortalama <= 100)
{
    Console.WriteLine("AA ile geçtiniz");
}

Console.Write("Bir Sayı Giriniz: ");
string sayi = Console.ReadLine();
int number = int.Parse(sayi);
switch (number)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Hatalı Giriş");
        break;
}

int sayi5 = -10;
string sonuc = sayi5 > 0 ? "Pozitif" : "Negatif";
Console.WriteLine(sonuc);
/*
 if(kosul)
 {
    // Kosul saglaninca calisacak kodlar
 }
 else if(baskaKosul)
 {
    // BaşkaKoşul sağlanırsa calisacak kodlar
 }
 else
 {
    // Kosullar saglanmazsa calisacak kodlar
 }


 switch(degisken)
 {
    case deger1:
        // Deger1 icin yapilacaklar
        break;
    case deger2:
        // Deger2 icin yapilacaklar
        break;
    default:
        // Yukaridaki degerlerden hicbiri degilse yapilacaklar
        break;
 }

Terary Operator
Kosul ? Dogruysa : Yanlissa
 */