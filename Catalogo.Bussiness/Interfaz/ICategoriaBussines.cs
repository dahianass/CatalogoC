using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategee.Business;
using Catalogo.Dto;

namespace Catalogo.Bussiness.Interfaz
{
    public interface ICategoriaBussines
    {
        BusinessResult<bool> CategoriaEditar(CatalogoEditarDto objEdita);
        BusinessResult<CategoriaRegistroDto> CreateCategoria(CategoriaRegistroDto CategoiraRe);
        BusinessResult<bool> eliminarCategoria(CategoriaEliminarDto objCategori);
        BusinessResult<List<CategoriaDto>> listarCategorias();
        BusinessResult<List<CategoriaDto>> Obtener();       
    }
}
