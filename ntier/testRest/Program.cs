using System.Net.Http;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        var url = "https://localhost:7006/Usuario";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = await httpClient.GetAsync(url);
            var respuestastring = await respuesta.Content.ReadAsStringAsync();
            Console.WriteLine(respuestastring);

        }
    }
}