using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/AgregarProducto")]

public class AgregarProductosController : ControllerBase
{
    public AgregarProductosController()
    {
    }
    [HttpPost]
    public void Post(Farmatodo producto)
    {
        var url = "https://localhost:7410/AgregarProducto";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = httpClient.PostAsJsonAsync(url, producto).Result;
        }

    }
}
