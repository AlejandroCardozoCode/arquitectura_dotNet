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
    public Farmatodo Get([FromHeader] int id)
    {
        List<Farmatodo> listaProductos = _context.Farmatodos.ToList();
        foreach (Farmatodo producto in listaProductos)
        {
            if (producto.IdCatalogo == id)
            {
                return producto;
            }
        }
        return null;
    }

}
