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
        Task<List<CategoriasModel>> GetCategorias();
    }
}
