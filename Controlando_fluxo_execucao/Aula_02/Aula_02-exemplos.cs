using System;
using static System.Console;

namespace Exemplo2
{
    class Program
    {
        static void Exemplo1comif()
        {
            int idade;

            WriteLine("Digite sua idade: ");
            idade = int.Parse(ReadLine());

            if (idade >= 18)
            {
                WriteLine("Você é maior de idade");
            }
            else
            {
                WriteLine("Você é menor de idade");
            }
        }

        static void Exemplo2comIf()
        {
            int mes;

            WriteLine("Digite o número do mês: ");
            mes = int.Parse(ReadLine());

            if (mes == 1)
            {
                WriteLine("Janeiro");
            }
            else if (mes == 2)
            {
                WriteLine("Fevereiro");
            }
            else if (mes == 3)
            {
                WriteLine("Março");
            }
            else if (mes == 4)
            {
                WriteLine("Abril");
            }
            else if (mes == 5)
            {
                WriteLine("Maio");
            }
            else if (mes == 6)
            {
                WriteLine("Junho");
            }
            else if (mes == 7)
            {
                WriteLine("Julho");
            }
            else if (mes == 8)
            {
                WriteLine("Agosto");
            }
            else if (mes == 9)
            {
                WriteLine("Setembro");
            }
            else if (mes == 10)
            {
                WriteLine("Outubro");
            }
            else if (mes == 11)
            {
                WriteLine("Novembro");
            }
            else if (mes == 12)
            {
                WriteLine("Dezembro");
            }
            else
            {
                WriteLine("Mês inválido");
            }
        }

        //Exemplo de Switch/case
        static void Main(string[] args)
        {
            int mes;

            WriteLine("Digite o número do mês: ");
            mes = int.Parse(ReadLine());

            switch (mes)
            {
                case 1:
                    WriteLine("Janeiro");
                    break;
                case 2:
                    WriteLine("Fevereiro");
                    break;
                case 3:
                    WriteLine("Março");
                    break;
                case 4:
                    WriteLine("Abril");
                    break;
                case 5:
                    WriteLine("Maio");
                    break;
                case 6:
                    WriteLine("Junho");
                    break;
                case 7:
                    WriteLine("Julho");
                    break;
                case 8:
                    WriteLine("Agosto");
                    break;
                case 9:
                    WriteLine("Setembro");
                    break;
                case 10:
                    WriteLine("Outubro");
                    break;
                case 11:
                    WriteLine("Novembro");
                    break;
                case 12:
                    WriteLine("Dezembro");
                    break;
                default:
                    WriteLine("Mês inválido");
                    break;
            }
        }
    }
}
