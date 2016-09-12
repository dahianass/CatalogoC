using Catalogo.Bussiness.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategee.Business;
using Catalogo.Dto;

namespace Catalogo.Bussiness
{
    public class CategoriaProductoBussines : ICategoriaProductoBussines
    {
        public BusinessResult<ProductoDto> CreateProducto(ProductoCrearDto producto)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> eliminarProducto(ProductoDeshactivarDto objProductoDesha)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<ProductoCategoriaDto>> listarProductCategoria()
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> ProdctoEditar(ProductoEditarDto objEdita)
        {
            throw new NotImplementedException();
        }
    }
}
