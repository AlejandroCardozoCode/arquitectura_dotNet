using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/ComprobarInfo")]

public class ComprobarInfo : ControllerBase
{
    private readonly bancoContext _context;
    public ComprobarInfo()
    {
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