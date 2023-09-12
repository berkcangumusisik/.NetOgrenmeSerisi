var s = new Student("Ali","Ali",1);
var p = new Person("Veli","Veli");
var t = new Teacher("Ahmet","Ahmet","Matematik");
s.Print();
p.Print();
t.Print();
t.Teach();
class Person
{
    public String Name { get; set; }
    public String Surname { get; set; }

    public Person(String name, String surname)
    {
        this.Name = name;
        this.Surname = surname;
        Console.WriteLine("Person Conscructor'ı oluşturuldu.");
    }

    public void Print()
    {
        Console.WriteLine("İsim: {0} Soyisim: {1}", this.Name, this.Surname);
    }
}

class Student : Person
{
    public int StudentNumber { get; set; }
    public Student(string name, String surname, int studentNumber) : base (name, surname)
    {
        this.StudentNumber = studentNumber;
        Console.WriteLine("Student Conscructor'ı oluşturuldu.");
    }

    public virtual void Print()
    {
        Console.WriteLine("İsim: {0} Soyisim: {1} No: {2}", this.Name, this.Surname, this.StudentNumber);
    }
}

class Teacher : Person
{
    public String Branch { get; set; }
    public Teacher(String name, String surname, String branch) : base(name, surname)
    {
        this.Branch = branch;
        Console.WriteLine("Teacher Conscructor'ı oluşturuldu.");
    }
    public void Teach()
    {
        Console.WriteLine("Ben bir öğretmenim. Branşım : {0}", this.Branch);
    }
}
/**
 * Inheritance(Kalıtım)
 * Kalıtım, bir sınıfın başka bir sınıftan özelliklerini ve davranışlarını miras almasıdır.
 * Base Class (Ana Sınıf): Kalıtım veren sınıf.
 * Sub Class (Alt Sınıf): Kalıtım alan sınıf.
 * Sub Class, Base Class'ın tüm özelliklerini ve davranışlarını miras alır.
 * SubClass : BaseClass{}
 * this anahtar kelimesi, sınıfın kendisini temsil eder. this.Name, sınıfın Name özelliğini temsil eder. this.Name = name; sınıfın Name özelliğine parametre olarak gelen name değerini atar.
 * virtual anahtar kelimesi, metotların override edilebilmesini sağlar. Metot bu sayede base class'tan gelen metotu ezebilir.
 */