using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add("10");
arrayList.Add(20);
arrayList.Add(30.5);
arrayList.Add(true);
arrayList.Add('A');


ArrayList arrayList1 = new ArrayList() { 10,"10", 30.5, true};

// Elemanlara erişim
Console.WriteLine(arrayList[0]);

arrayList.Insert(0, 100);

arrayList.InsertRange(0, arrayList1);
arrayList.RemoveAt(0);
arrayList.RemoveRange(0, 2);
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

ArrayList numbers = new ArrayList() { 10, 20, 3, 4, 50 };
numbers.Sort();
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
/**
 * ArrayList koleksiyonu, her türlü veri tipini içerisinde barındırabilir.
 * ArrayList koleksiyonu, içerisindeki verileri Object tipinde tutar.
 * .Add() metodu ile ArrayList'e veri eklenir.
 * .Insert() metodu ile ArrayList'e veri eklenir. İstenilen index'e veri eklenir.
 * .InsertRange() metodu ile ArrayList'e birden fazla veri eklenir. İstenilen index'e veri eklenir.
 * .Remove() metodu ile ArrayList'ten veri silinir.
 * .RemoveAt() metodu ile ArrayList'ten veri silinir. İstenilen index'teki veri silinir.
 * RemoveRange() metodu ile ArrayList'ten birden fazla veri silinir. İstenilen index'teki veri silinir.
 * .Sort() metodu ile ArrayList içerisindeki veriler sıralanır.
 */


// Generic List
List<int> numbers2 = new List<int>();
numbers2.Add(10);
numbers2.Add(20);
numbers2.Add(30);
List<Product> products = new List<Product>();
products.Add(new Product { Id = 1, Name = "Acer Laptop", Price = 1000 });
products.Add(new Product { Id = 2, Name = "Asus Laptop", Price = 2000 });
products.Add(new Product { Id = 3, Name = "Hp Laptop", Price = 3000 });


Dictionary<int, string> cities = new Dictionary<int, string>();
cities.Add(34, "İstanbul");
cities.Add(06, "Ankara");
cities.Add(35, "İzmir");
foreach (var item in cities)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
/**
 * Dinamik bir koleksiyon yapısıdır.
 * Liste ile Generic List arasındaki fark, Generic List ile oluşturulan koleksiyonun tip güvenli olmasıdır.
 * <T> tip güvenliği sağlar. T yerine istenilen tip yazılabilir.
 */


// Dictionary
/**
 * Dictionary koleksiyonu, key-value yapısında çalışır.
 * Dictionary koleksiyonu, Generic bir koleksiyondur.
 */