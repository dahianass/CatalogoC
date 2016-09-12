using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Catalogo.Dto;

namespace Catalogo.Entity.Data
{
    public class ProductoData
    {
        ModelCatalogo _context = new ModelCatalogo();

        public List<ProductoDto> listarProduct()
        {
            var listProductAll = (from p in _context.Producto select new ProductoDto()).ToList();
            return listProductAll;
        }

        public ProductoDto CreateProducto(ProductoCrearDto producto)
        {
            //Mapper.Initialize(c => c.CreateMap<CategoriaDto, Categoria>());
            var productReg = Mapper.Map<ProductoCrearDto, Producto>(producto);
            _context.Producto.Add(productReg);
            _context.SaveChanges();
            return Mapper.Map<Producto, ProductoDto>(productReg);
        }

        public bool eliminarProducto(ProductoDeshactivarDto objProductoDesha)
        {
            var eliminarProducto = _context.Producto.Where(c => c.Id == objProductoDesha.id).FirstOrDefault();
            if (eliminarProducto != null)
            {
                eliminarProducto.Activo = objProductoDesha.Activo;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ProdctoEditar(ProductoEditarDto objEdita)
        {
            var productoEditar = _context.Producto.Where(c => c.Id == objEdita.Id).FirstOrDefault();
            if (productoEditar != null)
            {
                productoEditar.Nombre = objEdita.Nombre;
                productoEditar.Descripcion = objEdita.Descripcion;
                productoEditar.Precio = objEdita.Precio;

                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
