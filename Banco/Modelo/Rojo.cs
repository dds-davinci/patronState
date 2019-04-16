using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Modelo
{
    public class Rojo : Estado
    {

        public Rojo() { }

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
