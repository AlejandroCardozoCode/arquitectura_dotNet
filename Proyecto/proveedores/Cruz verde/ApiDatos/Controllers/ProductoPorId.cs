using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/ProductoPorIdDB")]

public class ProductoPorIdDB : ControllerBase
{
    private readonly proveedoresContext _context;
    public ProductoPorIdDB()
    {
        _context = new proveedoresContext();
    }
    [HttpGet]
    public CruzVerde Get([FromHeader] int id)
    {
        List<CruzVerde> listaProductos = _context.CruzVerdes.ToList();
        foreach (CruzVerde producto in listaProductos)
        {
            if (producto.IdCatalogo == id)
            {
                return producto;
            }
        }
        return null;
    }

}
