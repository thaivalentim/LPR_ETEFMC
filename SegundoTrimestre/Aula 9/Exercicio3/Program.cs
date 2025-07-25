using System;
using System.Collections.Generic;

namespace Aula9.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Olá! Bem-vindo(a) sistema 'dicionário de pares chave-valor' da turma 34DS!");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine("As chaves são os nomes dos alunos matriculados e os valores são as suas respectivas idades.");
            System.Threading.Thread.Sleep(1500);

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para iniciar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Para continuarmos, insira o número de alunos que deseja adicionar ao dicionário:");
            int X = int.Parse(Console.ReadLine());

            Dictionary<string, int> dicionario34 = new Dictionary<string, int>();

            Console.Clear();
            for (int i = 1; i <= X; i++)
            {
                Console.WriteLine($"Insira o nome do aluno {i}:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Insira a idade do aluno {i}:");
                int idade = int.Parse(Console.ReadLine());

                dicionario34.Add(nome, idade);

                Console.WriteLine();
            }

            Console.Clear();
            Console.WriteLine("Obrigado por inserir os pares chave-valor!");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine();
            Console.WriteLine("Deseja visualizar o conteúdo do dicionário? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.Clear();
                Console.WriteLine("Conteúdo do dicionário:");
                foreach (var par in dicionario34)
                {
                    Console.WriteLine($"Chave: {par.Key}, Valor: {par.Value}");
                }
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você optou por não visualizar o conteúdo do dicionário.");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Agora, vamos calcular a média de idade dos alunos da turma e imprimir os nomes daqueles com idade \n igual ou maior ao valor.");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine();
            int somaIdades = 0;
            double mediaIdades = 0.0;
            foreach (var par in dicionario34)
            {
                somaIdades += par.Value;
            }
            mediaIdades = (double)somaIdades / dicionario34.Count;
            Console.WriteLine($"A média de idades dos alunos da turma 34DS equivale a {mediaIdades:F2} anos.");
            Console.WriteLine();

            foreach (var par in dicionario34)
            {
                if (par.Value >= mediaIdades)
                {
                    Console.WriteLine($"{par.Key} tem idade superior à média da turma, com {par.Value} anos.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Agora, vamos encontrar o aluno mais velho e o mais novo da turma 34DS.");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine("Procurando...");
            System.Threading.Thread.Sleep(2000);

            if (dicionario34.Count > 0)
            {
                string alunoMaisVelho = null;
                string alunoMaisNovo = null;
                int idadeMaisVelho = int.MinValue;
                int idadeMaisNovo = int.MaxValue;

                foreach (var par in dicionario34)
                {
                    if (par.Value > idadeMaisVelho)
                    {
                        idadeMaisVelho = par.Value;
                        alunoMaisVelho = par.Key;
                    }
                    if (par.Value < idadeMaisNovo)
                    {
                        idadeMaisNovo = par.Value;
                        alunoMaisNovo = par.Key;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"{alunoMaisVelho} é o aluno(a) mais velha, com {idadeMaisVelho} anos.");
                Console.WriteLine($"{alunoMaisNovo} é o aluno(a) mais novo, com {idadeMaisNovo} anos.");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Agora, todos os alunos da turma com idade Y, indicada por você, serão automaticamente desmatriculados.");
            Console.WriteLine();
            Console.WriteLine("Por favor, insira a idade Y para desmatricular os alunos:");
            int idadeY = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var alunosParaRemover = new List<string>();
            foreach (var par in dicionario34)
            {
                if (par.Value == idadeY)
                {
                    Console.WriteLine($"{par.Key} foi desmatriculado por ter {idadeY} anos.");
                    alunosParaRemover.Add(par.Key);
                }
            }
            foreach (var nome in alunosParaRemover)
            {
                dicionario34.Remove(nome);
            }

            Console.WriteLine();
            Console.WriteLine("Deseja saber quais são os alunos restantes na turma? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            Console.Clear();
            if (resposta == "s")
            {
                Console.WriteLine("Alunos restantes na turma:");
                foreach (var par in dicionario34)
                {
                    Console.WriteLine($"Nome: {par.Key}, Idade: {par.Value}");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Você optou por não visualizar os alunos restantes.");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Obrigada pela atenção! :D");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para encerrar o programa...");
            Console.ReadKey();
            
        }
    }
}