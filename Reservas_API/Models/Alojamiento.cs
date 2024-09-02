namespace Reservas_API.Models
{
    public class Alojamiento
    {
        public int AlojamientoId { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public int Capacidad { get; set; }

        public Alojamiento(int alojamientoId, string tipo, string descripcion, decimal precioPorNoche, int capacidad)
        {
            AlojamientoId = alojamientoId;
            Tipo = tipo;
            Descripcion = descripcion;
            PrecioPorNoche = precioPorNoche;
            Capacidad = capacidad;
        }
    }
}
