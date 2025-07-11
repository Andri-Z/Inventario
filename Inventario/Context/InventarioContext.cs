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
            base.OnModelCreating(modelBuilder); 
        }
    }
}
