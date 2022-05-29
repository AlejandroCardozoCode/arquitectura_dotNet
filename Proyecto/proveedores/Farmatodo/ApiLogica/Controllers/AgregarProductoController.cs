using Microsoft.AspNetCore.Mvc;
using Api.Models;
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
    public async void Post(Farmatodo producto)
    {
        var url = "https://localhost:7400/AgregarProductoDB";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = httpClient.PostAsJsonAsync(url, producto).Result;
        }

    }
}
