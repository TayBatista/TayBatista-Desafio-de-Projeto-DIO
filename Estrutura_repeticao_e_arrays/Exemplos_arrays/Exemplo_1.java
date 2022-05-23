public class Exemplo_1 {
    public static void main(String[] args) {

        int[] vetor = { -5, -6, 15, 50, 8, 4 }; // contagem é a partir do 0.
        int count = 0;

        System.out.print("Vetor: ");
        while (count < vetor.length) {
            System.out.println(vetor[count] + " ");
            count++;
        }

        System.out.print("\nVetor em ordem inversa: ");
        for (int i = vetor.length - 1; i >= 0; i--) {
            System.out.println(vetor[i] + " ");
        }

    }
}
