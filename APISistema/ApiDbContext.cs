using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SSContainer.Domain;
using SSContainer.Domain.Entities;

namespace APISistema
{
    public class ApiDbContext : IdentityDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
        
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
                .HasKey(f => f.Id);

            modelBuilder.Entity<Empresa>()
                .HasKey(f => f.Id);

            modelBuilder.Entity<Pedido>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<JoinEmpresas>()
                .HasKey(f=>f.Id);

            modelBuilder.Entity<JoinEmpresas>()
                .HasOne(f => f.EmpresaVendedora)
                .WithMany(g => g.Pedidos);

            modelBuilder.Entity<JoinEmpresas>()
                .HasOne(f => f.Cliente)
                .WithMany(g => g.Pedidos);

            modelBuilder.Entity<JoinEmpresas>()
                .HasOne(f => f.Pedido)
                .WithMany(g => g.Pedidos) ;

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
