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
        public string? Descripcion { get; set; }

        [Column("contacto")]
        public int Contacto { get; set; }

        [Column("rnc")]
        public int RNC { get; set; }

        public ICollection<ProductosModel> Productos { get; } = new List<ProductosModel>();
    }
}
