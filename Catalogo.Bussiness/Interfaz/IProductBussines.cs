using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategee.Business;
using Catalogo.Dto;

namespace Catalogo.Bussiness.Interfaz
{
    public interface IProductBussines
    {
        BusinessResult<List<ProductoDto>> listarProduct();
        BusinessResult<ProductoDto> CreateProducto(ProductoCrearDto producto);
        BusinessResult<bool> eliminarProducto(ProductoDeshactivarDto objProductoDesha);
        BusinessResult<bool> ProdctoEditar(ProductoEditarDto objEdita);

    }
}
