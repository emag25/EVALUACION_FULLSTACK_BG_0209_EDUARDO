using Microsoft.AspNetCore.Mvc;
using Reservas_API.Repositories.AlojamientoService;


namespace Reservas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlojamientoController : ControllerBase
    {
        private readonly IAlojamientoService _service;


        public AlojamientoController(IAlojamientoService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

      
    }
}
