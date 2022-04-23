using System;
using static System.Console;

namespace Aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int total;

            WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(ReadLine());
            WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(ReadLine());

            total = valor1 + valor2;

            WriteLine($"A soma dos valores é: {total}");
        }
    }
}
