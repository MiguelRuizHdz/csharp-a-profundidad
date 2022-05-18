using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa el numerador: ");
                int numerador = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el denominador: ");
                int denominador = int.Parse(Console.ReadLine());

                int resultado = numerador / denominador;

                Console.WriteLine("\nResultado: {0} / {1} = {2}", numerador, denominador, resultado);
                
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes ingresar dos enteros.");
                
            }
            catch (DivideByZeroException dz)
            {
                Console.WriteLine("\n" + dz.Message);
                Console.WriteLine("Cero es un denominador inválido");
            }
            catch( Exception e)
            {
                Console.WriteLine("\n" + e.Message);
                Console.WriteLine("Ocurrió un error vuelve a intentar");
            }
            Console.ReadKey();
        }
    }
}
