using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Rectangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public void DatosRectangulo()
        {
            Console.WriteLine("Base: {0}, Altura: {1}", Base, Altura);
        }
    }
}
