namespace Reservas_API.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public string Password { get; set; }

        public Usuario(int usuarioId, string nombre, string apellido, string email, string telefono , string password)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Password = password;
        }
    }


    public class Login
    {
       public string username {  get; set; }
       public string password { get; set; }
    }
}
