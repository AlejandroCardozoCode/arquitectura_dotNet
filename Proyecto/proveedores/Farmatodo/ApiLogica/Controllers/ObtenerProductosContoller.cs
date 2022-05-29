using Microsoft.AspNetCore.Mvc;
using Api.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/ObtenerProductos")]

public class ObtenerProductosController : ControllerBase
{
    public ObtenerProductosController()
    {
    }
    [HttpGet]
    public List<Farmatodo> Get()
    {
        //obtener los usuarios de la base de datos por medio del api de los datos
        Task<string> productos = obtenerUsuariosDB();
        //convertir el resultado a una lista de productos
        List<Farmatodo> listaProductos = JsonSerializer.Deserialize<List<Farmatodo>>(productos.Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        return listaProductos;

    }

    static async Task<string> obtenerUsuariosDB()
    {
        var url = "https://localhost:7400/ObtenerProductosDB";
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
