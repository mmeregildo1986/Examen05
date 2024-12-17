using Examen05.Models;
using Examen05.Request;
using Examen05.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen05.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DemoContex _context;
        public CategoriaController(DemoContex contex)
        {
            _context = contex;
            
        }

        [HttpPost]
        public bool Insertar(CategoriaRequest request)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    
                };


                _context.Categorias.Add(categoria);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        [HttpGet]
        public List<CategoriaResponse> ListarCategoria()
        {
            var categoria = _context.Categorias.ToList();
            var response = categoria.Select(x => new CategoriaResponse
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                
            }
            ).ToList();

            return response;
        }

        [HttpGet]
        public List<CategoriaResponse> ListarCategoriaId( int Id)
        {
            var categoria = _context.Categorias.Where(x=>x.Id==Id).ToList();
            var response = categoria.Select(x => new CategoriaResponse
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,

            }
            ).ToList();

            return response;
        }





    }
}
