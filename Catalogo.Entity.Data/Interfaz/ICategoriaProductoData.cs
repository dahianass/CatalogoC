﻿using Catalogo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dto;

namespace Catalogo.Entity.Data.Interfaz
{
    public interface ICategoriaProductoData : IBaseData<ProductoCategoriaDto>
    {
        List<ProductoCategoriaDto> listarProductCategoria();
        ProductoDto CreateProducto(ProductoCrearDto producto);
        bool eliminarProducto(ProductoDeshactivarDto objProductoDesha);
        bool ProdctoEditar(ProductoEditarDto objEdita);
    }
}
