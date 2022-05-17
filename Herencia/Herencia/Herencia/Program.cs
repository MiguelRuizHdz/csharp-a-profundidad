using System;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instancia de clase persona
            Persona p = new Persona("Carlos", 38);
            p.Saludar();

            // instancia de clase empleado
            Empleado e = new Empleado("John", 29, "Ventas", 10000);
            e.Saludar();
            e.Trabajar();

            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
