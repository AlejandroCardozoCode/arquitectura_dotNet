using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/ObtenerProductosDB")]

public class ObtenerProductosDB : ControllerBase
{
    private readonly ILogger<Productost1> _logger;
    private readonly arquitecturaContext _context;
    public ObtenerProductosDB(ILogger<Productost1> logger)
    {
        _logger = logger;
        _context = new arquitecturaContext();
    }
    [HttpGet]
    public List<Productost1> Get()
    {
        return _context.Productost1s.ToList();
    }

}
