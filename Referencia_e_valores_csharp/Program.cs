using static System.Console;


namespace Aula_pratica
{
    public class Program
    {
        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);

            WriteLine($"O valor da variável A é: {a}");
        }
        static int Adicionar20(int x)//demo1
        {
            return x + 20;
        }

        static void Demo2()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "João";
            p1.Documento = "123.456.789-00";
            p1.Idade = 20;

            Pessoa p2 = p1.Clone();

            TrocarNome(p1, "Maria");

            WriteLine($"O nome de p1 é: {p1.Nome}");
            WriteLine($"O nome de p2 é: {p2.Nome}");
        }
        static void TrocarNome(Pessoa p1, string NomeNovo)//demo2
        {
            p1.Nome = NomeNovo;
        }

        static void Demo3()
        {
            StructPessoa p1 = new StructPessoa
            {
                Documento = "123.678.012-12",
                Idade = 30,
                Nome = "José"
            };

            var p2 = p1;

            p1 = TrocarNome(p1, "Mario");

            WriteLine($@"
                O nome de p1 é: {p1.Nome}
                O nome de p2 é: {p2.Nome}"
            );
        }
        static StructPessoa TrocarNome(StructPessoa p1, string NomeNovo)//demo3
        {
            p1.Nome = NomeNovo;
            return p1;
        }

        static void Demo4()
        {
            string nome = "Ricardo";

            TrocarNome(nome, "José");

            WriteLine($"O novo nome é: {nome}");
        }
        static void TrocarNome(string nome, string nomeNovo)//demo4
        {
            nome = nomeNovo;
        }
        public static void Main()
        {
           


        }
    }
}
