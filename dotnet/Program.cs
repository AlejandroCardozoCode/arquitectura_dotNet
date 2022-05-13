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
            foreach (var us in usuarios)
            {
                System.Console.WriteLine("Id: " + us.Idusuario + " Nombre: " + us.Nombre);
            }
        }
    }
}