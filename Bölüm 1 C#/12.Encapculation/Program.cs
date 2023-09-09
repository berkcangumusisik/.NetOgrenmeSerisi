namespace _12.Encapculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ahmet";
            customer.LastName = "Ahmet";
            customer.EmailAddress = "abc@gmail.com";

        }

    }
}
/**
 * Encapsulation (Kapsülleme)
 * Genel olarak bir nesnenin içerisindeki verilerin dışarıdan erişime kapalı olmasıdır.
 * get ve set metotları ile erişim sağlanır.
 * get : Database veya farklı bir veri kaynağından veri okunur. Datayı gösterdiğimiz kısım.
 * set : Dış dünyadan alınan datanın içeride private olarak saklanan field içerisinde değer atandığı kısım. veri kaynağına yazma işlemi.
 */