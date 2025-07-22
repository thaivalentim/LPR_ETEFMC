using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Esse é um programa que calcula o produto de duas matrizes 3x3.");
        Console.WriteLine("Digite os elementos da primeira matriz 3x3:");

        int[,] matriz1 = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i + 1}, {j + 1}] da Matriz 1: ");
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[,] matriz2 = new int[3, 3];
        Console.WriteLine("Digite os elementos da segunda matriz, também 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i + 1}, {j + 1}] da Matriz 2: ");
                matriz2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[,] produtoMatrizes = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                produtoMatrizes[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    produtoMatrizes[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }

        Console.WriteLine("A matriz 3x3 resultante do produto das matrizes formadas previamente por você no prompt é:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{produtoMatrizes[i, j]} ");
            }
            Console.WriteLine();
        }   
    }
}