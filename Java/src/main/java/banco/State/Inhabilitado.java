package banco.State;

public class Inhabilitado implements IEstado {
    
    public void retirarSaldo(float saldoARet){
    
        System.out.println("No puede retirar saldo");

    }

}