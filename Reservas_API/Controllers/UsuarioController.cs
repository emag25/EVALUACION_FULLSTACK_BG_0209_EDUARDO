using Microsoft.AspNetCore.Mvc;
using Reservas_API.Models;
using Reservas_API.Repositories.UsuarioService;

namespace Reservas_API.Controllers
{

    [Controller]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _service;


        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetId(id));
        }

        [HttpPost("/login")]
        public IActionResult login([FromBody] Login login) {
            
            if(login == null)
            {
                return BadRequest();
            }

            return Ok(_service.Login(login));
        }




    }
}
