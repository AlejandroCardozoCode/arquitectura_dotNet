using Microsoft.AspNetCore.Mvc;
using Servicios.Models;
namespace Api.Controllers;

[ApiController]
[Route("/ComprobarInfoServicio")]

public class ComprobarInfo : ControllerBase
{
    private readonly ILogger<Cliente> _logger;
    private readonly bancoContext _context;
    public ComprobarInfo(ILogger<Cliente> logger)
    {
        _logger = logger;
        _context = new bancoContext();
    }
    [HttpPost]
    public Boolean Post(Cliente cliente)
    {
        List<Cliente> listaClientes = _context.Clientes.ToList();
        foreach (Cliente actual in listaClientes)
        {
            if (actual.Cedula == cliente.Cedula && actual.NumTarjeta == cliente.NumTarjeta && actual.FechaExp.Equals(cliente.FechaExp))
            {
                return true;
            }
        }
        return false;
    }

}