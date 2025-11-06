using Ejercicio1_models.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3_ApiWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {
        Sistema sistema = new Sistema();
        // GET: api/<SistemaController>
        [HttpGet("CamionesCargados")]
        public ActionResult<string[]> GetCamionesCargados()
        {
            string[] camiones = sistema.CamionesCargados();

            if (camiones == null || camiones.Length == 0)
                return NotFound("No hay camiones cargados.");

            return Ok(camiones);
        }

        // GET api/<SistemaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SistemaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SistemaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SistemaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
