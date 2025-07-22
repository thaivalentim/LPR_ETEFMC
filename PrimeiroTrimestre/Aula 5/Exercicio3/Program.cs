using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.WriteLine("Esse código calcula a soma de todos os números ímpares múltiplos de 3 entre 50 e 500.");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();

            int soma = 0;
            for (int i = 50; i <= 500; i++)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Calculando, aguarde...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("A soma de todos os números que atendem à condição acima equivale a " + soma + ".");
            Console.WriteLine(" ");
             System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Obrigada pela atenção!");
            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
            
        }
    }
}
