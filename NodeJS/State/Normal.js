const {IEstado} = require("./IEstado");

class Normal extends IEstado{

    retirarSaldo(saldoARet){
        console.log("Retira $" + saldoARet);
    }

}

exports.Normal = Normal;