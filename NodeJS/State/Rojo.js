const {IEstado} = require("./IEstado");

class Rojo extends IEstado{

    retirarSaldo(saldoARet){

        if(saldoARet > 1000){
            console.log("Puede retirar $1000 como maximo");
            saldoARet = 1000;
        }

        console.log("Retira $" + saldoARet);

    }

}

exports.Rojo = Rojo;