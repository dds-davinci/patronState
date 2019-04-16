
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Modelo
{
    public class Inhabilitado : Estado
    {

        public Inhabilitado() { }

        public void retirarSaldo(float saldoARet)
        {

            Console.WriteLine("No puede retirar saldo");

        }

    }
}
