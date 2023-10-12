using _03.EfCoreCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EfCoreCodeFirst.DataAccessLayer
{
    public class AppDbContext :DbContext
    {
        public DbSet<Product> Products { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity <Product>().ToTable("ProductTb"); // Tablo ismini değiştirmek için kullanılır.
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("ProductName"); // Kolon ismini değiştirmek için kullanılır.
            modelBuilder.Entity<Product>().HasKey(x => x.Id); // Primary key belirlemek için kullanılır.
            modelBuilder.Entity<Product>().Property(x => x.Id).UseIdentityColumn(); // Identity yani otomatik artan kolon oluşturmak için kullanılır.
          modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired  (); // Zorunlu alan oluşturmak için kullanılır.

        public override int SaveChanges()
        {
            ChangeTracker.Entries().ToList().ForEach(entry =>
            {
                if (entry.Entity is Product p)
                {
                    if (entry.State == EntityState.Added)
                    {
                        p.CreatedDate = DateTime.Now;
                    }
                }
            });

            return base.SaveChanges();
        }
    }


}
