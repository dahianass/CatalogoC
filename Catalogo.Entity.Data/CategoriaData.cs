using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using System.Data.Entity;
using System.Linq.Expressions;
using Catalogo.Entity;
using Catalogo.Dto;

namespace Catalogo.Entity.Data
{
    public class CategoriaData
    {
        ModelCatalogo _context = new ModelCatalogo();
        public async Task<List<CategoriaDto>> listarCategorias()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Categoria, CategoriaDto>());
            return await _context.Categoria.ProjectTo<CategoriaDto>().ToListAsync();
        }

        public bool Editar 
            {

            }


    }
}
