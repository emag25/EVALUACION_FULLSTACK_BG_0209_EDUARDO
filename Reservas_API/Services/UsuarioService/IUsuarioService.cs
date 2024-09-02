using Microsoft.AspNetCore.Identity;
using Reservas_API.Models;

namespace Reservas_API.Repositories.UsuarioService
{
    public interface IUsuarioService
    {

        List<Usuario> GetAll();

        Usuario GetId(int id);

        Usuario Login(Login login);



    }
}
