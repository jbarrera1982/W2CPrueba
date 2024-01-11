using Microsoft.AspNetCore.Mvc;
using W2CPrueba.Clases;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace W2CPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
  
        // GET api/<TareaController>/5
        [HttpGet("{userId}")]
        public IEnumerable<Tarea> Get(int userId)
        {
            //Create mock data
            return Enumerable.Range(1, new Random().Next(8)).Select(index => new Tarea
            {
                Id = index,
                IdUsuario = new Usuario() {Id = userId} ,
                Titulo = $"Titulo {index}",
                Descripcion = $"Descripcion de la tarea {index}"

            }).ToArray();
        }

        // POST api/<TareaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TareaController>/5
        [HttpPut("{IdTarea}")]
        public void Put(int IdTarea, [FromBody] string value)
        {
        }

        // DELETE api/<TareaController>/5
        [HttpDelete("{IdTarea}")]
        public void Delete(int IdTarea)
        {
        }
    }
}
