using System;
using System.Threading;

public struct Produtos
{
    public string Nome;
    public int Codigo;
    public int Quantidade;
    public double Preco;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, seja bem-vindo ao sistema de controle de estoque da Loja DS34!");
        Thread.Sleep(1500);
        Console.WriteLine("Por favor, nos ajude na organização e digite os dados de três produtos.");
        Thread.Sleep(1500);

        Produtos[] produtos = new Produtos[3];
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Digite o nome do produto {i + 1}:");
            produtos[i].Nome = Console.ReadLine();

            while (true)
            {
                Console.WriteLine($"Digite o código do produto {i + 1}, que varia entre 0001 e 9999:");
                if (int.TryParse(Console.ReadLine(), out int codigo) && codigo >= 1 && codigo <= 9999)
                {
                    produtos[i].Codigo = codigo;
                    break;
                }
                else
                {
                    Console.WriteLine("Parece que este código é inválido!");
                }
            }

            while (true)
            {
                Console.WriteLine($"Digite qual a quantidade do produto {i + 1} no estoque:");
                if (int.TryParse(Console.ReadLine(), out int quantidade) && quantidade >= 0)
                {
                    produtos[i].Quantidade = quantidade;
                    break;
                }
                Console.WriteLine("Quantidade inválida!");
            }

            while (true)
            {
                Console.WriteLine($"Digite o preço do produto {i + 1}:");
                if (double.TryParse(Console.ReadLine(), out double preco) && preco >= 0)
                {
                    produtos[i].Preco = preco;
                    break;
                }
                else
                {
                    Console.WriteLine("Preço inválido!");
                }
            }
        }

        Console.WriteLine("Beleza, agora que você organizou os dados, vamos conferir qual o valor total em estoque.");
        Console.WriteLine("Usaremos este fundo para bancar a nossa festa de formatura!");
        Thread.Sleep(2500);

        double valorTotal = 0;
        for (int i = 0; i < produtos.Length; i++)
        {
            valorTotal += produtos[i].Quantidade * produtos[i].Preco;
        }

        Console.WriteLine($"O valor total acumulado com os produtos em nosso estoque equivale a R$ {valorTotal:F2}.");
        Thread.Sleep(1000);
        Console.WriteLine("Obrigada por ajudar a Loja 34DS!");
        Thread.Sleep(1000);
        Console.WriteLine("Se quiser ajudar mais ainda, compre os docinhos da barraca do Terceirão na festa junina, este sábado 14/06!");
    }
}