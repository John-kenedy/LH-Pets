using Microsoft.AspNetCore.Mvc;
using LH_Pets.Models;

namespace LH_Pets.Controllers
{
    [ApiController]
    [Route("api/pets")]
    public class PetsController : ControllerBase
    {
        private static readonly List<Pet> pets = new();

        [HttpGet]
        public ActionResult<List<Pet>> Get()
        {
            return Ok(pets);
        }

        [HttpPost]
        public ActionResult<Pet> Post(Pet pet)
        {
            pets.Add(pet);
            return Ok(pet);
        }

        [HttpGet("cliente/{clienteId}")]
        public ActionResult<List<Pet>> GetPorCliente(int clienteId)
        {
            var petsDoCliente = pets
                .Where(p => p.ClienteId == clienteId)
                .ToList();

            return Ok(petsDoCliente);
        }
    }
}