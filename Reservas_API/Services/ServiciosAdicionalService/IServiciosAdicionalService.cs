using Reservas_API.Models;

namespace Reservas_API.Repositories.ServiciosAdicionalService
{
    public interface IServiciosAdicionalService
    {
        List<ServicioAdicional> GetAll();
        ServicioAdicional Get(int id);

    }
}
