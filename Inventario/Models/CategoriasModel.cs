using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    [Table("categorias")]
    public class CategoriasModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Length(2,20, ErrorMessage = "La longitud de la categoria es incorrecta.")]
        public string? Descripcion { get; set; }
    }
}
