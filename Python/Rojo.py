from IEstado import IEstado

class Rojo(IEstado):

    def retirarSaldo(self, saldoARet: float):

        if(saldoARet > 1000):
            print("Puede retirar $1000 como maximo")
            saldoARet = 1000

        print("Retira $ {}".format(saldoARet))