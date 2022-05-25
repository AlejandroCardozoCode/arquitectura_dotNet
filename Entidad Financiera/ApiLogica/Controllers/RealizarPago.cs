using Microsoft.AspNetCore.Mvc;
using Api.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/RealizarPago")]

public class RealizarPago : ControllerBase
{
    private readonly ILogger<Cliente> _logger;
    public RealizarPago(ILogger<Cliente> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public Boolean Get([FromHeader] int id, [FromHeader] int valor)
    {
        Task<string> productoRespuesta = ValidarPago(id, valor);
        Boolean respuesta = JsonSerializer.Deserialize<Boolean>(productoRespuesta.Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        return respuesta;
    }
    public async Task<string> ValidarPago(int id, int valor)
    {
        var url = "https://localhost:7200/RealizarPago";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            using (var mensaje = new HttpRequestMessage(HttpMethod.Get, url))
            {
                mensaje.Headers.Add("idCliente", id.ToString());
                mensaje.Headers.Add("valorPagar", valor.ToString());
                var respuesta = await httpClient.SendAsync(mensaje);
                var contenidoRespuesta = await respuesta.Content.ReadAsStringAsync();
                return contenidoRespuesta;
            }
        }

    }


}