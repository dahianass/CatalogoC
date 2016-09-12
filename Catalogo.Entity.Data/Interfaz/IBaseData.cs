using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Dto;

namespace Catalogo.Data
{
    //GENERICOS <T>
    public interface IBaseData<T>
    {
        /*
         * Obtener todos
         * Obtener uno por id 
         * 
         * Crear
         * Editar 
         * Eliminar
         */
        List<T> Obtener();

        T Obtener(int id);

        //T crear(T entidadDto);

        //bool Editar(T entidadDto);

        //bool CategoriaEditar(T entidadDto);



    }
}
