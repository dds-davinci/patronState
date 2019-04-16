# Patrón State
Ejemplo del patrón State

## Consigna

El banco se encuentra con el siguiente problema: una tarjeta de débito puede tener 3 estados posibles: En Rojo, Normal o Inhabilitada.
Cuando un cliente quiera retirar con la tarjeta podrá hacerlo siempre y cuando el estado sea Normal, ya que si el estado fuese En Rojo, el límite para retirar es de $1000. En cambio, si la tarjeta está inhabilitada no puede realizar el retiro del dinero.

Se busca establecer en la clase TarjetaDeDebito un método con la siguiente forma: public void puedeRetirar(int monto) que imprima un mensaje segun la condicion del usuario.

No debe preocuparse por el control del saldo de la cuenta.

Usted debe crear la clase TarjetaDeDebito y todas aquellas clases que crea correspondiente.

## Modelo Solución
![Modelo](/modelo.png?raw=true)

