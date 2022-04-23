using System;
using static System.Console;

namespace Aula_03
{
    class Program
    {
        static void ExemploWhile()
        {
            Boolean condicao = true;
            int valor;

            while (condicao == true)
            {
                WriteLine("Digite um número: , para sair digite 0");
                valor = int.Parse(ReadLine());

                if (valor == 0)
                {
                    WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
                else
                {
                    WriteLine("O número digitado foi: " + valor);
                }
            }
        }

        static void ExemploFor()
        {
            int valor;
            WriteLine("Digite um número: .");
            valor = int.Parse(ReadLine());
            WriteLine();

            for (int i = valor; i <= 10; i++)
            {
                WriteLine(i);
            }
        }

        //ExemploForeach:
        static void Main(string[] args)
        {
            int[] lista = { 1, 2, 3, 4, 5 };
            foreach (int numero in lista)
            {
                WriteLine(numero);
            }
        }
    }
}
