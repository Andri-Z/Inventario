using Inventario.Context;
using Inventario.Interfaces;
using Inventario.Models;
using Inventario.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Services
{
    public class CategoriasServices : ICategorias
    {
        private readonly InventarioContext _context;
        public CategoriasServices(InventarioContext context) => 
            (_context) = (context);
        public async Task<List<CategoriasModel>> GetCategoriasAsync() =>
            await _context.Categorias.ToListAsync();
        //public async Task<CategoriasModel?> FilterCategoriasByDescripcionAsync(string descripcion)
        //{
             
        //}
        public async Task<CategoriasModel> CreateCategoriaAsync(CategoriasDTO categoria)
        {
            var _categoria = new CategoriasModel
            {
                Descripcion = categoria.Descripcion
            };
            await _context.Categorias.AddAsync(_categoria);
            await _context.SaveChangesAsync();

            return _categoria;
        }
        public async Task<CategoriasModel?> UpdateCategoriaAsync(int id, string descripcion)
        {
            var categoriaExist = await _context.Categorias.FindAsync(id);
            if (categoriaExist is null)
                return new();

            categoriaExist.Descripcion = descripcion;

            await _context.SaveChangesAsync();

            return categoriaExist;
        }
    }
}
