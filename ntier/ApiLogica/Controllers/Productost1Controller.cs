using Microsoft.AspNetCore.Mvc;
using Api.Models;
using System.Text.Json;
namespace Api.Controllers;
using Newtonsoft.Json.Linq;

[ApiController]
[Route("[controller]")]

public class Productost1Controller : ControllerBase
{
    private readonly ILogger<Productost1> _logger;
    public Productost1Controller(ILogger<Productost1> logger)
    {
        _logger = logger;
    }
    [HttpGet(Name = "GetProductot1")]
    public List<Productost1> Get()
    {
        /*
        using (var context = arquitecturaContext)
        {
            context.Usuario.Add(new Usuario { Idusuario = 3, Nombre = "estiben", Contra = "123123" });
            context.SaveChanges();
        }
        */
        /*

        Usuario[] listaUsuarios = new Usuario[usuarios.Length];
        foreach (var us in usuarios)
        {
            listaUsuarios.Add(us);
        }
        return listaUsuarios;
        */
        /*
         JArray jsonArray = JArray.Parse(productos.Result);
         //Console.WriteLine(jsonArray.Count());
         //crear la lista de retorno
         List<Productost1> listaProductos = new List<Productost1>();
         for (int i = 0; i < jsonArray.Count(); i++)
         {
             Productost1 actual = new Productost1
             {
                 Idproducto = ((int)jsonArray[i]["idproducto"]),
                 Nombre = ((string)jsonArray[i]["nombre"]),
                 Precio = ((int)jsonArray[i]["precio"]),
                 Unidades = ((int)jsonArray[i]["precio"]),
                 Presentacion = ((string)jsonArray[i]["presentacion"]),
             };
             listaProductos.Add(actual);
         }
         */
        //retornar el valor
        //obtener los usuarios de la base de datos por medio del api de los datos
        Task<string> productos = obtenerUsuariosDB();
        //convertir el resultado a una lista de productos
        List<Productost1> listaProductos = JsonSerializer.Deserialize<List<Productost1>>(productos.Result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        return listaProductos;

    }
    [HttpPost]
    public async void Post()
    {
        var url = "https://localhost:7016/Productot1";
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using (var httpClient = new HttpClient(clientHandler))
        {

            Productost1 productoNuevo = new Productost1
            {
                Idproducto = 123131,
                Nombre = "test",
                Precio = 3000,
                Presentacion = "melo",
                Unidades = 69,
            };
            var respuesta = await httpClient.PostAsJsonAsync(url, productoNuevo);
            Console.WriteLine(respuesta.Content.ReadAsStreamAsync());
        }

    }
    static async Task<string> obtenerUsuariosDB()
    {
        var url = "https://localhost:7016/Productot1";
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
