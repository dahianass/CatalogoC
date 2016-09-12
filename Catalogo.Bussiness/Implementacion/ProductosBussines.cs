using Catalogo.Bussiness.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dto;
using Strategee.Business;

namespace Catalogo.Bussiness
{
    public class ProductosBussines : IProductBussines
    {
        public BusinessResult<ProductoDto> CreateProducto(ProductoCrearDto producto)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> eliminarProducto(ProductoDeshactivarDto objProductoDesha)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<ProductoDto>> listarProduct()
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> ProdctoEditar(ProductoEditarDto objEdita)
        {
            throw new NotImplementedException();
        }
    }
}
