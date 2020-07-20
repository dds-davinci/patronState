using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.State
{
    public class Normal : IEstado
    {

        public void retirarSaldo(float saldoARet)
        {

            Console.WriteLine("Retira $" + saldoARet);

        }

    }
}
