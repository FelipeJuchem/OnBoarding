using Microsoft.EntityFrameworkCore;
using OnBoarding.Domain.Empresas;
using System;

namespace OnBoarding.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Empresa> Empresa {get ; set;}
    }
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OnBoarding");
        }
    }
}
