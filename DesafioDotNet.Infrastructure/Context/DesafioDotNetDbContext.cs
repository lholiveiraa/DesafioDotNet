using Microsoft.EntityFrameworkCore;
using DesafioDotNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioDotNet.Domain.Model;
using DesafioDotNet.Domain.Models;

namespace DesafioDotNet.Infrastructure.Context
{

    public class DesafioDotNetDbContext : DbContext
    {
        public DesafioDotNetDbContext(DbContextOptions<DesafioDotNetDbContext> options) : base(options) { }

        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configurações de mapeamento de entidades, se necessário.

        //    modelBuilder.Entity<ItemPedido>().ToTable("ItensPedido")
        //        .HasOne(ip => ip.Pedido)
        //        .WithMany(p => p.ItensPedido)
        //        .HasForeignKey(ip => ip.IdPedido)
        //        .HasConstraintName("FK__ItensPedi__IdPed__4D94879B");

        //    //modelBuilder.Entity<Pedido>().ToTable("Pedido");

        //    // Exemplo de configuração para a nova entidade PedidoModel
        //    //modelBuilder.Entity<Pedido>();

        //    modelBuilder.Entity<Pedido>()
        //         .HasMany(p => p.ItensPedido)
        //         .WithOne(ip => ip.Pedido)
        //         .HasForeignKey(ip => ip.IdPedido)
        //         .HasConstraintName("FK__ItensPedi__IdPed__4D94879B")
        //         .HasPrincipalKey(p => p.Id)
        //         .HasConstraintName("PK__PEDIDO__3214EC07EB8AB5A1");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configurações de mapeamento de entidades, se necessário.
        //}
    }
}
