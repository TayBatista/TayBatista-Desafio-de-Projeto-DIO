using System.Collections.Generic;
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
        static void demo5()
        {
            int[] pares = new int[] { 0, 2, 4, 6, 8 };

            MudarparaImpar(pares);

            WriteLine($"Os ímpares {string.Join(",", pares)}");
        }
        static void MudarparaImpar(int[] pares)//demo5
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static void Demo6()
        {
            int[] numeros = new int[] { 0, 2, 4, 6, 8 };
            WriteLine($"Digite o número que gostaria de encontrar");
            var numero = int.Parse(ReadLine());
            var idxEncontrado = EncontrarNumero(numeros, numero);

            if (idxEncontrado >= 0)
            {
                WriteLine($"O número digitado está na posição {idxEncontrado}");
            }
            else
            {
                WriteLine($"O número digitado não foi encontrado");
            }
        }
        static int EncontrarNumero(int[] numeros, int numero)//demo6
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
        {
            foreach (var p in pessoas)
            {
                if (p.Equals(pessoa))
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main()
        {
            List<StructPessoa> pessoas = new List<StructPessoa>()
            {
                new StructPessoa(){Nome = "Ricardo"},
                new StructPessoa(){Nome = "Maria"},
                new StructPessoa(){Nome = "José"},
                new StructPessoa(){Nome = "Eduardo"},
                new StructPessoa(){Nome = "Fabiana"}
            };

            WriteLine("Digite o nome que deseja encontrar:");
            var nome = ReadLine();
            var pessoa = new StructPessoa() { Nome = nome };
            var encontrado = EncontrarPessoa(pessoas, pessoa);

            if (encontrado)
            {
                WriteLine($"O nome {nome} foi encontrado");
            }
            else
            {
                WriteLine($"O nome {nome} não foi encontrado");
            }
        }
    }
}
