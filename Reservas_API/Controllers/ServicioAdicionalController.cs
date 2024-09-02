using Microsoft.AspNetCore.Mvc;
using Reservas_API.Repositories.ServiciosAdicionalService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reservas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioAdicionalController : ControllerBase
    {
        private readonly IServiciosAdicionalService _service;

        public ServicioAdicionalController(IServiciosAdicionalService service)
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
