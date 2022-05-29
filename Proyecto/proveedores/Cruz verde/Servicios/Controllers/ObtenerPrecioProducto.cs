using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/ObtenerPrecioProducto")]

public class ObtenerPrecioProductoController : ControllerBase
{
    public ObtenerPrecioProductoController()
    {
    }
    [HttpGet]
    public int Get([FromHeader] int id)
    {
        Task<string> productoRespuesta = ObtenerProductoPorId(id);
        CruzVerde producto = JsonSerializer.Deserialize<CruzVerde>(productoRespuesta.Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        return producto.ValorProducProv.GetValueOrDefault();
    }
    public async Task<string> ObtenerProductoPorId(int id)
    {
        var url = "https://localhost:7411/ObtenerPrecioProducto";
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
