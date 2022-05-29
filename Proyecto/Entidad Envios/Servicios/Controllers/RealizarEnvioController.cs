using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("/RealizarEnvio")]

public class RealizarPago : ControllerBase
{
    public RealizarPago()
    {
    }
    [HttpGet]
    public int Get([FromHeader] string dirOrigen, [FromHeader] string dirDestino)
    {
        Console.WriteLine("llego una solicitus");
        Task<string> solicitarEnvio = solicitarEnvioDatos(dirOrigen, dirDestino);
        int respuesta = JsonSerializer.Deserialize<int>((solicitarEnvio.Result), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        return (respuesta);
    }
    public async Task<string> solicitarEnvioDatos(string dirOrigen, string dirDestino)
    {
        var url = "https://localhost:7310/RealizarEnvio";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            using (var mensaje = new HttpRequestMessage(HttpMethod.Get, url))
            {
                mensaje.Headers.Add("dirOrigen", dirOrigen);
                mensaje.Headers.Add("dirDestino", dirDestino);
                var respuesta = await httpClient.SendAsync(mensaje);
                var contenidoRespuesta = await respuesta.Content.ReadAsStringAsync();
                return (contenidoRespuesta);
            }
        }

    }


}