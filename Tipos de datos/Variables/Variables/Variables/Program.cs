using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            // Operación multiplicación
            int resultado = numero * 5;
            // Imprimimos el resultado en consola
            Console.WriteLine(resultado);
            bool vivo = true;
            byte miByte = 255;
            sbyte miSByte = 127;
            char caracter = 'C';
            long numeroLargo = 90192910290219;
            float precio = 9.99F;
            double total = 5.99;
            decimal total2 = 9.99M;
            int suma = 8 + 20;
            string cadena = "Este es un texto";

            //cadenas
            string saludo = "Hola";
            Console.WriteLine(saludo.IndexOf("a"));
            // 3
            Console.WriteLine(saludo[0]); 
            // H
            Console.WriteLine("La longitud de saludo en caracteres es de: {0}", saludo.Length);
            // 4
            string nombre = "José";
            Console.WriteLine("{0}, mi nombre es {1}", saludo, nombre);
            // Hola, mi nombre es José

            Console.WriteLine(saludo.ToUpper());   // HOLA
            Console.WriteLine(saludo.ToLower());   // hola
                                       // Espera a que presionemos una tecla. Se cerrará automaticamente sino agregamos la siguiente línea

            string apellido = "Rivera";
            string nombreCompleto = $"Mi nombre completo es {nombre} {apellido}";
                        // Mi nombre completo es José Rivera


            string texto = "La siguiente \"palabra\" está entre comillas dobles";
            // La siguiente "palabra" está entre comillas dobles
            Console.ReadKey();
        }
    }
}
