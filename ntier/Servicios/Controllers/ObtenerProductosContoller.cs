using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/ObtenerProductos")]

public class ObtenerProductosController : ControllerBase
{
    private readonly ILogger<Productost1> _logger;
    public ObtenerProductosController(ILogger<Productost1> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public List<Productost1> Get()
    {
        //obtener los usuarios de la base de datos por medio del api de los datos
        Task<string> productos = obtenerUsuariosDB();
        //convertir el resultado a una lista de productos
        List<Productost1> listaProductos = JsonSerializer.Deserialize<List<Productost1>>(productos.Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        return listaProductos;

    }

    static async Task<string> obtenerUsuariosDB()
    {
        var url = "https://localhost:7016/ObtenerProductosDB";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = await httpClient.GetAsync(url);
            var respuestastring = await respuesta.Content.ReadAsStringAsync();
            return respuestastring;
        }
    }



}
