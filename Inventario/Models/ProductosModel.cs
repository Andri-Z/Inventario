using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public class ProductosModel
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("costo")]
        public decimal Costo { get; set; }

        [Column("precio_unitario")]
        public decimal PrecioUnitario { get; set; }

        [Column("idCategoria")]
        public int IdCategoria { get; set; }
        public CategoriasModel? Categoria { get; set; }

        [Column("idProveedor")]
        public int IdProveedor { get; set; }

        public ProveedoresModel? Proveedores { get; set; }
    }
}
