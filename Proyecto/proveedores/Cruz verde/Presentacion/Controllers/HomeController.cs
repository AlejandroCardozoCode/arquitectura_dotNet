using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using safsf.Models;
using Newtonsoft.Json.Linq;
using System.Text.Json;
namespace safsf.Controllers;

public class HomeController : Controller
{
    List<Producto> productos = new List<Producto>();
    List<Producto> productosBusqueda = new List<Producto>();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    private void transformardatos()
    {
        Task<string> productos = llamarServicioUsuarios();
        //convertir el resultado a un array json
        JArray jsonArray = JArray.Parse(productos.Result);
        //Console.WriteLine(jsonArray.Count());
        //crear la lista de retorno
        if (this.productos.Count() > 0)
        {
            this.productos.Clear();
        }
        this.productos = JsonSerializer.Deserialize<List<Producto>>(productos.Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

    }

    private async Task<string> llamarServicioUsuarios()
    {
        var url = "https://localhost:7411/ObtenerProductos";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = await httpClient.GetAsync(url);
            var respuestastring = await respuesta.Content.ReadAsStringAsync();
            return respuestastring;
        }
    }
    private async void llamarServicioAgregarProducto(string id, string nombre, string precio, string cantidad, string presentacion, string contra)
    {
        var url = "https://localhost:7411/AgregarProducto";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {

            Producto productoNuevo = new Producto
            {
                IdCatalogo = int.Parse(id),
                Nombre = nombre,
                ValorProducProv = int.Parse(precio),
                Descripcion = presentacion,
                Disponibilidad = int.Parse(cantidad),
                Contraindicaciones = (contra),
            };
            var respuesta = httpClient.PostAsJsonAsync(url, productoNuevo).Result;
            Console.WriteLine(respuesta.Content.ReadAsStreamAsync().Result);
        }

    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult AgregarProducto(string id, string nombre, string precio, string cantidad, string presentacion, string contra)
    {
        if (id != null && nombre != null && precio != null && cantidad != null && presentacion != null)
        {
            llamarServicioAgregarProducto(id, nombre, precio, cantidad, presentacion, contra);
        }
        return View();
    }

    public IActionResult Productos()
    {
        transformardatos();
        return View(this.productos);
    }
    public IActionResult BuscarCodigo(string codigo)
    {
        transformardatos();
        if (codigo != null)
        {

            foreach (var actual in this.productos)
            {
                if (actual.IdCatalogo.ToString().Contains(codigo))
                {
                    this.productosBusqueda.Add(actual);
                }
            }
        }
        return View(this.productosBusqueda);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
