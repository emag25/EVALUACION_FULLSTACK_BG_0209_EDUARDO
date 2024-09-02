namespace Reservas_API.Models
{
    public class ServicioAdicional
    {
        public int ServicioAdicionalId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public ServicioAdicional(int servicioAdicionalId, string nombre, string descripcion, decimal precio)
        {
            ServicioAdicionalId = servicioAdicionalId;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
