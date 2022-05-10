using System; // Importación de Librería System.dll

// Espacio de nombres; paquete
namespace SaludoApp
{
    // Clase saludo
    class Saludo
    {
        // Metodo de salida; conocido como metodo main
        // static: Metodo estatico; Para que no se pueda instanciar
        // tipo void
        // al Main se le pasan parametros; el unico parametro que necesita es un array de tipo string que se le llama args
        // el compilador manda este parametro y lo puede ejecutar
        static void Main(string[] args){
            // Imprimir en consola
            Console.WriteLine("Hola C# desde VS Code");
            // Se cerrará automaticamente sino agregamos la siguiente línea
            Console.ReadKey(); // espera que presionemos una tecla para que el programa pueda finalizar y cerrarse.
        }
    }
}
