﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategee.Business;
using Catalogo.Dto;


namespace Catalogo.Bussiness.Interfaz
{
    public interface ICategoriaProductoBussines
    {
        BusinessResult<List<ProductoCategoriaDto>> listarProductCategoria();
        BusinessResult<ProductoCategoriaDto> CreateProductoCategoria(ProductoCategoriaDto productoCategoria);
        BusinessResult<bool> eliminarProducto(ProductoDeshactivarDto objProductoDesha);
        BusinessResult<bool> ProdctoEditar(ProductoEditarDto objEdita);
    }
}
