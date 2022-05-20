using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operador de asignación
            int x = 5;
            x += 10;
            // Operador +
            int suma1 = 20 + 50;        // 70 (20 + 50)
            int suma2 = suma1 + 100;      // 170 (70 + 100)
            int suma3 = suma2 + suma2;     // 340 (170 + 170)
        }
    }
}
