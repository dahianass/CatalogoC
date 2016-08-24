using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Catalogo.Dto
{
    public class ProductoDeshactivar
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
