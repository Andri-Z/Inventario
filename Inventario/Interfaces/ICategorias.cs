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
        Task<List<CategoriasModel>> GetCategorias();
        Task<CategoriasModel> CreateCategoria(CategoriasDTO categoria);
        Task<CategoriasModel?> UpdateCategoria(int id, string descripcion);
    }
}
