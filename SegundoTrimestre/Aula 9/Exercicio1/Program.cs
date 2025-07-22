using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Aula9
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Primeiro exercício em C# relacionado a Listas e Dicionários.");
        Thread.Sleep(2000);

        List<string> listaNomes = new List<string>();

        // Adicionando nomes à lista via prompt
        Console.WriteLine("Você deve adicionar nomes à lista. Quantos deles pretende adicionar?");
        int qtdNomesAdd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtdNomesAdd; i++)
        {
            Console.WriteLine($"Digite o nome {i + 1}:");
            string nome = Console.ReadLine();
            listaNomes.Add(nome);
        }

        Console.WriteLine("Nomes adicionados com êxito.");
        Thread.Sleep(2000);

        Console.WriteLine("Agora, eles serão exibidos em ordem: do mais curto ao mais longo.");

        // Ordenando a lista de nomes do mais curto ao mais longo
        List<string> listaOrdenada = listaNomes.OrderBy(n => n.Length).ToList();
        List<string> listaAgrupada = listaOrdenada.GroupBy(n => n.Length)
                                                    .Select(g => string.Join(", ", g))
                                                    .ToList();
        foreach (var grupo in listaAgrupada)
        {
            Console.WriteLine(grupo);
            Thread.Sleep(2500);
        }
    }
}

//Para ordenar os nomes do mais curto ao mais longo: OrderBy(n => n.Length)
//Para agrupar os nomes de mesmo tamanho: GroupBy(n => n.Length)
//Para exibir todos os nomes de mesmo grupo (ou tamanho) em uma única linha: Select(g => string.Join(", ", g))