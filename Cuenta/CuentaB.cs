using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class CuentaB
    {
        private int nrocuenta;
        private string nombreusuario;
        private string tipocuenta;
        private string fechaapertura;
        private float saldo;
        private float retirar;
        private float consignar;

        public int Nrocuenta { get => nrocuenta; set => nrocuenta = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Tipocuenta { get => tipocuenta; set => tipocuenta = value; }
        public string Fechaapertura { get => fechaapertura; set => fechaapertura = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public float Retirar { get => retirar; set => retirar = value; }
        public float Consignar { get => consignar; set => consignar = value; }

        public CuentaB()
        {

        }

        public CuentaB(int nrocuenta, string nombreusuario, string tipocuenta, string fechaapertura, float saldo)
        {
            this.Nrocuenta = nrocuenta;     
            this.Nombreusuario = nombreusuario;
            this.Fechaapertura = fechaapertura;
            this.Saldo = saldo;
             
        }

        public void CrearUsuario()
        {
            Console.Write("\n\n\n\t\tCrear Usuario");

            Console.Write("\n\nIngrese el numero de la cuenta: ");
            nrocuenta = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del usuario: ");
            nombreusuario = Console.ReadLine();

            Console.Write("Ingrese el tipo de cuenta (Ahorros o Corriente): ");
            tipocuenta = Console.ReadLine();

            Console.Write("Ingrese fecha de apertura: ");
            fechaapertura = Console.ReadLine();

            Console.Write("Ingrese el valor del saldo a depositar: ");
            saldo = int.Parse(Console.ReadLine());
        }
        public void ConsultarSaldo()
        {
            Console.Write("\n\n\t\tConsultar Saldo ");
            Console.Write("\n\nIngrese el numero de la cuenta: ");
            nrocuenta = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nNumero de cuenta: " + nrocuenta);
            Console.WriteLine("Nombre de usuario: " + nombreusuario);
            Console.WriteLine("saldo total: " + saldo);

        }
        public float RetirarDinero() 
        {
            float  saldoactualizado;

            Console.Write("\n\n\t\tRetirar Dinero ");

            Console.Write("\n\nIngrese el numero de la cuenta: ");
            nrocuenta = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor a retirar: ");
            retirar = float.Parse(Console.ReadLine());

            if (saldo <= retirar)
                Console.Write("Fondos Insuficientes");
           
            else
                Console.Write("transaccion exitosa");

            saldoactualizado = saldo - retirar;


            return saldoactualizado;
        }

        public float ConsignarDinero()
        {
            int cuenta_destino;
            float saldoactual;

            Console.Write("\n\n\t\tConsignar Dinero ");

            Console.Write("\n\nIngrese el numero de la cuenta: ");
            nrocuenta = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de la cuenta del destino: ");
            cuenta_destino = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor a consignar: ");
            consignar = float.Parse(Console.ReadLine());

            if(saldo <= consignar)
                Console.Write("Fondos Insuficientes");

            else
                Console.Write("transaccion exitosa");

            saldoactual = saldo - consignar;

            return saldoactual;
        }
        
        public void Menu()
        {
            int opcion, respuesta;

            Console.Write("\n\n\t\tDesea realizar una Transaccion (1= NO & 2 = SI): ");
            respuesta = int.Parse(Console.ReadLine());

            while (respuesta != 2) 
            {
                Console.WriteLine("\n\n\t\tMenu de Transacciones ");
                Console.WriteLine(" 1. Consultar Saldo ");
                Console.WriteLine(" 2. Retirar Dinero ");
                Console.WriteLine(" 3. Transferir Dinero ");
                Console.Write(" Ingrese el digito de transaccion a la cual desea ingresar: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            ConsultarSaldo();
                            break;
                        }
                    case 2:
                        {
                            RetirarDinero();
                            break;
                        }
                    case 3:
                        {
                            ConsignarDinero();
                            break;
                        }

                    default:
                        {
                            Console.Write("opcion no valida");
                            break;
                        }

                }
                Console.Write("\n\n\t\tDesea Saril (1= NO & 2 = SI): ");
                respuesta = int.Parse(Console.ReadLine());

            }
           
        }

        public void ImprimirrRecibo()
        {
            Console.Write("\n\n\t\tRecibo de Transaccion");
            Console.WriteLine("\n\nNumero de Cuenta: " + nrocuenta);
            Console.WriteLine("Tipo de Cuenta: " + tipocuenta);
            Console.WriteLine("Valor retiros: " + retirar);
            Console.WriteLine("Valor Consignacion: " + consignar);
            Console.WriteLine("Saldo Actual: " + ((saldo - retirar) - consignar));

        }

    }

}
