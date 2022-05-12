using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMain
{
    // si accedemos a la clase Program tambien debe tener public
    public class Program
    {
        // Los parametros string[] args son opcionales
        // public es para que el metodo Main pueda ser accedido desde la clase Program
        // si es private no podremos acceder a ese metodo, pero como es el metodo Main igual se va a ejecutar
        private static void Main()
        {
            Console.WriteLine("Hola C# desde VS 2022");
            Console.ReadKey();
        }

    }
}
