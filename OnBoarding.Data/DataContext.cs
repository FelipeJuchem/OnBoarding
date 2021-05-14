using Microsoft.EntityFrameworkCore;
using OnBoarding.Domain.Entidades.Cargos;
using OnBoarding.Domain.Entidades.Empresas;
using OnBoarding.Domain.Entidades.Funcionarios;
using OnBoarding.Domain.Entidades.FuncionariosCargos;
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
        public DbSet<FuncionarioCargo> FuncionarioCargos { get; set; }

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

            funcionario.HasOne(x => x.Empresa)
                .WithMany(x => x.Funcionarios)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.EmpresaId);

            

            var funcionarioCargo = modelBuilder.Entity<FuncionarioCargo>();

            funcionarioCargo.HasKey(x => new { x.CargoId, x.FuncionarioId });

            funcionarioCargo.HasOne(x => x.Cargo)
                .WithMany(x => x.FuncionariosCargos)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.CargoId);

            funcionarioCargo.HasOne(x => x.Funcionario)
                .WithMany(x => x.FuncionariosCargos)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.FuncionarioId);

            var cargo = modelBuilder.Entity<Cargo>();

            cargo.Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(250);




        }
    }
}
