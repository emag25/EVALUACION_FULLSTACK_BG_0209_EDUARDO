using Reservas_API.Models;

namespace Reservas_API.Repositories.ReservaService
{
    public interface IReservasService
    {

        List<Reserva> GetAll();

        Reserva Post(Reserva reserva);


    }
}
