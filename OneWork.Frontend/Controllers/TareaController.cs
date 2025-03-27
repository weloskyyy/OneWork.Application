using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

public class DatoUsuarioController : Controller
{
    private readonly HttpClient _httpClient;

    public DatoUsuarioController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("ApiClient");
    }

    // GET: /DatosUsuario/Index
    public async Task<IActionResult> Index()
    {
        var response = await _httpClient.GetAsync("api/DatoUsuario");

        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            var datosUsuariosResponse = JsonConvert.DeserializeObject<ApiResponse<List<DatoUsuarioDto>>>(result);

            var datos = datosUsuariosResponse?.Data;
            return View(datos);
        }
        else
        {
            return View("Error");
        }
    }
}
