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
        [Required(ErrorMessage = "La descripcion del producto no puede estar vacia.")]
        [Length(2,30,ErrorMessage = "La longitud de la descripcion es incorrecta.")]
        public string? Descripcion { get; set; }

        [Column("costo")]
        [Required(ErrorMessage = "El costo del producto no puede estar vacio.")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El Precio Unitario no puede estar vacio.")]
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
