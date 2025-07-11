using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    [Table("productos")]
    public class ProductosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripcion del producto no puede estar vacia.")]
        [Length(2,30,ErrorMessage = "La longitud de la descripcion es incorrecta.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El costo del producto no puede estar vacio.")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El Precio Unitario no puede estar vacio.")]
        [Column("precio_unitario")]
        public decimal PrecioUnitario { get; set; }

        [Required]
        [Column("idCategoria")]
        [ForeignKey("Categorias")]
        public ICollection<CategoriasModel> IdCategoria { get; set; } = null!;

        [Required]
        [Column("idProveedor")]
        [ForeignKey("Proveedores")]
        public int IdProveedor { get; set; }
    }
}
