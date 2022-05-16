using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class CuentaBancaria
    {
        //propiedades
        public string NoCuenta {  get; set; }
        public string Usuario { get; set; }
        public decimal Saldo { get; set; }

        //Constructor vacío o por default
        public CuentaBancaria() { }
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }
        // se le piden parámetros al momento de instanciar una clase para asignarlos al atributo correspondiente.
        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta)
        {
            Usuario = usuario;
        }
        // constructor que inicializa todas las variables
        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : this(noCuenta, usuario)
        {
            Saldo = saldo;
        }
    }
}
