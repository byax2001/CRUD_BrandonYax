using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        ProductosDAO productosDAO = new ProductosDAO();
        [HttpGet("producto")]
        public List<Producto> allProductos()
        {
            return productosDAO.allProductos();
        }
    }
}
