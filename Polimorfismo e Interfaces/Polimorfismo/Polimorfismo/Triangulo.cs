using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Triangulo:IFigura 
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return (Base * Altura)/2;
        }

        public void DatosTriangulo()
        {
            Console.WriteLine("Base: {0}, Altura: {1}", Base, Altura);
        }
    }
}
