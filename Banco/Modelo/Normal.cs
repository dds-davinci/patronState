using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Modelo
{
    public class Normal : Estado
    {

        public Normal() { }

        public void retirarSaldo(float saldoARet)
        {

            Console.WriteLine("Retira $" + saldoARet);

        }

    }
}
