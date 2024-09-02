using Reservas_API.Models;

namespace Reservas_API.Repositories.UsuarioService
{
    public class UsuuarioService : IUsuarioService
    {
        public List<Usuario> GetAll()
        {
            return Data.Usuarios;
        }

        public Usuario GetId(int id)
        {
            
            Usuario usuario = Data.Usuarios.FirstOrDefault(u => u.UsuarioId == id);

            if(usuario == null)
            {
                return null;
            }

            return usuario;
        }

        public Usuario Login(Login login)
        {
            Usuario usuario = Data.Usuarios.FirstOrDefault(u => u.Nombre == login.username && u.Password == login.password);
            if(usuario == null)
            {
                return null;
            }

            return usuario;
        }
    }
}
