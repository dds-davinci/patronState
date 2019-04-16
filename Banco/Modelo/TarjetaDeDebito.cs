using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Modelo
{
    public class TarjetaDeDebito
    {

        private string nombre;
        private string numero;
        private Estado estado = new Normal();

        public TarjetaDeDebito(string nombre, string numero)
        {
            this.nombre = nombre;
            this.numero = numero;
        }

        public void retirarSaldo(float saldoARetirar)
        {
            estado.retirarSaldo(saldoARetirar);
        }

        public void cambiarEstado(Estado estado)
        {
            this.estado = estado;
        }

    }
}
