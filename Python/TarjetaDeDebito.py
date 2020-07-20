from IEstado import IEstado
from Normal import Normal

class TarjetaDeDebito:

    __nombre: str
    __numero: str
    __estado: IEstado = Normal()
    #nombre;
    #numero;
    #estado = new Normal();

    def __init__(self, nombre, numero):
        self.__nombre = nombre
        self.__numero = numero

    def retirarSaldo(self, saldoARet: float):
        self.__estado.retirarSaldo(saldoARet)

    def cambiarEstado(self, estado: IEstado):
        self.__estado = estado