using Inventario.Models;
using Inventario.Models.DTOs;
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
        Task<CategoriasModel> CreateCategoriaAsync(CategoriasDTO categoria);
        Task<CategoriasModel?> UpdateCategoriaAsync(int id, string descripcion);
        Task<List<CategoriasModel>> FilterByDescripcionAsync(string descripcion);
    }
}
