using Reservas_API.Models;

namespace Reservas_API.Repositories.AlojamientoService
{
    public interface IAlojamientoService
    {

        List<Alojamiento> GetAll();
        Alojamiento Get(int id);
    }
}
