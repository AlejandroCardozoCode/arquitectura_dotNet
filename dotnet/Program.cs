using System;
using dotnet.Models;
using System.Linq;

namespace dotnet
{
    static class Program
    {
        static void Main()
        {
            var db = new arquitecturaContext();
            var usuarios = db.Usuarios.ToList();
            Console.WriteLine("Usuarios del sistema");
            foreach (var us in usuarios)
            {
                System.Console.WriteLine("Id: " + us.Idusuario + " Nombre: " + us.Nombre);
            }
            var productos = db.Productos.ToList();
            Console.WriteLine("Productos del sistema");
            foreach (var pro in productos)
            {
                System.Console.WriteLine("Id: " + pro.Idproducto + " Nombre: " + pro.Nombre);
            }

        }
    }
}