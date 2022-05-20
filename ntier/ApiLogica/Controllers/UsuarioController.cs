using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("[controller]")]

public class UsuarioController : ControllerBase
{
    private readonly ILogger<Usuario> _logger;
    public UsuarioController(ILogger<Usuario> logger)
    {
        _logger = logger;
    }
    [HttpGet(Name = "GetUsuario")]
    public List<Usuario> Get()
    {
        var db = new arquitecturaContext();
        /*
        using (var context = arquitecturaContext)
        {
            context.Usuario.Add(new Usuario { Idusuario = 3, Nombre = "estiben", Contra = "123123" });
            context.SaveChanges();
        }
        */
        return db.Usuarios.ToList();
        /*

        Usuario[] listaUsuarios = new Usuario[usuarios.Length];
        foreach (var us in usuarios)
        {
            listaUsuarios.Add(us);
        }
        return listaUsuarios;
        */

    }

}
