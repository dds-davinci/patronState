const {IEstado} = require("./IEstado");

class Inhabilitado extends IEstado{

    retirarSaldo(saldoARet){
        console.log("No puede retirar saldo");
    }

}

exports.Inhabilitado = Inhabilitado;