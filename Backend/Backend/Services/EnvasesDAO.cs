using Backend.Context;
using Backend.Models;

namespace Backend.Services
{
    public class EnvasesDAO
    {
        public CilindrosPContext context = new CilindrosPContext();

        // Obtener todos los envases
        public List<Envase> allEnvases()
        {
            var envases = context.Envases.ToList<Envase>();
            return envases;
        }
    }
}
