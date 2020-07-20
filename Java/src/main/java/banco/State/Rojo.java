package banco.State;

public class Rojo implements IEstado {
    
    public void retirarSaldo(float saldoARet){
    
        if(saldoARet > 1000){
            System.out.println("Puede retirar $1000 como maximo");
            saldoARet = 1000;
        }

        System.out.println("Retira $" + saldoARet);

    }
    
}