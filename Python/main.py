from TarjetaDeDebito import TarjetaDeDebito
from Rojo import Rojo
from Inhabilitado import Inhabilitado
from Normal import Normal

if __name__ == "__main__":

    tarjeta = TarjetaDeDebito("Juancito Perez", "8976 8909 7821 3123")

    tarjeta.retirarSaldo(1000)

    tarjeta.cambiarEstado(Rojo())
    tarjeta.retirarSaldo(2000)

    tarjeta.retirarSaldo(500)

    tarjeta.cambiarEstado(Inhabilitado())
    tarjeta.retirarSaldo(1000)
