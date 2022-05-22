import java.util.Scanner;

public class Exemplo_3 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int numero;
        int maior = 0;
        int soma = 0;

        int count = 0;
        do {
            System.out.println("Digite um número: ");
            numero = scan.nextInt();

            soma = soma + numero;

            if (numero > maior)
                maior = numero;

            count = count + 1;
        } while (count < 5);

        System.out.println("O maior número é: " + maior);
        System.out.println("Média: " + (soma) / 5);
    }
}
