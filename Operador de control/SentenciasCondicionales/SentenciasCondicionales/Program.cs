using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciasCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sentencia If
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("num es mayor que 5");
            }

            // Condicional Compuesta
            string user = "user1";
            string pass = "hola123";

            if (user == "user1"  && pass == "hola123")
            {
                Console.WriteLine("Acceso correcto");
            }

            // If - Else
            int edad = 13;
            if(edad >= 18)
            {
                Console.WriteLine("Mayor de edad");
            } else
            {
                Console.WriteLine("Menor de edad");
            }

            // If - Else If
            int a = 6;
            int b = 8;
            if (a > b)
            {
                Console.WriteLine("{0} es mayor que {1}", a, b);
            }
            else if(a < b)
            {
                Console.WriteLine("{0} es menor que {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} es igual que {1}", a, b);
            }

            // Switch
            string codigo = "A1";
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("Producto 1");
                    break;
                case "A2":
                    Console.WriteLine("Producto 2");
                    break;
                case "A3":
                    Console.WriteLine("Producto 3");
                    break;
                default:
                    Console.WriteLine("Producto no encontrado");
                    break;
            }

        }
    }
}
