using Microsoft.AspNetCore.Mvc;
using Api.Models;
using System.Text.Json;

[ApiController]
[Route("/ComprarProductoDB")]

public class ComprarProductoDB : ControllerBase
{
    private readonly proveedoresContext _context;
    public ComprarProductoDB()
    {
        _context = new proveedoresContext();
    }
    [HttpPost]
    public string Post(Peticion peticion)
    {
        List<Farmatodo> listaProductos = _context.Farmatodos.ToList();
        foreach (Farmatodo producto in listaProductos)
        {
            if (producto.IdCatalogo == peticion.id)
            {
                if (producto.Disponibilidad >= peticion.cantidad)
                {
                    producto.Disponibilidad = producto.Disponibilidad - peticion.cantidad;
                    _context.SaveChanges();
                    return "";
                }
                else if (producto.Disponibilidad < peticion.cantidad)
                {
                    return "Cantidad de compra incorrecta";
                }
            }
        }
        return "Producto no encontrado";

    }

}
