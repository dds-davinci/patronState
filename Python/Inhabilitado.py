from IEstado import IEstado

class Inhabilitado(IEstado):

    def retirarSaldo(self, saldoARet: float):
        print("No puede retirar saldo")