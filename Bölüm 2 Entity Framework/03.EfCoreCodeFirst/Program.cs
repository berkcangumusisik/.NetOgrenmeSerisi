using _03.EfCoreCodeFirst.DataAccessLayer;
using _03.EfCoreCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using(var context = new AppDbContext())
{
    

    // Ürün ekleme

    var newProduct = new Product
    {
        Name = "Defter",
        Price = 100,
        Stock = 100,
        Barcode = 100
    };
    context.AddAsync(newProduct);
    context.SaveChanges();


    // Ürün güncelleme
    var product = context.Products.FirstOrDefault();
    product.Price = 300;
    context.Update(product);
    context.SaveChanges();

    // Ürün silme
    var product2 = context.Products.FirstOrDefault();
    context.Remove(product2);
    context.SaveChanges();


    var products = context.Products.ToList();
    products.ForEach(p =>
    {
        var state = context.Entry(p).State;
        Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}, Barcode: {p.Barcode}, State: {state}");
    });

    Console.WriteLine("--------------ChangeTracker------------------");
    


    context.Products.Add(new Product
    {
        Name = "Silgi",
        Price = 100,
        Stock = 100,
        Barcode = 100
    });

    context.Products.Add(new Product
    {
        Name = "Kalem",
        Price = 100,
        Stock = 100,
        Barcode = 100
    });

    context.Products.Add(new Product
    {
        Name = "Kitap",
        Price = 100,
        Stock = 100,
        Barcode = 100
    });

    Console.WriteLine($"Context Id : {context.ContextId}");

    context.SaveChanges();


}

/*
 add-migration : Bu komut ile bir migration oluşturulur. Migration, veritabanı ile kod arasındaki farkı gösteren bir sınıftır.
 update-database : Bu komut ile migration'lar veritabanına uygulanır.
 remove-migration : Bu komut ile en son oluşturulan migration geri alınır.
 script-migration : Bu komut ile migration'lar SQL script olarak alınır.
State : Bir entity'nin durumunu gösterir. Bir entity'nin durumu, veritabanında olup olmadığını, veritabanında varsa güncel olup olmadığını, veritabanında varsa güncel değilse güncellemek için bekleyip beklenmediğini gösterir.

.AddAsync() : Bu metot ile bir entity veritabanına eklenir. Bu metot ile eklenen entity'lerin durumu Added olarak işaretlenir.
.SaveChanges() : Bu metot ile değişiklikler veritabanına uygulanır. Bu metot ile uygulanan değişikliklerin durumu Unchanged olarak işaretlenir.
.Remove() : Bu metot ile bir entity veritabanından silinir. Bu metot ile silinen entity'lerin durumu Deleted olarak işaretlenir.
.Update() : Bu metot ile bir entity veritabanında güncellenir. Bu metot ile güncellenen entity'lerin durumu Modified olarak işaretlenir.
ChangeTracker : Memory'de tutulan entity'lerin durumlarını gösterir. Bu durumlar, veritabanına uygulanmadan önceki durumları gösterir. Bu durumlar, SaveChanges() metodu ile veritabanına uygulandıktan sonra Unchanged olarak değişir.
ContextId : Her bir context'in birbirinden farklı olması için oluşturulan bir id'dir. Bu id, her bir context için farklıdır.
Database : Bu property ile veritabanı işlemleri yapılır.

EF Core tarafında track edilen bir entity'de güncelleme yapıldığında tekrar update() methodunu çağırmaya gerek yoktur. Çünkü EF Core, track edilen entity'lerdeki değişiklikleri otomatik olarak algılar ve veritabanına uygular.

DbSet<> Metotları

Add : Bu metot ile bir entity veritabanına eklenir.
addAsync : Bu metot ile bir entity veritabanına eklenir.
Update : Bu metot ile bir entity veritabanında güncellenir.
Remove : Bu metot ile bir entity veritabanından silinir.
AsNoTracking : Bu metot ile bir entity track edilmez. Bu metot ile track edilmeyen entity'lerdeki değişiklikler veritabanına uygulanmaz.

 */
