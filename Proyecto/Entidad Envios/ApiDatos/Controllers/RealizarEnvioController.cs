using Microsoft.AspNetCore.Mvc;
using Api.Models;
namespace Api.Controllers;

[ApiController]
[Route("/RealizarEnvio")]

public class RealizarEnvio : ControllerBase
{
    private readonly envioContext _context;
    public RealizarEnvio()

    {
        _context = new envioContext();
    }
    [HttpGet]
    public int Get([FromHeader] string dirOrigen, [FromHeader] string dirDestino)
    {
        int precioUber = calcularPrecioUber();
        int precioRappi = calcularPrecioRappi();
        int precioDomicilios = calcularPrecioDomicilios();

        if (precioUber <= precioRappi && precioUber <= precioDomicilios)
        {
            _context.UberRegistros.Add(new UberRegistro
            {
                DirOrigen = dirOrigen,
                DirDestino = dirDestino,
                Costo = precioUber,
            });
            _context.SaveChanges();
            return precioUber;
        }
        if (precioRappi <= precioUber && precioRappi <= precioDomicilios)
        {
            _context.RappiRegistros.Add(new RappiRegistro
            {
                DirOrigen = dirOrigen,
                DirDestino = dirDestino,
                Costo = precioRappi,
            });
            _context.SaveChanges();
            return precioRappi;
        }
        if (precioDomicilios <= precioRappi && precioDomicilios <= precioUber)
        {
            _context.DomiciliosRegistros.Add(new DomiciliosRegistro
            {
                DirOrigen = dirOrigen,
                DirDestino = dirDestino,
                Costo = precioDomicilios,
            });
            _context.SaveChanges();
            return precioDomicilios;

        }
        return 0;
    }

    private int calcularPrecioUber()
    {

        Random random = new Random();
        return random.Next(4500, 12000);
    }
    private int calcularPrecioRappi()
    {

        Random random = new Random();
        return random.Next(4500, 12000);
    }
    private int calcularPrecioDomicilios()
    {

        Random random = new Random();
        return random.Next(4500, 12000);
    }

}