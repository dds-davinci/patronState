from IEstado import IEstado

class Normal(IEstado):

    def retirarSaldo(self, saldoARet: float):
        print("Retira $ {}".format(saldoARet))