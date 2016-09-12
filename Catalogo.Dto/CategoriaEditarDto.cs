using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.Dto
{
    public class CategoriaEditarDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
