using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionAlEncapsulamiento
{
    public class CuentaBancaria
    {
        private long _numeroDeCuenta;   //public long NumeroDeCuenta
        private double _saldo;
        private int _pin;

        //CONSTRUCTORES
        public CuentaBancaria()
        {

        }

        public CuentaBancaria(long numero, double saldo, int pin)
        {
            this._numeroDeCuenta = numero;
            this._saldo = saldo;
            this._pin = pin;
        }
        

        //GETTER Y SETTER
        public long Numero
        {
            get { return _numeroDeCuenta; }
            set { _numeroDeCuenta = value; }
        }

        /*
        public void Numero(long numero)
        {
            _numeroDeCuenta = numero;
        }
        public long Numero()
        {
            return _numeroDeCuenta;
        }
        */

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El saldo no puede ser negativo");
                }
                else
                    _saldo = value;
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("| cuenta: " + _numeroDeCuenta + "| saldo: " + _saldo);
        }

        public bool VerificarPin(int pin)
        {
            if (_pin == pin)
                return true;
            else
                return false;
        }

        public void Depositar(float agregar, int pin)
        {
            if (VerificarPin(pin))
            {
                if (agregar > 0)
                {
                    _saldo = _saldo + agregar;
                    Console.WriteLine("Depositado con exito, nuevo saldo: " + _saldo);
                }
                else
                {
                    Console.WriteLine("El saldo a depositar no puede ser negativo");
                }
            }
            else
                Console.WriteLine("pin incorrecto");
        }

        public void Retirar(float retirar, int pin)
        {
            if (VerificarPin(pin))
            {
                if (retirar > 0)
                {
                    _saldo = _saldo - retirar;
                    Console.WriteLine("Retirado con exito, nuevo saldo: " + _saldo);
                }
                else { Console.WriteLine("Retiro denegado"); }
            }
        }
    }
}
