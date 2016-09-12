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

namespace Catalogo.Data
{
    public class CategoriaData : ICategoriaData
    {
        ModelCatalogo _context = new ModelCatalogo();

        public List<CategoriaDto> listarCategorias()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Entity.Categoria, CategoriaDto>());
            return _context.Categoria.ProjectTo<CategoriaDto>().ToList();
        }

        public CategoriaRegistroDto CreateCategoria(CategoriaRegistroDto CategoiraRe)
        {
            //Mapper.Initialize(c => c.CreateMap<CategoriaDto, Categoria>());
            var categoriaRegistro = Mapper.Map<CategoriaRegistroDto, Entity.Categoria>(CategoiraRe);
            _context.Categoria.Add(categoriaRegistro);
            _context.SaveChanges();
            return Mapper.Map<Entity.Categoria, CategoriaRegistroDto>(categoriaRegistro);
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
        public bool CategoriaEditar(CategoriaEditarDto objEdita) {
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

        public List<CategoriaDto> Obtener()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Entity.Categoria, CategoriaDto>());
            return _context.Categoria.ProjectTo<CategoriaDto>().ToList();
        }

        public CategoriaDto Obtener(int id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Entity.Categoria, CategoriaDto>());
            return _context.Categoria.Where(c => c.Id == id).ProjectTo<CategoriaDto>().FirstOrDefault();
        }
    }
}
