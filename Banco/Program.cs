using Banco.Modelo;
using System;

namespace Banco
{
    class Program
    {
        public static void Main(string[] args)
        {

            TarjetaDeDebito tarjeta = new TarjetaDeDebito("Juancito Perez", "8976 8909 7821 3123");

            tarjeta.retirarSaldo(1000);

            tarjeta.cambiarEstado(new Rojo());
            tarjeta.retirarSaldo(2000);

            tarjeta.retirarSaldo(500);

            tarjeta.cambiarEstado(new Inhabilitado());
            tarjeta.retirarSaldo(1000);

            Console.ReadLine();

        }
    }
}
