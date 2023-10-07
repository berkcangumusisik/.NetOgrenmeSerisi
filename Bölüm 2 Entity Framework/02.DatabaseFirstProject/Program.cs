// See https://aka.ms/new-console-template for more information
using _02.DatabaseFirstProject.DataAccesLayer;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();
    foreach (var product in products)
    {
        Console.WriteLine(product.Name, product.Price);
    }
}
