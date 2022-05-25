using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using safsf.Models;
using Newtonsoft.Json.Linq;

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
        for (int i = 0; i < jsonArray.Count(); i++)
        {
            Producto actual = new Producto
            {
                Idproducto = ((int)jsonArray[i]["idproducto"]),
                Nombre = ((string)jsonArray[i]["nombre"]),
                Precio = ((int)jsonArray[i]["precio"]),
                Unidades = ((int)jsonArray[i]["precio"]),
                Presentacion = ((string)jsonArray[i]["presentacion"]),
            };
            this.productos.Add(actual);
        }
    }

    private async Task<string> llamarServicioUsuarios()
    {
        var url = "https://localhost:7006/ObtenerProductos";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {
            var respuesta = await httpClient.GetAsync(url);
            var respuestastring = await respuesta.Content.ReadAsStringAsync();
            return respuestastring;
        }
    }
    public IActionResult Index()
    {
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
                if (actual.Idproducto.ToString().Contains(codigo))
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
