using System.Net.Http;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Task<string> valor = calli();
        Console.WriteLine(valor.Result);
    }
    static async Task<string> calli()
    {
        var url = "https://localhost:7006/Usuario";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = await httpClient.GetAsync(url);
            var respuestastring = await respuesta.Content.ReadAsStringAsync();
            return respuestastring;
        }
    }
}