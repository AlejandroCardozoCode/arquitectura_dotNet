using Microsoft.AspNetCore.Mvc;
using Api.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/ComprobarInfo")]

public class ComprobarInfo : ControllerBase
{
    public ComprobarInfo()
    {
    }
    [HttpPost]
    public async Task<Boolean> Post(Cliente cliente)
    {
        var url = "https://localhost:7200/ComprobarInfo";
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