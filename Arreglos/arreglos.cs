using System; // Importación de Librería System.dll
using System.Linq;

// Espacio de nombres; paquete
namespace ArreglosLearn
{
    // Clase arreglo
    class Arreglo
    {
        static void Main(string[] args) {
            // Declaración valida
            int[] valores;

            valores = new int[100];  //100 elementos
            valores = new int[20];  //ahora contiene 20 elementos
            
            double[] balance = new double[10];
            
            Console.WriteLine(valores.Length);
            
            // "numeros" y "animales" ambos son declarados e inicializados con valores.
            int[] numeros = { 1, 4, -3, 6, 3 };
            string[] animales = { "gato", "perro", "oso", "tigre" };

            foreach (int i in numeros)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine(numeros.Max());  // devuelve el mayor valor
            Console.WriteLine(numeros.Min());  // devuelve el valor más pequeño
            Console.WriteLine(numeros.Sum());  // devuelve la suma de los elementos


            Array.Sort(animales);
            foreach (string i in animales)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(animales);
            foreach (string i in animales)
            {
                Console.WriteLine(i);
            }

            // Cambiar un elemento de un arreglo
            animales[0] = "lobo";

            // Order por linq de manera ascendente
            animales = animales.OrderBy(x => x).ToArray();
            
            // De manera descendente
            animales = animales.OrderByDescending(x => x).ToArray();
            Console.WriteLine("Ordenamiento por Comparison");
    
            Array.Sort<int>(numeros, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
    
            //De este modo alternativo el ordenamiento sería descendente
            //Array.Sort<int>(numeros, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
    
            Console.WriteLine(string.Join(", ", numeros));
            
            // Devuelve el índice que el elemento ocupa dentro del arreglo, o -1 en caso de que no exista. Su sintaxis es:
            // int index = Array.IndexOf(arreglo, valorBuscar);
            int index = Array.IndexOf(numeros, 3);
            Console.WriteLine(index);

            Console.ReadKey();

        }
    }
}
