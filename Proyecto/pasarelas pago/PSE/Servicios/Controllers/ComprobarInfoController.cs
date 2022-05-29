using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/ComprobarInfo")]

public class ComprobarInfo : ControllerBase
{
    private readonly ILogger<Cliente> _logger;
    public ComprobarInfo(ILogger<Cliente> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public async Task<Boolean> Post(Cliente cliente)
    {
        var url = "https://localhost:7211/ComprobarInfo";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = httpClient.PostAsJsonAsync(url, cliente).Result;
            bool returnValue = respuesta.Content.ReadFromJsonAsync<bool>().Result;
            return returnValue;
        }

    }


}