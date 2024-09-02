namespace WebApp_Eduardo_Vera_20240902.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int AlojamientoId { get; set; }
        public List<int> ServiciosAdicionalesIds { get; set; }

        public Reserva(int reservaId, int usuarioId, DateTime fechaReserva, DateTime fechaInicio, DateTime fechaFin, int alojamientoId, List<int> serviciosAdicionalesIds)
        {
            ReservaId = reservaId;
            UsuarioId = usuarioId;
            FechaReserva = fechaReserva;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            AlojamientoId = alojamientoId;
            ServiciosAdicionalesIds = serviciosAdicionalesIds;
        }
    }
}
