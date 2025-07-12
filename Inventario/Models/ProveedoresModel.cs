using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public class ProveedoresModel
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("descripcion")]
        [Required(ErrorMessage = "Tiene que ingresar el nombre del proveedor")]
        [Length(2,30, ErrorMessage = "La Longitud de la descripcion es incorrecta.")]
        public string? Descripcion { get; set; }

        [Column("contacto")]
        [Required(ErrorMessage = "Tiene que ingresar el contacto del proveedor.")]
        [Length(10,10,ErrorMessage = "El numero de telefono ingresado no tiene la longitud correcta.")]
        public int Contacto { get; set; }

        [Column("rnc")]
        [Required(ErrorMessage = "Tiene que ingresar el RNC del proveedor.")]
        [Length(9,9,ErrorMessage = "La longitud del RNC ingresado no es correcto.")]
        public int RNC { get; set; }

        public ICollection<ProductosModel> Productos { get; } = new List<ProductosModel>();
    }
}
