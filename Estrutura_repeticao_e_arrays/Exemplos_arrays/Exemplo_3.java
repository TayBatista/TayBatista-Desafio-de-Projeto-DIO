import java.util.Random;

public class Exemplo_3 {

    public static void main(String[] args) {
        Random Random = new Random();

        int[] numerosAleatorios = new int[20];

        for (int i = 0; i < numerosAleatorios.length; i++) {
            int numero = Random.nextInt(100);
            numerosAleatorios[i] = numero;
        }

        System.out.println("Numeros aleatorios: ");
        for (int numero : numerosAleatorios) {
            System.out.print(numero + " ");
        }

        System.out.print("\n Sucessores dos Numeros Aleatórios: ");
        for (int numero : numerosAleatorios) {
            System.out.print((numero + 1) + " ");
        }

    }
}
