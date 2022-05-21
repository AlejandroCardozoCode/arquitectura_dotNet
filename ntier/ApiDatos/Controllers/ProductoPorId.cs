using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/ProductoPorIdDB")]

public class ProductoPorIdDB : ControllerBase
{
    private readonly ILogger<Productost1> _logger;
    private readonly arquitecturaContext _context;
    public ProductoPorIdDB(ILogger<Productost1> logger)
    {
        _logger = logger;
        _context = new arquitecturaContext();
    }
    [HttpGet]
    public Productost1 Get([FromHeader] int id)
    {
        List<Productost1> listaProductos = _context.Productost1s.ToList();
        foreach (Productost1 producto in listaProductos)
        {
            if (producto.Idproducto == id)
            {
                return producto;
            }
        }
        return null;
    }

}
