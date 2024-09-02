using Newtonsoft.Json;
using System.Text;
using WebApp_Eduardo_Vera_20240902.Models;

namespace WebApp_Eduardo_Vera_20240902.Services
{
    public class UsuariosServices : IUsuarioService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public UsuariosServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }


        public async Task<Usuario> login(Login login)
        {
            var httpClient = _httpClientFactory.CreateClient("ApiClient");

            var movieJson = JsonConvert.SerializeObject(login);
            var content = new StringContent(movieJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("/login", content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var loginResponse = JsonConvert.DeserializeObject<Usuario>(responseContent);

            return loginResponse;
        }


       
    }
}
