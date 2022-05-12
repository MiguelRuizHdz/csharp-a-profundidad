using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatos
{
    internal class Program
    {
        // cuando declaras variables en la clase se convierten en propiedades
        // Las propiedades deben ser tipadas
        int number = 1000;
        static int edad = 21;

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

            // declaración de variables
            // es universal, no necesita tipo
            // al momento de ejecutar es cuando se le asigna un tipo de dato
            // al ser universales solo estan permitidas dentro de los objetos
            // siempre se le debe asignar un valor
            // no se le puede reasignar otro tipo de dato al momento de sobreescribir est avariable
            var variable = 3618;

            // podemos declararlo sin asignarle ningun tipo de valor
            // podemos cambiarlo de tipo de dato
            dynamic apellido;
            apellido = true;

            Console.WriteLine(monto);
            // instancia del objeto Program y se encapsula en la variable prog
            Program prog = new Program();
            // accedemos a la propiedad number
            Console.WriteLine("Tipos de Datos: " + prog.number.GetType());

            // Podemos llamar al atributo edad, ya que al ser una propiedad estatica se puede llamar directamente sin necesidad de instanciarla
            // Console.WriteLine("El valor es: " + Program.edad);
            Console.WriteLine("El valor es: " + edad);
            
            Console.ReadKey();
        }
    }
}
