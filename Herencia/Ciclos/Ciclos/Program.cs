using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ciclo For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            // Ciclo While
            int n = 0; // declaración del contador con su valor inicial
            while (n < 5) // Mientras n sea menor a 5
            {
                Console.WriteLine("Valor del contador n: {0}", n);
                n++; // Incrementar el valor en 1
            }

            // Ciclo Do - While
            int c = 0; // declaración del contador con su valor inicial
            do
            {
                Console.WriteLine("Valor del contador c: {0}", c);
                c++; // Incrementar el valor en 1
            } while (c < 5); // Se ejecuta mientras c sea menor a 5

            // Iteración de arreglo - Ciclo Foreach
            string[] carros = { "Kia", "BMW", "Ford", "Mazda" };
            foreach (string carro in carros)
            {
                Console.WriteLine(carro);
            }

            // Sintaxis de ciclos

            // for (valorInicial; condición; incremento)
            // {
            //     //acciones
            // }

            // while (condición)
            // {
            //     // bloque de código a ejecutar
            // }

            // do
            // {
            //     //acciones
            // } while (condición);

            // foreach (tipoDato nombreVariable in nombreArray)
            // {
            //     // bloque de código a ejecutar
            // }
        }     
    }
}
