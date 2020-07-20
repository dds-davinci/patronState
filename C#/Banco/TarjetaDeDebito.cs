using System;
using System.Collections.Generic;
using System.Text;

using Banco.State;

namespace Banco
{
    public class TarjetaDeDebito
    {

        private string nombre;
        private string numero;
        private IEstado estado = new Normal();

        public TarjetaDeDebito(string nombre, string numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }

        public void retirarSaldo(float saldoARetirar)
        {
            estado.retirarSaldo(saldoARetirar);
        }

        public void cambiarEstado(IEstado estado)
        {
            this.estado = estado;
        }

    }
}
