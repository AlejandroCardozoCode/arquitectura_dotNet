using Microsoft.AspNetCore.Mvc;
using Api.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/AgregarProducto")]

public class AgregarProductosController : ControllerBase
{
    private readonly ILogger<Productost1> _logger;
    public AgregarProductosController(ILogger<Productost1> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public async void Post()
    {
        var url = "https://localhost:7016/AgregarProductoDB";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {

            Productost1 productoNuevo = new Productost1
            {
                Idproducto = 123131,
                Nombre = "test",
                Precio = 3000,
                Presentacion = "melo",
                Unidades = 69,
            };
            var respuesta = httpClient.PostAsJsonAsync(url, productoNuevo).Result;
            Console.WriteLine(respuesta.Content.ReadAsStreamAsync().Result);
        }

    }

}
