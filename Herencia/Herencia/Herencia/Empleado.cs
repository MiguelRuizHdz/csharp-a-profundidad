using System;

namespace Herencia
{
    class Empleado : Persona
    {
        public string Puesto { get; set; }
        public decimal Sueldo { get; set; }

        // base se refiere a un método o a un constructor de la clase padre
        // En el proceso de construcción siempre se inicializan primero las propiedades de la superclase, y después las de la subclase
        public Empleado(string nombre, int edad, string puesto, decimal sueldo) : base(nombre, edad)
        {
            Puesto = puesto;
            Sueldo = sueldo;
        }

        // Sobreescribir el metodo Saludar de la clase padre
        public override void Saludar()
        {
            Console.WriteLine("Hola, soy {0} y mi puesto es {1}", Nombre, Puesto);
        }

        public void Trabajar()
        {
            Console.WriteLine("{0} está trabajando... ", Nombre);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} años, {2}, sueldo: ${3}", Nombre, Edad, Puesto, Sueldo);
        }
    }
}
