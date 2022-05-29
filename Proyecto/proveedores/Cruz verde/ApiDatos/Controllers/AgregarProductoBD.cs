using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/AgregarProductoDB")]

public class AgregarProductoDB : ControllerBase
{
    private readonly proveedoresContext _context;
    public AgregarProductoDB()
    {
        _context = new proveedoresContext();
    }
    [HttpPost]
    public CruzVerde Post(CruzVerde producto)
    {
        _context.Add(producto);
        _context.SaveChanges();
        return producto;
    }

}
