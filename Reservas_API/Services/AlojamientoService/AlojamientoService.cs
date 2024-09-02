using Reservas_API.Models;

namespace Reservas_API.Repositories.AlojamientoService
{
    public class AlojamientoService : IAlojamientoService
    {
        public Alojamiento Get(int id)
        {

            Alojamiento alojamiento = Data.Alojamientos.FirstOrDefault(u => u.AlojamientoId == id);
            if (alojamiento == null)
            {
                return null;
            }
            return alojamiento;
        }

        public List<Alojamiento> GetAll()
        {
           return Data.Alojamientos;
        }
    }
}
