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
                .Property(p => p.nomeFruta)
                    .HasMaxLength(80);
            
            modelBuilder.Entity<Produto>()
                .Property(p => p.valorFruta)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto {Id= 1, nomeFruta = "Laranja", descricaoFruta = "Frutas frescas", valorFruta = 4.50M, qtdFruta = 10, fotoFruta = "" },
                    new Produto {Id= 2, nomeFruta = "Abacaxi", descricaoFruta = "Frutas frescas", valorFruta = 6.00M, qtdFruta = 10, fotoFruta= "" },
                    new Produto {Id= 3, nomeFruta = "Uva", descricaoFruta = "Frutas frescas", valorFruta = 2.50M, qtdFruta = 15, fotoFruta= ""},
                    new Produto {Id= 4, nomeFruta = "Melancia", descricaoFruta = "Frutas frescas", valorFruta = 5.50M, qtdFruta = 5, fotoFruta= ""}
                                       
                );

            base.OnModelCreating(modelBuilder);
        }


        
    }
}
