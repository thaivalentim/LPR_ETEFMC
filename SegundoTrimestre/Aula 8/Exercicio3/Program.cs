using System;

struct Herois
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

namespace HeroisExercicio3
{
    class Program
    {
        static Herois[] equipeHerois = new Herois[5];
        static Herois[] equipeSelecionada = new Herois[3];

        static void cadastrarHeroi()
        {
            Console.WriteLine("Olá! Seja bem-vindo ao sistema de cadastro de heróis da Turma 34DS!");
            Console.WriteLine("Você pode cadastrar, por enquanto, até 5 heróis.");
            Console.WriteLine("Quantos você deseja adicionar a sua equipe, considerando o limite estabelecido?");
            int quantidadeHerois;
            while (!int.TryParse(Console.ReadLine(), out quantidadeHerois) || quantidadeHerois < 1 || quantidadeHerois > 5)
            {
                Console.WriteLine("Quantidade inválida! Digite um número entre 1 e 5:");
            }

            Console.WriteLine("Beleza, entendido. Vamos começar!");

            for (int i = 0; i < quantidadeHerois; i++)
            {
                Console.WriteLine($"Digite o nome do herói {i + 1}:");
                equipeHerois[i].Nome = Console.ReadLine();

                Console.WriteLine($"Digite o poder do herói {i + 1}:");
                equipeHerois[i].Poder = Console.ReadLine();

                Console.WriteLine($"Digite a pontuação do herói {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out equipeHerois[i].Pontuacao))
                {
                    Console.WriteLine("Pontuação inválida! Digite um número inteiro:");
                }
            }

            Console.WriteLine("Os heróis foram cadastrados adequadamente!");
            Console.WriteLine("Agora, você deseja criar uma equipe com eles? (sim/não)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.WriteLine("Ótimo! Redirecionando para a seleção de equipe...");
                selecionarEquipe();
            }
            else if (resposta == "não")
            {
                Console.WriteLine("Ok, você pode cadastrar mais heróis depois.");
                Console.WriteLine("Deseja sair do sistema? (sim/não)");
                string sairResposta = Console.ReadLine().ToLower();

                if (sairResposta == "sim")
                {
                    Console.WriteLine("Saindo do sistema...");
                    return;
                }
                else if (sairResposta == "não")
                {
                    Console.WriteLine("Você ainda está no sistema. O que deseja fazer agora?");
                    exibirMenu();
                }
            }
            else
            {
                Console.WriteLine("Resposta inválida! Por favor, responda com 'sim' ou 'não'.");
            }
        }

        static void selecionarEquipe()
        {
            Console.WriteLine("Bem-vindo à seção de Seleção de Equipe!");
            Console.WriteLine("Abaixo estão suas opções.");

            int heroisCadastrados = 0;
            for (int i = 0; i < equipeHerois.Length; i++)
            {
                if (!string.IsNullOrEmpty(equipeHerois[i].Nome))
                {
                    Console.WriteLine($"Herói n{i + 1}: \n  - {equipeHerois[i].Nome}");
                    heroisCadastrados++;
                }
            }

            if (heroisCadastrados == 0)
            {
                Console.WriteLine("Nenhum herói cadastrado para selecionar.");
                return;
            }

            Console.WriteLine("Para continuarmos, selecione a quantidade de heróis que deseja adicionar à sua equipe,\n sendo o máximo 3:");
            int quantidadeSelecionada;
            while (!int.TryParse(Console.ReadLine(), out quantidadeSelecionada) || quantidadeSelecionada < 1 || quantidadeSelecionada > 3)
            {
                Console.WriteLine("Quantidade inválida! A sua equipe deve ter entre 1 e 3 integrantes.");
                return;
            }

            for (int i = 0; i < equipeSelecionada.Length; i++)
                equipeSelecionada[i] = new Herois();

            for (int i = 0; i < quantidadeSelecionada; i++)
            {
                int escolha;
                while (true)
                {
                    Console.WriteLine($"Selecione o herói {i + 1}:");
                    if (int.TryParse(Console.ReadLine(), out escolha))
                    {
                        escolha -= 1; // ajuste para índice zero
                        if (escolha >= 0 && escolha < equipeHerois.Length &&
                            !string.IsNullOrEmpty(equipeHerois[escolha].Nome) &&
                            !JaSelecionado(equipeHerois[escolha]))
                        {
                            equipeSelecionada[i] = equipeHerois[escolha];
                            Console.WriteLine($"Herói {equipeHerois[escolha].Nome} adicionado à equipe!");
                            break;
                        }
                    }
                    Console.WriteLine("Número de herói inválido. Já foi selecionado ou não é cadastrado.");
                }
            }

            Console.WriteLine("Agora, deseja calcular a pontuação total da sua nova equipe? (sim/não)");
            string opcao = Console.ReadLine().ToLower();

            if (opcao == "sim")
            {
                calcularPontuaçaoTotal();
            }
            else if (opcao == "não")
            {
                Console.WriteLine("Entendido...");
                Console.WriteLine("Exibindo menu...");
                System.Threading.Thread.Sleep(1000);
                exibirMenu();
            }
            else
            {
                Console.WriteLine("Resposta inválida!");
                return;
            }
        }

        static bool JaSelecionado(Herois heroi)
        {
            for (int i = 0; i < equipeSelecionada.Length; i++)
            {
                if (!string.IsNullOrEmpty(equipeSelecionada[i].Nome) && equipeSelecionada[i].Nome == heroi.Nome)
                    return true;
            }
            return false;
        }
        static void calcularPontuaçaoTotal()
        {
            Console.WriteLine("Bem-vindo à seção de Cálculo de Pontuação Total da Equipe!");
            Console.WriteLine("Aguarde um momento, por favor...");
            System.Threading.Thread.Sleep(1000);

            int pontuacaoTotal = 0;
            for (int i = 0; i < equipeSelecionada.Length; i++)
            {
                if (!string.IsNullOrEmpty(equipeSelecionada[i].Nome))
                    pontuacaoTotal += equipeSelecionada[i].Pontuacao;
            }

            Console.WriteLine($"A pontuação total da equipe é: {pontuacaoTotal}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Exibindo o menu...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            exibirMenu();
        }
        static void exibirEquipe()
        {
            Console.WriteLine("Bem-vindo à seção de Exibição da sua Equipe!");
            Console.WriteLine("Aqui estão os heróis do seu time:");

            for (int i = 0; i < equipeSelecionada.Length; i++)
            {
                if (!string.IsNullOrEmpty(equipeSelecionada[i].Nome))
                {
                    Console.WriteLine($"Herói: {equipeSelecionada[i].Nome} \n  - Poder: {equipeSelecionada[i].Poder} \n  - Pontuação: {equipeSelecionada[i].Pontuacao}");
                }
            }

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("O que deseja fazer agora?");
            Console.WriteLine("Exibindo menu logo abaixo...");
            System.Threading.Thread.Sleep(1000);
            exibirMenu();
        }
        static void exibirMenu()
        {
            while (true)
            {
                Console.WriteLine("Oi! Selecione uma opção:");
                Console.WriteLine("1 - Cadastrar Herói");
                Console.WriteLine("2 - Selecionar Equipe");
                Console.WriteLine("3 - Exibir Equipe");
                Console.WriteLine("4 - Sair");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    cadastrarHeroi();
                }
                else if (opcao == "2")
                {
                    selecionarEquipe();
                }
                else if (opcao == "3")
                {
                    exibirEquipe();
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Saindo do sistema...");
                    return;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        }
        static void Main(string[] args)
        {
            exibirMenu();
            Console.WriteLine("Obrigado por usar o sistema de cadastro de heróis da Turma 34DS!");
        }
    }
}