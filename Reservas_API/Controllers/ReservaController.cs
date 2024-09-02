using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas_API.Models;
using Reservas_API.Repositories.ReservaService;

namespace Reservas_API.Controllers
{

    [Controller]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly IReservasService _service;

        public ReservaController(IReservasService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reserva reserva)
        {
            if (reserva == null)
            {
                return BadRequest();
            }

            return Ok(_service.Post(reserva));

        }
    }
}
