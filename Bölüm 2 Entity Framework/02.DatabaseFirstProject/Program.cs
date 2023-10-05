// See https://aka.ms/new-console-template for more information
using _02.DatabaseFirstProject.DataAccesLayer;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using(var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
{
    var products = _context.Products.ToList();
    foreach(var product in products)
    {
        Console.WriteLine(product.Name);
    }
}