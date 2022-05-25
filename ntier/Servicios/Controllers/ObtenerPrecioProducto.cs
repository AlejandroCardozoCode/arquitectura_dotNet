using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/ObtenerPrecioProducto")]

public class ObtenerPrecioProductoController : ControllerBase
{
    private readonly ILogger<Productost1> _logger;
    public ObtenerPrecioProductoController(ILogger<Productost1> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public Productost1 Get([FromHeader] int id)
    {
        Task<string> productoRespuesta = ObtenerProductoPorId(id);
        Productost1 producto = JsonSerializer.Deserialize<Productost1>(productoRespuesta.Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        return producto;
    }
    public async Task<string> ObtenerProductoPorId(int id)
    {
        var url = "https://localhost:7016/ProductoPorIdDB";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            using (var mensaje = new HttpRequestMessage(HttpMethod.Get, url))
            {
                mensaje.Headers.Add("id", id.ToString());
                var respuesta = await httpClient.SendAsync(mensaje);
                var contenidoRespuesta = await respuesta.Content.ReadAsStringAsync();
                return contenidoRespuesta;
            }
        }

    }


}
