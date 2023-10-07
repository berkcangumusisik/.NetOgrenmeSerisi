using _02.DatabaseFirstProject.EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DatabaseFirstProject.DataAccesLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlConnection"));
        }
    }
}


/*
 DbContext sınıfı Entity Framework Core tarafından sağlanan bir sınıftır.
 DbContext sınıfı veritabanı bağlantısını sağlar.
 DbContext sınıfı veritabanı işlemlerini gerçekleştirir.
 */