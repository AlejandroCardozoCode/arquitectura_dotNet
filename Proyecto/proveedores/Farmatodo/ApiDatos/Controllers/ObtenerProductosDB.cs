using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/ObtenerProductosDB")]

public class ObtenerProductosDB : ControllerBase
{
    private readonly proveedoresContext _context;
    public ObtenerProductosDB()
    {
        _context = new proveedoresContext();
    }
    [HttpGet]
    public List<Farmatodo> Get()
    {
        return _context.Farmatodos.ToList();
    }

}
