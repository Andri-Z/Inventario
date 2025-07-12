using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models.DTOs
{
    public class ProveedoresDTO
    {
        public string? Descripcion { get; set; }
        public int Contacto { get; set; }
        public int RNC { get; set; }
        public ProveedoresDTO(ProveedoresModel proveedores)
        {
            Descripcion = proveedores.Descripcion;
            Contacto = proveedores.Contacto;
            RNC = proveedores.RNC;
        }
        public ProveedoresDTO() { }
    }
}
