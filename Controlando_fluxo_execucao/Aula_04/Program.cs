using System;
using static System.Console;

namespace Aula_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;

            do
            {
                WriteLine("Digite um número: , para sair digite 0");
                valor = int.Parse(ReadLine());

                if (valor == 0)
                {
                    WriteLine("Você saiu da aplicação");
                    break;
                }
                else
                {
                    WriteLine("O número digitado foi: " + valor);
                    continue; 
                }
            } while (condicao == true);
        }
    }
}
