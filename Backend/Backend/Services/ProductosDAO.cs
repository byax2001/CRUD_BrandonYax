using Backend.Context;
using Backend.Models;

namespace Backend.Services
{
    public class ProductosDAO
    {
        public CilindrosPContext context = new CilindrosPContext();

        public List<Producto> allProducts()
        {
            var productos = context.Productos.ToList<Producto>();
            return productos;
        }
    }
}
