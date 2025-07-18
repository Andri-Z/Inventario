using Inventario.Context;
using Inventario.Interfaces;
using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Services
{
    public class CategoriasService : ICategorias
    {
        private readonly InventarioContext _context;
        public CategoriasService(InventarioContext context) => 
            (_context) = (context);
        public async Task<List<CategoriasModel>> GetCategoriasAsync() =>
            await _context.Categorias.ToListAsync();
        public async Task<List<CategoriasModel>?> FilterByDescripcionAsync(string descripcion)
        {
            try
            {
                var result = await _context.Categorias
                    .Where(a=> a.Descripcion!.ToLower().Contains(descripcion.ToLower()))
                    .ToListAsync();

                if (result is not null)
                    return result;
                else
                    return null;
            }
            catch
            {
                throw new Exception("Se ha producido un error al filtrar las categorias.");
            }
        }
        public async Task<CategoriasModel?> CreateCategoriaAsync(string descripcion)
        {
            try
            {
                var result = await FilterByDescripcionAsync(descripcion);
                if (result is null)
                    return null;

                if(result!.Count == 0 || result!.FirstOrDefault()!.Descripcion!.ToLower() != descripcion.ToLower())
                {
                    var _categorias = new CategoriasModel
                    {
                        Descripcion = descripcion
                    };

                    await _context.Categorias.AddAsync(_categorias);
                    await _context.SaveChangesAsync();

                    return _categorias;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw new Exception("Se ha producido un error al crear la categoria.");
            }
        }
        public async Task<CategoriasModel?> UpdateCategoriaAsync(string descripcion)
        {
            try
            {
                var exist = await _context.Categorias
                    .Where(a => a.Descripcion!.ToLower().Contains(descripcion.ToLower()))
                    .FirstOrDefaultAsync();

                if (exist is not null)
                    return null;


                await _context.Categorias.AddAsync(exist!);
                await _context.SaveChangesAsync();

                return exist;
            }
            catch
            {
                throw new Exception("Ha ocurrrido un error actualizando la categoria");
            }
        }
        public async Task<bool> DeleteCategoriaAsync(int id)
        {
            var categoriasModel = await _context.Categorias.FindAsync(id);
            if (categoriasModel != null)
            {
                _context.Categorias.Remove(categoriasModel);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
