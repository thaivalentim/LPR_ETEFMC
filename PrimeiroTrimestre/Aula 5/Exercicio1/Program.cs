using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Esse código tem como objetivo calcular a média aritmética de números exclusivamente \n pares.");
            Console.WriteLine(" ");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadLine();
            Console.WriteLine("Inicialmente, digite a quantidade de números a serem considerados na média: ");
            int totalPares = int.Parse(Console.ReadLine());

            int contadorPares = 0;
            int somaPares = 0;
            int numero;
            for (int i = 0; i < totalPares; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "°" + " número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    somaPares += numero;
                    contadorPares++;
                }
                else
                {
                    Console.WriteLine("O número " + numero + " não é par e foi desconsiderado no cálculo da média.");
                }
            }

            if (contadorPares > 0)
            {
                double media = (somaPares / contadorPares);
                Console.WriteLine("Calculando, aguarde...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(" ");
                Console.WriteLine("A média aritmética dos números pares inseridos é: " + media);
                Console.WriteLine(" ");
                Console.WriteLine("Obrigada por utilizar o programa!");
                Console.WriteLine("Pressione enter para sair...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nenhum número par foi inserido e por este motivo não é possível calcular a média.");
            }
        }
    }
}
