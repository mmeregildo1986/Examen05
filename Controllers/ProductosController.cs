using Examen05.Models;
using Examen05.Request;
using Examen05.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen05.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private readonly DemoContex _context;

        public ProductosController(DemoContex context)
        {
            _context = context;
        }


        [HttpPost]
        public bool Insertar(ProductoRequest request)
        {
            try
            {
                Productos productos = new Productos
                {
                    Nombre = request.Nombre,
                    Precio = request.Precio,
                    CategoriaId = request.CategoriaId,

                 };


                _context.Productos.Add(productos);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }


        [HttpGet]
        public List<ProductoResponse> ListarProducto()
        {
            var productos = _context.Productos.ToList();
            var response = productos.Select(x => new ProductoResponse
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Precio = x.Precio,

            }
            ).ToList();

            return response;
        }


        [HttpGet]
        public List<ProductoResponse> ListarProductoId(int Id)
        {
            var productos = _context.Productos.Where(x => x.Id == Id).ToList();
            var response = productos.Select(x => new ProductoResponse
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Precio = x.Precio,

            }
            ).ToList();

            return response;
        }
    }
}
