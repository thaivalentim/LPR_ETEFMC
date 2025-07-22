using System;

int[] vetor = new int[10];
int ocorrencias = 0;

Console.WriteLine("Insira no prompt 10 números inteiros de sua preferência:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write($"Número {i + 1}: ");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Deseja pesquisar por algum número específico? Qual?");
int numeroPesquisado = int.Parse(Console.ReadLine());

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] == numeroPesquisado)
    {
        ocorrencias++;
    }
}

if (ocorrencias > 0)
{
    Console.WriteLine("\nO número digitado aparece na seguinte posição (ou posições) do vetor, que armazena 10 valores inteiros indexados de 0 a 9:");
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] == numeroPesquisado)
        {
            Console.WriteLine($"Posição: {i}");
        }
    }
    Console.WriteLine($"\nO número '{numeroPesquisado}' apareceu {ocorrencias} vez(es) no vetor.");
}
else
{
    Console.WriteLine($"\nO número '{numeroPesquisado}' não foi encontrado no vetor!");
}

