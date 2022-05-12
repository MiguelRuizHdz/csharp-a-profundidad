using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte datoSbyte = -127;
            short datoShort = 32767;
            int numero = 30;
            long mayor = 999999999;
            // permite solo positivos
            byte positivo = 7;

            // Podemos es opcional agregar el caracter D al final
            double precio = 63.0D;
            // necesita el caracter F de float, antes conocido como Single
            float total = 247.63F;
            // necesita el literal M
            decimal monto = 3749.6M;

            char letra = 'A';

            string nombre = "Miguel";

            Console.WriteLine(monto);
            Console.WriteLine("Tipos de Datos: " + total.GetType());
            Console.ReadKey();
        }
    }
}
