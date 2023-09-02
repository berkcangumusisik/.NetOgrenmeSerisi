

using System.Collections;
/** 
ArrayList
- ArrayList bir koleksiyon sınıfıdır.
- ArrayList sınıfı System.Collections isim alanında bulunur.
- ArrayList sınıfı dizilerden farklı olarak boyutu dinamik olarak değiştirilebilen bir koleksiyon sınıfıdır.
- Tipe bağlı olmayan bir koleksiyon sınıfıdır. Yani içerisinde farklı tiplerde veriler tutabilir.
- .Add () metodu ile eleman eklenebilir.
- ArrayList list = new ArrayList(); şeklinde tanımlanır.
- .AddRange () metodu ile birden fazla eleman eklenebilir.
- .Insert() metodu ile belirtilen indexe eleman eklenebilir.
- .Remove() metodu ile belirtilen eleman silinebilir. Bulduğu ilk elemanı siler.
- .RemoveAt() metodu ile belirtilen indexdeki eleman silinebilir.
- .RemoveRange() metodu ile belirtilen index aralığındaki elemanlar silinebilir.
- .Contains() metodu ile belirtilen elemanın koleksiyonda olup olmadığı kontrol edilebilir.
*/
ArrayList list = new ArrayList();
list.Add(1);
list.Add("Ali");
list.Add(true);
list.Add('A');
list.Add(200);

int[] numbers = {10, 20, 30};
list.AddRange(numbers);

foreach (var item in list)
{
    Console.WriteLine(item);
}

list.Insert(1, "Veli");

list.Remove(true);
list.RemoveAt(0);
list.RemoveRange(2, 2);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine(list.Contains("Ali"));

/**
 * Hashtable
 - Hashtable bir koleksiyon sınıfıdır.
 - Hashtable bizim belirleyeceğimiz bir anahtar ile değer tutar.
 - Hashtable sınıfı System.Collections isim alanında bulunur.
 */

Hashtable hashtable = new Hashtable();
hashtable.Add("book", "kitap");
hashtable.Add("table", "masa");

Console.WriteLine(hashtable["book"]);
Console.WriteLine(hashtable.ContainsValue("masa"));

hashtable["software"] = "yazılım";

hashtable.Remove("book");


Hashtable dictionary = new Hashtable();
do
{
    Console.Clear();
    Console.WriteLine("Eklemek istediğiniz kelimeyi giriniz: ");
    Console.Write("EN: ");
    string en = Console.ReadLine();
    Console.Write("TR: ");
    string tr = Console.ReadLine();
    bool kontrol = dictionary.Contains(en);
    if (kontrol)
    {
        Console.WriteLine("Bu kelime zaten mevcut!");
    }
    else
    {
        dictionary.Add(en, tr);
    }
    Console.WriteLine("Başka kelime eklemek istiyor musunuz? (E/H)");
} while (Console.ReadLine().ToUpper() == "E");

foreach (DictionaryEntry item in dictionary)
{
    Console.WriteLine(item.Key + " : " + item.Value);
}
