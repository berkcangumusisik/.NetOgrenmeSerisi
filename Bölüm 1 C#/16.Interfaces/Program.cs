var people = new IPerson[3];
people[0] = new Boss("Ali", "Ankara","IT");
people[1] = new Worker("Berkcan", "İstanbul","Yazılım");
people[2] = new Boss("Ahmet", "Afyon","Finans");

interface IPerson
{
    String FullName { get; set; }
    String Address { get; set; }
    String Department { get; set; }
    double Salary { get; set; }
    void Info();
}

class Boss : IPerson
{
    public Boss(string fullName, string address, string department)
    {
        this.FullName = fullName;
        this.Address = address;
        this.Department = department;
    }

    public string FullName { get  ; set  ; }
    public string Address { get  ; set  ; }
    public string Department { get  ; set  ; }
    public double Salary { get; set; }

    public void Info()
    {
        Console.WriteLine("İsim: {0} Adres: {1} Departman: {2}", this.FullName, this.Address, this.Department);
    }
}

class Worker : IPerson
{
    public Worker(string fullName, string address, string department)
    {
        this.FullName = fullName;
        this.Address = address;
        this.Department = department;
    }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string Department { get; set; }
    public double Salary { get ; set; }

    public void Info()
    {
        Console.WriteLine("İsim: {0} Adres: {1} Departman: {2}", this.FullName, this.Address, this.Department);
    }
}
/**
 * Interface 
 * I Anahtar kelimesi ile tanımlanır.
 * Interface içerisindeki metotlar ve özellikler varsayılan olarak publictir.
 * Classlardan farklı olarak interface içerisindeki metotlar gövdesizdir.
 * 
*/