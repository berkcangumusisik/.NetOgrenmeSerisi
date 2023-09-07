namespace _11.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = 1;
            student.FullName = "Emirhan";
            student.Class = "12/A";

            Student student1 = new Student();
            student1.ID = 2;
            student1.FullName = "Yunus";
            student1.Class = "12/B";

            Student student2 = new Student() { ID = 3, Class = "12/C", FullName = "Berkcan"};
            Student[] students = new Student[3] {student, student1, student2};
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Info();
            }

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Ahmet";
            customer.Surname = "Yılmaz";
            customer.Address = "İstanbul";

            Customer customer1 = new Customer();
            customer1.ID = 2;
            customer1.Name = "Mehmet";
            customer1.Surname = "Yılmaz";
            customer1.Address = "İstanbul";



        }

    }
}

/**
 * OOP konusundaki temel fikir iş prosedürlerini bir arada tutmak ve tekrar tekrar kullanmaktır.
 * Mesela bir banka uygulaması yazıyorsunuz ve her müşteri için hesap açma, hesap kapatma, para yatırma, para çekme gibi işlemler yapmanız gerekiyor.
 * Class oluşturma
 * [ErişimBelirleyicisi] class SinifAdi{}
 * Class içinde property tanımlama : Özellikler burada tanımlanır. Propertylerin baş harfi büyük olur. prop yazıp tab tab yaparsanız otomatik olarak property oluşturur.
 * Constructor : Class'ın instance'ı alındığında çalışan metotlardır. Class'ın ismi ile aynı olmak zorundadır. Constructor'lar parametre alabilir. Proje başlatıldığında ilk çalışan metot constructor'dır.
 * this : Class içindeki propertylere erişmek için kullanılır.
 
 */