using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class ECommerceDbContext:DbContext
    {
        //public ECommerceDbContext() : base()
        //{

        //}

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        } 

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=ECommerceDB; Trusted_Connection=True;");

        //}

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<UserBasket> UserBasket { get; set; }
        public DbSet<BasketContent> BasketContent { get; set; }










    }
}
