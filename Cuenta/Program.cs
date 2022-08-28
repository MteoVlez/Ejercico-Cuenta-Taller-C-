using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaB CuentaBancaria1 = new CuentaB();
            CuentaBancaria1.CrearUsuario();
            CuentaBancaria1.Menu();
            CuentaBancaria1.ImprimirrRecibo();
             
            Console.ReadKey();
        }
    }
}
