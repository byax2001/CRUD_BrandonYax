using Backend.Context;
using Backend.Models;

namespace Backend.Services
{
    public class ProductosDAO
    {
        public CilindrosPContext context = new CilindrosPContext();

        public List<Producto> allProductos()
        {
            var productos = context.Productos.ToList<Producto>();
            return productos;
        }
    }
}
