using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.Dto
{
    public class CategoriaEliminar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
