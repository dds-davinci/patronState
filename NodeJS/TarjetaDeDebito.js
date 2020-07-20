const { Normal } = require("./State/Normal");

class TarjetaDeDebito{

    #nombre;
    #numero;
    #estado = new Normal();

    constructor(nombre, numero){
        this.#nombre = nombre;
        this.#numero = numero;
    }

    retirarSaldo(saldoARet){
        this.#estado.retirarSaldo(saldoARet);
    }

    cambiarEstado(estado){
        this.#estado = estado;
    }

}

exports.TarjetaDeDebito = TarjetaDeDebito;