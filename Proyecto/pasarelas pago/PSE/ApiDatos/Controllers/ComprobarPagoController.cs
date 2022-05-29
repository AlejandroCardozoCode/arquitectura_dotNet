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
    public Boolean Get([FromHeader] int idCliente, [FromHeader] long valorPagar)
    {
        List<Cliente> listaClientes = _context.Clientes.ToList();
        foreach (Cliente actual in listaClientes)
        {

            if (actual.Cedula == idCliente)
            {
                if (actual.Dinero >= valorPagar)
                {
                    actual.Dinero = actual.Dinero - (int)valorPagar;
                    _context.SaveChanges();
                    RegistroPse registro = new RegistroPse
                    {
                        Cedula = idCliente,
                        Valor = (int)valorPagar
                    };
                    _context.RegistroPses.Add(registro);
                    _context.SaveChanges();
                    return true;
                }
            }
        }
        return false;
    }
}