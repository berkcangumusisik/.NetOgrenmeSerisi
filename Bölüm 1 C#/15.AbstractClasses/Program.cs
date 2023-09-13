var s = new Student("Ali", "Ali", 1);
var t = new Teacher("Ahmet", "Ahmet", "Matematik");
s.Print();
t.Print();
t.Teach();

var shapes = new Shape[3];
shapes[0] = new Square(10,10);
shapes[1] = new Rectangle(15,15);
shapes[2] = new Shape(15,20);

foreach (var item in shapes)
{
    item.Draw();
    Console.WriteLine(item.CalculateArea());
}
abstract class Person
{
    public String Name { get; set; }
    public String Surname { get; set; }

    public Person(String name, String surname)
    {
        this.Name = name;
        this.Surname = surname;
        Console.WriteLine("Person Conscructor'ı oluşturuldu.");
    }

    public abstract void Print();

    public void Greeting()
    {
        Console.WriteLine("Ben bir insanım");
    }

}

class Student : Person
{
    public int StudentNumber { get; set; }
    public Student(string name, String surname, int studentNumber) : base(name, surname)
    {
        this.StudentNumber = studentNumber;
        Console.WriteLine("Student Conscructor'ı oluşturuldu.");
    }

   

    public override void Print()
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

    public override void Print()
    {
        Console.WriteLine("İsim: {0} Soyisim: {1} Branş: {2}", this.Name, this.Surname, this.Branch);
    }

    
}


class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Shape(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Şekil çizildi.");
    }
    public int CalculateArea()
    {
        return this.Width * this.Height;
    }
}

class Square: Shape
{
    public override void Draw()
    {
        Console.WriteLine("Kare çizildi.");
    }
    public Square(int width, int height) : base(width, height)
    {
        this.Width = width;
        this.Height = height;
    }

}

class Rectangle: Shape
{
    public Rectangle(int width, int height) : base(width, height)
    {
        this.Width = width;
        this.Height = height;
    }

    public override void Draw()
    {
        Console.WriteLine("Dikdörtgen çizildi.");
    }

}
/**
 * Abstract sınıflar soyut sınıflardır. Soyut sınıfların içerisinde soyut metotlar bulunur.
 */