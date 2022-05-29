using Microsoft.AspNetCore.Mvc;
using Api.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/ComprarProducto")]

public class Comprar : ControllerBase
{
    public Comprar()
    {
    }
    [HttpPost]
    public string Post(Peticion peticion)
    {
        var url = "https://localhost:7400/ComprarProductoDB";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = httpClient.PostAsJsonAsync(url, peticion).Result;
            return respuesta.Content.ReadAsStringAsync().Result;
        }
    }
}
