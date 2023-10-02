using _19.LINQ;
/**
* LINQ
Bizim için bir çok işi kolaylaştıran bir yapıdır.
LINQ ile birlikte veri tabanı işlemleri, dosya işlemleri, koleksiyon işlemleri, XML işlemleri gibi bir çok işlemi kolaylıkla yapabiliriz.
Temel olarak LINQ ile birlikte bir veri kaynağından veri alırız ve bu veriler üzerinde sorgulamalar yaparız.
Tek satırda bir çok işi yapabiliriz.
*/
DataSource dataSource = new DataSource();
List<Customer> customers = dataSource.customerList();

// A ile başlayan müşteri sayısı
int count = 0;
for (int i = 0; i < customers.Count; i++)
{
    if (customers[i].Name == "A")
    {
           count++;
    }
}

Console.WriteLine("A ile başlayan kişi sayısı " + count);

Console.WriteLine(customers.Count());


int count2 = customers.Where(x => x.Name == "A").Count();   
Console.WriteLine("A ile başlayan kişi sayısı " + count2);

