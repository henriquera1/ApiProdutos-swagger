using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    
        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Nome)
                    .HasMaxLength(80);
            
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto {Id= 1, Nome = "Laranja", Descricao = "Frutas frescas", Preco = 4.50M, Estoque = 10},
                    new Produto {Id= 2, Nome = "Abacaxi", Descricao = "Frutas frescas", Preco = 6.00M, Estoque = 10},
                    new Produto {Id= 3, Nome = "Uva", Descricao = "Frutas frescas", Preco = 2.50M, Estoque = 15},
                    new Produto {Id= 4, Nome = "Melancia", Descricao = "Frutas frescas", Preco = 5.50M, Estoque = 5}
                                       
                );

            base.OnModelCreating(modelBuilder);
        }


        
    }
}
