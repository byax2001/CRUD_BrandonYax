using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class EnvaseController : ControllerBase
    {
        EnvasesDAO envasesDAO = new EnvasesDAO();

        [HttpGet("envase")]
        public List<Envase> allEnvases()
        {
            return envasesDAO.allEnvases();
        }
    }
}
