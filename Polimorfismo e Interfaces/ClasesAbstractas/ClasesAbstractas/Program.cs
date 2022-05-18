using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Animal
    {
        public abstract void sonidoAnimal();
        public void dormir()
        {
            Console.WriteLine("Zzz");
        }
    }
}
