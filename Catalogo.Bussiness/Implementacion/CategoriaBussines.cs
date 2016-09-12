using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dto;
using Strategee.Business;
using Catalogo.Bussiness.Interfaz;
using Catalogo.Data;

namespace Catalogo.Bussiness
{
    public class CategoriaBussines : ICategoriaBussines
    {
        ICategoriaData _CategoriaData;
        
        public BusinessResult<bool> CategoriaEditar(CategoriaEditarDto objEdita)
        {
            try
            {
                var result = _CategoriaData.CategoriaEditar(objEdita);
                return BusinessResult<bool>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<bool>.Issue(false, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<CategoriaRegistroDto> CreateCategoria(CategoriaRegistroDto CategoiraRe)
        {
            try
            {
                var result = _CategoriaData.CreateCategoria(CategoiraRe);
                return BusinessResult<CategoriaRegistroDto>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<CategoriaRegistroDto>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<bool> eliminarCategoria(CategoriaEliminarDto objCategori)
        {
            try
            {
                var result = _CategoriaData.eliminarCategoria(objCategori);
                return BusinessResult<bool>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<bool>.Issue(false, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<List<CategoriaDto>> listarCategorias()
        {
            try
            {
                var result = _CategoriaData.listarCategorias();
                return BusinessResult<List<CategoriaDto>>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<List<CategoriaDto>>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<List<CategoriaDto>> Obtener()
        {
            try
            {
                var result = _CategoriaData.Obtener();
                return BusinessResult<List<CategoriaDto>>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<List<CategoriaDto>>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<CategoriaDto> Obtener(int id)
        {
            try
            {
                var result = _CategoriaData.Obtener(id);
                return BusinessResult<CategoriaDto>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<CategoriaDto>.Issue(null, "Operación incorrecta", ex);
            }
        }
    }
}
