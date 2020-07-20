using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.State
{
    public class Rojo : IEstado
    {

        public void retirarSaldo(float saldoARet) {

            if (saldoARet > 1000)
            {
                Console.WriteLine("Puede retirar $1000 como maximo");
                saldoARet = 1000;
            }

            Console.WriteLine("Retira $" + saldoARet);

        }

    }
}
