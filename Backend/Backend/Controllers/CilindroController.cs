using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class CilindroController : ControllerBase
    {
        CilindrosDAO cilindrosDAO = new CilindrosDAO();

        [HttpGet("cilindro")]
        public List<CilindroResp> allCilindros() {
            return cilindrosDAO.allCilindros();
        }

        [HttpPost("cilindro")]
        public Boolean insertCilindro([FromBody] Cilindro cilindro)
        {
            return cilindrosDAO.insertCilindro(cilindro.Serie, cilindro.Idenvase, cilindro.Idproducto, cilindro.Capacidad);
        }

        [HttpPut("cilindro/{idCilindro}")]
        public Boolean editCilindro([FromBody] Cilindro cilindro, int idCilindro)
        {
            return cilindrosDAO.editCilindro(cilindro, idCilindro);
        }

        [HttpDelete("cilindro/{idCilindro}")]
        public Boolean deleteCilindro(int idCilindro)
        {
            return cilindrosDAO.deleteCilindro(idCilindro);
        }
    }




}
