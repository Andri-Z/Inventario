using Inventario.Context;
using Inventario.Interfaces;
using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Services
{
    public class CategoriasServices : ICategorias
    {
        private readonly InventarioContext _context;
        public CategoriasServices(InventarioContext context) => 
            (_context) = (context);
        public async Task<List<CategoriasModel>> GetCategorias()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return categorias is not null ? categorias : new();
        }
    }
}
