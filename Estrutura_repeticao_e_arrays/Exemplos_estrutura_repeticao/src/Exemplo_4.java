import java.util.Scanner;

public class Exemplo_4 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int QtdNumeros;
        int Numero;
        int QuantPares = 0, QuantImpares = 0;

        System.out.println("Digite a quantidade de números: ");
        QtdNumeros = scan.nextInt();

        int count = 0;
        do {
            System.out.println("Digite um número: ");
            Numero = scan.nextInt();

            if (Numero % 2 == 0) {
                QuantPares++;
            } else {
                QuantImpares++;
            }

            count++;
        } while (count < QtdNumeros);

        System.out.println("Quantidade de números pares: " + QuantPares);
        System.out.println("Quantidade de números impares: " + QuantImpares);
    }
}
