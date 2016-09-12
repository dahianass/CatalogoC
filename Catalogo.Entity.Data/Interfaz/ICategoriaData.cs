using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dto;

namespace Catalogo.Data
{
    public interface ICategoriaData : IBaseData<CategoriaDto>
    {
        List<CategoriaDto> listarCategorias();
        CategoriaRegistroDto CreateCategoria(CategoriaRegistroDto CategoiraRe);
        bool eliminarCategoria(CategoriaEliminarDto objCategori);
        bool CategoriaEditar(CategoriaEditarDto objEdita);
        }
}
