using Microsoft.AspNetCore.Mvc;
using LH_Pets.Models;

namespace LH_Pets.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private static readonly List<Cliente> clientes = new();

        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            return Ok(clientes);
        }

        [HttpPost]
        public ActionResult<Cliente> Post(Cliente cliente)
        {
            clientes.Add(cliente);
            return Ok(cliente);
        }
    }
}