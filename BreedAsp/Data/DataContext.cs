using BreedAsp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreedAsp.Data
{
    public class DataContext:DbContext
    {
      public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Header> Headers { get; set; }
        public DbSet<AboutSection> AboutSections { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Tesitmonial> Tesitmonials { get; set; }
    }
}
