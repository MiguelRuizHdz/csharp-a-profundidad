﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal miAnimal = new Animal();  // Crea un objeto Animal
            Animal miGato = new Gato();  // Crea un objeto Gato
            Animal miPerro = new Perro();  // Crea un objeto Perro

            miAnimal.sonidoAnimal();
            miGato.sonidoAnimal();
            miPerro.sonidoAnimal();

            Console.ReadKey();
        }
    }

    class Animal // Clase base (padre)
    {
        public virtual void sonidoAnimal()
        {
            Console.WriteLine("El animal hace un sonido");
        }
    }

    class Gato : Animal // Clase derivada (hijo)
    {
        public override void sonidoAnimal()
        {
            Console.WriteLine("El gato dice: miau miau");
        }
    }

    class Perro : Animal // Clase derivada (hijo)
    {
        public override void sonidoAnimal()
        {
            Console.WriteLine("El perro dice: guau guau");
        }
    }

}
