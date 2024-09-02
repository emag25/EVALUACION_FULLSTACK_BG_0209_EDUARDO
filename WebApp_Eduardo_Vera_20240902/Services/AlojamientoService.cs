using Newtonsoft.Json;
using System.Text;
using WebApp_Eduardo_Vera_20240902.Models;

namespace WebApp_Eduardo_Vera_20240902.Services
{
    public class AlojamientoService : IAlojamientoService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AlojamientoService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }


        public async Task<List<Alojamiento>> getAll()
        {
            var httpClient = _httpClientFactory.CreateClient("ApiClient");

            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "/api/Alojamiento");

            var response = await httpClient.SendAsync(
                request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var alojamientos = JsonConvert.DeserializeObject<List<Alojamiento>>(content);
            return alojamientos;
        }
    }
}
