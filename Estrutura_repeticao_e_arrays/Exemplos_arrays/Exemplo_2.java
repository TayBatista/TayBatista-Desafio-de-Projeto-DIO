import java.util.Scanner;

public class Exemplo_2 {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] consoantes = new String[6];
        int QtdConsoantes = 0;

        int count = 0;
        do {
            System.out.println("Letra: ");
            String letra = scan.next();

            if (!(letra.equalsIgnoreCase("a")
                    || letra.equalsIgnoreCase("e")
                    || letra.equalsIgnoreCase("i")
                    || letra.equalsIgnoreCase("o")
                    || letra.equalsIgnoreCase("u"))) {
                consoantes[count] = letra;
                QtdConsoantes++;
            }
            count++;
        } while (count < consoantes.length);

        System.out.println("Consoantes: ");
        for (String consoante : consoantes) {
            if (consoante != null) {
                System.out.println(consoante + " ");
            }
        }
        System.out.println("Quantidade de consoantes: " + QtdConsoantes);
        System.out.println(consoantes.length);
    }
}
