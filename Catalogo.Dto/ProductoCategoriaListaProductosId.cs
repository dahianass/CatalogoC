using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Catalogo.Dto
{ 
    public class ProductoCategoriaProductoId
    {
        [Key]
        public long IdProductoCategoria { get; set; }

        public long IdProducto { get; set; }

        public string Nombre { get; set; }

        public int IdCategoria { get; set; }

        public string Descripcion { get; set; }
    }
}
