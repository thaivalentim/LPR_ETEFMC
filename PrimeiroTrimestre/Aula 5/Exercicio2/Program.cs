using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vinda (o) ao jogo de adivinhação da turma 34DS!");
            Console.WriteLine("Você deverá adivinhar um valor contido entre 1 e 100, com algumas dicas da máquina, é claro.");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Vamos começar?");
            Console.WriteLine("Pressione qualquer tecla para iniciar...");
            Console.ReadKey();

            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1, 100);
            int tentativas = 0;
            int chute = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite seu chute:");
                chute = int.Parse(Console.ReadLine());
                tentativas++;

                if (chute < valorInteiro)
                {
                    if (valorInteiro - chute < 20 && valorInteiro - chute >= 10)
                    {
                        Console.WriteLine("Está quente! O número sorteado é um pouco maior que " + chute + ". Tente novamente!");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else if (valorInteiro - chute < 10)
                    {
                        Console.WriteLine("Muito quente! " + chute + " está bem perto do valor sorteado, mas ainda é menor. Tente novamente!");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("O número é menor que " + chute + ". Tente novamente!");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                else if (chute > valorInteiro)
                {
                    if (chute - valorInteiro > 20 && chute - valorInteiro <= 10)
                    {
                        Console.WriteLine("Está quente! O número sorteado é um pouco menor que " + chute + ". Tente novamente!");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else if (chute - valorInteiro < 10)
                    {
                        Console.WriteLine("Muito quente! " + chute + " está bem perto do valor sorteado, mas é ainda maior. Tente novamente!");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Quase lá! O número é menor que " + chute + ". Tente novamente!");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número " + valorInteiro + " em " + tentativas + " tentativas.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Pressione enter para sair...");
                    Console.ReadLine();
                }

            } while (chute != valorInteiro && chute >= 1 && chute <= 100);
        }
    }
}
