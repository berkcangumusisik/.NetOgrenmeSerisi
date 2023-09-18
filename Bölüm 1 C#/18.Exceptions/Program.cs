try
{
    Console.Write("1. Sayıyı giriniz: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("2. Sayıyı giriniz: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    var result = number1 / number2;
    Console.WriteLine("Sonuç: " + result);

}
catch(DivideByZeroException ex)
{
    Console.WriteLine("2.sayı 0 olamaz.");
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Lütfen sayısal bir değer giriniz.");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}

string password = "123456789";
try
{
    check_password(password);
    Console.WriteLine("Parola geçerli.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

var liste = new List<string>()
{
    "1", "2","5a", "10b", "abc", "10", "50"
};
foreach (var item in liste)
{
    try
    {
        int a = int.Parse(item);
        Console.WriteLine(a);
    }catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void check_password(String password)
{
    if(password.Length < 8 && password.Length > 15)
    {
        throw new Exception("Parola 8 ile 15 karakter arasında olmalıdır.");
    }
    if (!password.Any(char.IsDigit))
    {
        throw new Exception("Parola en az 1 rakam içermelidir.");
    }
    if (!password.Any(char.IsLetter))
    {
        throw new Exception("Parola en az 1 harf içermelidir.");
    }
}


/*
 Hata Türleri
- Compile Time Error (Derleme Zamanı Hatası) : Derleme sırasında ortaya çıkan hatalardır. Bu hatalar derleme işlemi başarısız olduğunda ortaya çıkar.
- Run Time Error (Çalışma Zamanı Hatası) : Programın çalışma anında ortaya çıkan hatalardır. Bu hatalar program çalışırken ortaya çıkar.
- FormatException : Veri tipi uygun değilse ortaya çıkar.
- DivideByZeroException : Bir sayıyı 0'a bölmeye çalıştığımızda ortaya çıkar.
try{
    // Hata olabilecek kodlar
}
catch(Exception ex){
    // Hata olduğunda çalışacak kodlar
}
finally{
    // Hata olsa da olmasa da çalışacak kodlar
}

throw new Exception("Hata mesajı"); // Exception sınıfından yeni bir hata oluşturur.
 */