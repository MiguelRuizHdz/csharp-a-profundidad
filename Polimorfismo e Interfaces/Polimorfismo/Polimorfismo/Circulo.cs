﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Circulo : IFigura
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void DatosCirculo()
        {
            Console.WriteLine("Radio: {0}", Radio);
        }
    }
}
