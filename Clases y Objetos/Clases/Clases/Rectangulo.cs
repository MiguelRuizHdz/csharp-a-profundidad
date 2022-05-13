using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Rectangulo
    {
        // propiedades o atributos
        public int Base { get; set; }
        public int Altura { get; set; }

        // métodos
        public int CalcularArea()
        {
            return Base * Altura;
        }
    }
}
