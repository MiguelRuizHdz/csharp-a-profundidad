using System;

namespace Herencia
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public Persona() { }
        public Persona(string nombre, int edad) {
            Nombre = nombre;
            Edad = edad;
        }

        // virtual indica que puede ser modificado por una subclase
        public virtual void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0}", Nombre);
        }

        // virtual se escribe en la superclase
        // override se escribe en la subclase
        public override string ToString()
        {
            return string.Format("{0}, {1} años", Nombre, Edad);
        }

        
    }
}
