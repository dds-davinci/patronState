package banco;

import banco.State.IEstado;
import banco.State.Normal;

public class TarjetaDeDebito {
    
    private String nombre;
    private String numero;
    private IEstado estado = new Normal();

    public TarjetaDeDebito(String nombre, String numero)
    {
        this.nombre = nombre;
        this.numero = numero;
    }

    public void retirarSaldo(float saldoARetirar)
    {
        this.estado.retirarSaldo(saldoARetirar);
    }

    public void cambiarEstado(IEstado estado)
    {
        this.estado = estado;
    }

}