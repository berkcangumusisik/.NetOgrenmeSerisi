﻿using _03.EfCoreCodeFirst.Entities;
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
        public DbSet<Category> Category { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().ToTable("ProductTb"); // Tablo ismini değiştirmek için kullanılır.
            //modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("ProductName"); // Kolon ismini değiştirmek için kullanılır.
            //modelBuilder.Entity<Product>().HasKey(x => x.Id); // Primary key belirlemek için kullanılır.
            //modelBuilder.Entity<Product>().Property(x => x.Id).UseIdentityColumn(); // Identity yani otomatik artan kolon oluşturmak için kullanılır.
            //modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired();// Zorunlu alan oluşturmak için kullanılır.

            //modelBuilder.Entity<Category>().HasMany(x=>x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId); // 1'e çok ilişki kurmak için kullanılır.
            //modelBuilder.Entity<Product>().HasOne(x =>x.Category).WithOne(x => x.Product).HasForeignKey<Product>(x => x.CategoryId); // 1'e 1 ilişki kurmak için kullanılır.

            modelBuilder.Entity<Student>()
                .HasMany(x => x.Teachers)
                .WithMany(x => x.Students)
                .UsingEntity(x => x.ToTable("StudentTeacher")
                );
        }

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
