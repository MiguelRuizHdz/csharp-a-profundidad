using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public Persona() { }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override bool Equals(object obj)
        {
            if ( obj == null)
            {
                return false;
            }

            // intenta castear
            Persona p = obj as Persona;
            if(p == null)
            {
                return false;
            }

            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }
    }
}
