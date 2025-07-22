// Criação: 21/03/2025
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao jogo de RPG!");
        Console.WriteLine("Para continuar jogando, escolha entre 3 classes de personagens: Guerreiro, Mago ou Arqueiro.");
        Console.WriteLine("Após sua escolha, as características e habilidades da classe escolhida serão exibidas.");
        Console.Write("Digite sua escolha: ");

        string escolha = Console.ReadLine().ToLower(); 

        Console.WriteLine(); 

        if (escolha == "guerreiro")
        {
            Console.WriteLine("Classe escolhida: Guerreiro");
            Console.WriteLine("Tipo de ataque: Pesado");
            Console.WriteLine("Nível de defesa: Total");
            Console.WriteLine("Outras informações sobre o guerreiro serão reveladas conforme você jogar!");
        }
        else if (escolha == "mago")
        {
            Console.WriteLine("Classe escolhida: Mago");
            Console.WriteLine("Ataca por: Bola de Fogo");
            Console.WriteLine("Se defende por: Escudo de Gelo");
            Console.WriteLine("Outras informações sobre o mago serão reveladas conforme você jogar!");
        }
        else if (escolha == "arqueiro")
        {
            Console.WriteLine("Classe escolhida: Arqueiro");
            Console.WriteLine("Ataca com: Flecha Precisa e Disparo Triplo");
            Console.WriteLine("Outras informações sobre o arqueiro serão reveladas conforme você jogar!");
        }
        else
        {
            Console.WriteLine("Classe inválida! Por favor, escolha entre Guerreiro, Mago ou Arqueiro.");
        }
    }
}