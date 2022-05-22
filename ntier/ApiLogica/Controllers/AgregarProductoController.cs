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
    public async void Post(Productost1 producto)
    {
        var url = "https://localhost:7016/AgregarProductoDB";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = httpClient.PostAsJsonAsync(url, producto).Result;
        }

    }
}
