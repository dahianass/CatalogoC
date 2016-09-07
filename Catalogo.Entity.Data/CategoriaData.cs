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

        public CategoriaRegistroDto CreateCategoria(CategoriaRegistroDto CategoiraRe)
        {
            //Mapper.Initialize(c => c.CreateMap<CategoriaDto, Categoria>());
            var categoriaRegistro = Mapper.Map<CategoriaRegistroDto, Categoria>(CategoiraRe);
            _context.Categoria.Add(categoriaRegistro);
            _context.SaveChanges();
            return Mapper.Map<Categoria, CategoriaRegistroDto>(categoriaRegistro);
        }

        public bool eliminarCategoria(CategoriaEliminarDto objCategori)
        {
            var categoriElimianar = _context.Categoria.Where(c => c.Id == objCategori.Id).FirstOrDefault(); 
            if (categoriElimianar != null)
            {
                categoriElimianar.Estado = objCategori.Estado;
                _context.SaveChanges();
                return true;
            } else {
                return false;
            }
        }
        public bool CategoriaEditar(CatalogoEditarDto objEdita) {
            var categoriaEditar = _context.Categoria.Where(c => c.Id == objEdita.Id).FirstOrDefault();
            if (categoriaEditar != null)
            {
                categoriaEditar.Descripcion = objEdita.Descripcion;
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
