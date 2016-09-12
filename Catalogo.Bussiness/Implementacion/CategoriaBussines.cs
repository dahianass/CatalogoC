using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dto;
using Strategee.Business;
using Catalogo.Bussiness.Interfaz;

namespace Catalogo.Bussiness
{
    public class CategoriaBussines : ICategoriaBussines
    {
        public BusinessResult<bool> CategoriaEditar (CatalogoEditarDto objEdita)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<CategoriaRegistroDto> CreateCategoria(CategoriaRegistroDto CategoiraRe)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> eliminarCategoria(CategoriaEliminarDto objCategori)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<CategoriaDto>> listarCategorias()
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<CategoriaDto>> Obtener()
        {
            throw new NotImplementedException();
        }

        public BusinessResult<CategoriaDto> Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
