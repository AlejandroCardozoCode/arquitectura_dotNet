using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/RealizarPago")]

public class ComprobarPagoController : ControllerBase
{
    private readonly ILogger<Cliente> _logger;
    private readonly bancoContext _context;
    public ComprobarPagoController(ILogger<Cliente> logger)
    {
        _logger = logger;
        _context = new bancoContext();
    }
    [HttpGet]
    public Boolean Get([FromHeader] int idCliente, [FromHeader] int valorPagar)
    {
        List<Cliente> listaClientes = _context.Clientes.ToList();
        foreach (Cliente actual in listaClientes)
        {
            if (actual.Cedula == idCliente)
            {
                int valorCuenta = actual.Dinero.Value;
                if (valorCuenta >= valorPagar)
                {
                    actual.Dinero = valorCuenta - valorPagar;
                    _context.SaveChanges();
                    return true;
                }
            }
        }
        return false;
    }
}