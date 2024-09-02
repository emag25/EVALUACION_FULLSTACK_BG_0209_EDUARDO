using Reservas_API.Models;

namespace Reservas_API
{
    public class Data
    {

        public static List<Usuario> Usuarios = new List<Usuario>
    {
        new Usuario(1, "Juan", "Pérez", "juan.perez@example.com", "123456789", "admin123"),
        new Usuario(2, "Ana", "García", "ana.garcia@example.com", "987654321", "admin123")
    };

        public static List<Alojamiento> Alojamientos = new List<Alojamiento>
    {
        new Alojamiento(1, "Habitación estándar", "Habitación cómoda para dos personas", 100m, 2),
        new Alojamiento(2, "Suite", "Suite de lujo con vista al mar", 250m, 4),
        new Alojamiento(3, "Villa", "Villa privada con piscina", 500m, 6)
    };

        public static List<ServicioAdicional> ServiciosAdicionales = new List<ServicioAdicional>
    {
        new ServicioAdicional(1, "Transporte", "Servicio de transporte desde el aeropuerto", 50m),
        new ServicioAdicional(2, "Paquete de comidas", "Todas las comidas incluidas", 100m),
        new ServicioAdicional(3, "Tour guiado", "Tour guiado por la ciudad", 75m)
    };

        public static List<Reserva> Reservas = new List<Reserva>
    {
        new Reserva(1, 1, DateTime.Now, DateTime.Now.AddDays(5), DateTime.Now.AddDays(10), 2, new List<int> { 1, 2 })
    };
    }


}
