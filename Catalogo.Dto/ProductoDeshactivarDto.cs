using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Catalogo.Dto
{
    public class ProductoDeshactivarDto
    {
        [Required]
        [StringLength(100)]
        public int id { get; set; }
        public bool Activo { get; set; }
    }
}
