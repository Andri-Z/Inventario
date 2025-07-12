using Inventario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Context
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options)
        {

        }
        public DbSet<CategoriasModel>? Categorias;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriasModel>(options =>
            {
                options.ToTable("categorias", schema: "InventarioDB");
                
                options.HasKey(c => c.Id);
                options.Property(c => c.Id)
                        .ValueGeneratedOnAdd();

                options.Property(c => c.Descripcion)
                       .IsRequired()
                       .HasMaxLength(20);
            });
            modelBuilder.Entity<ProveedoresModel>(options =>
            {
                options.ToTable("proveedores", schema: "InventarioDB");
                
                options.HasKey(c => c.Id);
                options.Property(c => c.Id)
                        .ValueGeneratedOnAdd();

                options.Property(c => c.Descripcion)
                       .IsRequired()
                       .HasMaxLength(30);

                options.Property(c => c.Contacto)
                       .IsRequired()
                       .HasMaxLength(10);

                options.Property(c => c.RNC)
                       .IsRequired()
                       .HasMaxLength(9);
            });
            modelBuilder.Entity<ProductosModel>(options =>
            {
                options.ToTable("productos", schema: "InventarioDB");
                options.ToTable(tb => tb.HasCheckConstraint("ck_costo", "[costo] >= 0"));
                options.ToTable(tb => tb.HasCheckConstraint("ck_precioUnitario", "[precio_unitario] >= 0"));

                options.HasKey(c=>c.Id);
                options.Property(c => c.Id)
                       .ValueGeneratedOnAdd();

                options.Property(c => c.Descripcion)
                       .IsRequired()
                       .HasMaxLength(30);

                options.Property(c => c.Costo)
                       .HasColumnType("decimal (10,2)")
                       .IsRequired();

                options.Property(c => c.PrecioUnitario)
                       .HasColumnType("decimal (10,2)")
                       .HasColumnName("precio_unitario")
                       .IsRequired();

                options.Property(c => c.IdCategoria)
                       .HasColumnName("idCategoria");

                options.Property(c => c.IdProveedor)
                       .HasColumnName("idProveedor");

            });

            modelBuilder.Entity<ProductosModel>()
                        .HasOne(c => c.Categoria)
                        .WithMany(c => c.Productos)
                        .HasForeignKey(c => c.IdCategoria)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductosModel>()
                        .HasOne(c=>c.Proveedores)
                        .WithMany(c=>c.Productos)
                        .HasForeignKey(c=>c.IdProveedor)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
