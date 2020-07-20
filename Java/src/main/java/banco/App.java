package banco;

import java.util.Scanner;

import banco.State.*;

public class App {

    public static void main( String[] args )
    {

        TarjetaDeDebito tarjeta = new TarjetaDeDebito("Juancito Perez", "8976 8909 7821 3123");

        tarjeta.retirarSaldo(1000);

        tarjeta.cambiarEstado(new Rojo());
        tarjeta.retirarSaldo(2000);

        tarjeta.retirarSaldo(500);

        tarjeta.cambiarEstado(new Inhabilitado());
        tarjeta.retirarSaldo(1000);

        // Mantengo la consola en espera para poder leer el resultado
        Scanner scanner = new Scanner(System.in); 
        scanner.nextLine();
        scanner.close();

    }

}
