using Reservas_API.Models;

namespace Reservas_API.Repositories.ServiciosAdicionalService
{
    public class ServicioAdicionalService : IServiciosAdicionalService
    {
        public ServicioAdicional Get(int id)
        {
            ServicioAdicional servicioAdicional = Data.ServiciosAdicionales.FirstOrDefault(u => u.ServicioAdicionalId == id);

            if(servicioAdicional == null)
            {
                return null;
            }


            return servicioAdicional;
        }

        public List<ServicioAdicional> GetAll()
        {
            return Data.ServiciosAdicionales;
        }
    }
}
