using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Interfaces
{
    public interface ICategorias
    {
        Task<List<CategoriasModel>> GetCategoriasAsync();
        Task<CategoriasModel?> CreateCategoriaAsync(string descripcion);
        Task<CategoriasModel?> UpdateCategoriaAsync(string descripcion);
        Task<List<CategoriasModel>?> FilterByDescripcionAsync(string descripcion);
        Task<bool> DeleteCategoriaAsync(int id);
    }
}
