
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.State
{
    public class Inhabilitado : IEstado
    {

        public void retirarSaldo(float saldoARet)
        {

            Console.WriteLine("No puede retirar saldo");

        }

    }
}
