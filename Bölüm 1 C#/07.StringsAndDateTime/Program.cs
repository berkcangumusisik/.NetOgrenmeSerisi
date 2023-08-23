String mesaj = "Hello World!";
Console.WriteLine(mesaj.Length);
Console.WriteLine(mesaj.ToUpper());
Console.WriteLine(mesaj.ToLower());
Console.WriteLine(mesaj.Trim());
Console.WriteLine(mesaj.Split(' ')[0]);
Console.WriteLine(mesaj.StartsWith("Hello"));
Console.WriteLine(mesaj.EndsWith("World!"));
Console.WriteLine(mesaj.Contains("World!"));
Console.WriteLine(mesaj.IndexOf("World!"));

String kursAdi = ".NET 7 ile C# Programlama Dili";
Console.WriteLine(kursAdi.Length);
Console.WriteLine(kursAdi.ToUpper());
Console.WriteLine(kursAdi.ToLower());
Console.WriteLine(kursAdi.StartsWith("."));
Console.WriteLine(kursAdi.IndexOf("C#"));
Console.WriteLine(kursAdi.Contains("C#"));
kursAdi.Replace("Dili", "Dersleri");
Console.WriteLine(kursAdi);

/**
 String Metotları
 - Length -> String'in uzunluğunu verir.
 - ToUpper -> String'i büyük harfe çevirir.
 - ToLower -> String'i küçük harfe çevirir.
 - Trim -> String'in başındaki ve sonundaki boşlukları siler.
 - Split -> String'i belirtilen karaktere göre ayırır.
 - StartsWith -> String belirtilen karakterle başlıyorsa true döner.
 - EndsWith -> String belirtilen karakterle bitiyorsa true döner.
 - Contains -> String belirtilen karakteri içeriyorsa true döner.
 - IndexOf -> String belirtilen karakterin kaçıncı indexte olduğunu verir.

 */

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.DayOfWeek);

/**
 DateTime Metotları
 * DateTime.Now -> Şu anki zamanı verir.
 * DateTime.Now.Year -> Şu anki yıl bilgisini verir.
 * DateTime.Now.Month -> Şu anki ay bilgisini verir.
 * DateTime.Now.Day -> Şu anki gün bilgisini verir.
 * 
 */