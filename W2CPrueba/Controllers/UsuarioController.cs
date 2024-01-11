using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using W2CPrueba.Clases;

namespace W2CPrueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet(Name = "Get")]
        public IEnumerable<Usuario> Get()
        {
            //Create mock data
            return Enumerable.Range(1, 5).Select(index => new Usuario
            {
                Id = index,
                Nombre = $"Usuario {index}",
                Apellido = $"Apellido {index}"
            }).ToArray();
        }

        // GET api/<TareaController>/5
        [HttpGet("{userId}")]
        public IEnumerable<Usuario> Get(int userId)
        {
            //Create mock data
            return Enumerable.Range(1, 5).Select(index => new Usuario
            {
                Id = index,
                Nombre = $"Usuario {index}",
                Apellido = $"Apellido {index}"
            }).ToArray();
        }

        [HttpPost]
        public void Post([FromBody] string value)
        { 
        }




    }
}
