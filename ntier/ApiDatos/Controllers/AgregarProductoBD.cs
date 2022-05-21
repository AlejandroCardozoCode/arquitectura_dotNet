using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/AgregarProductoDB")]

public class AgregarProductoDB : ControllerBase
{
    private readonly ILogger<Productost1> _logger;
    private readonly arquitecturaContext _context;
    public AgregarProductoDB(ILogger<Productost1> logger)
    {
        _logger = logger;
        _context = new arquitecturaContext();
    }
    [HttpPost]
    public Productost1 Post(Productost1 producto)
    {
        _context.Add(producto);
        _context.SaveChanges();
        return producto;
    }

}
