using Reservas_API.Models;

namespace Reservas_API.Repositories.ReservaService
{
    public class ReservaService : IReservasService
    {


        public List<Reserva> GetAll()
        {
            return Data.Reservas;
        }

        public Reserva Post(Reserva reserva)
        {
            reserva.ReservaId = Data.Reservas.Count + 1;
            Data.Reservas.Add(reserva);

            return reserva;
        }
    }
}
