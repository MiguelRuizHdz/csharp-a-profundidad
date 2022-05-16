using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class CuentaBancaria
    {
        // Auto properties (propiedades automáticas)
        public string NoCuenta {  get; set; }
        public string Usuario { get; set; }


        // backing field
        private decimal _saldo;

        // Full property (propiedad completa)
        public decimal Saldo
        {
            get { return _saldo; }
            set {
                // Evitar que el saldo sea negativo
               /*  if( value < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                } */
                _saldo = value < 0 ? 0 : value;
            }
        }

        #region constructores
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
        #endregion

        public void Retirar(decimal cantidad)
        {
            if ( cantidad > Saldo )
            {
                Console.WriteLine("Saldo insuficiente");
                // Evitar que el código se siga ejecutando
                return; // sale del método en este punto
            }
            Saldo = Saldo - cantidad;
        }

        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
        }

        // sobreescritura (override)
        public override string ToString()
        {
            // Estoy generando una cadena con el método string.Format
            return string.Format("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", NoCuenta, Usuario, Saldo);
        }
    }
}
