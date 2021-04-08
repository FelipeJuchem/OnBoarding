using Microsoft.EntityFrameworkCore;
using OnBoarding.Domain.Cargos;
using OnBoarding.Domain.Empresas;
using OnBoarding.Domain.Funcionarios;
using System;

namespace OnBoarding.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Cargo> Cargo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OnBoardingA");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var empresa = modelBuilder.Entity<Empresa>();

            empresa.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(250);

            empresa.Property(x => x.Id)
                 .IsRequired();


            empresa.Property(x => x.DataFundacao)
                 .IsRequired();

            var funcionario = modelBuilder.Entity<Funcionario>();

            funcionario.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(250);

            funcionario.Property(x => x.Id)
                 .IsRequired();


            funcionario.Property(x => x.DataContratacao)
                 .IsRequired();

            var cargo = modelBuilder.Entity<Cargo>();

            cargo.Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(250);




        }
    }
}
