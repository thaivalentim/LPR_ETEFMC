string[] cidades = { "Vitória", "Belo Horizonte", "São Paulo", "Rio de Janeiro" };
int[,] distancias = { { 0, 524, 521, 882 },
                      { 524, 0, 434, 586 },
                      { 521, 434, 0, 429 },
                      { 882, 586, 429, 0 }
                      };
    
Console.WriteLine("Você pode escolher entre as seguintes cidades, que estão numeradas de 1 a 4:");
for (int i = 0; i < cidades.Length; i++)
{
    Console.WriteLine($"{i + 1} - {cidades[i]}");
}

Console.WriteLine("Agora que você as conhece, pode calcular as distâncias entre elas!");
Console.WriteLine("Digite o número da primeira cidade:");

int cidade1 = int.Parse(Console.ReadLine()); 
if (cidade1 < 1 || cidade1 > 4)
{
    Console.WriteLine("Número inválido! Tente novamente.");
    return;
}
else
{
    Console.WriteLine("Perfeito! Agora, digite o número da segunda cidade:");

    int cidade2 = int.Parse(Console.ReadLine());

    if (cidade2 < 1 || cidade2 > 4)
    {
        Console.WriteLine("Número inválido! Tente novamente.");
        return;
    }
    else if (cidade1 == cidade2)
    {
        Console.WriteLine("Você escolheu a mesma cidade! Não faz sentido calcular a distância entre duas cidades iguais, bobinho.");
        return;
    }
    else
    {
        int distancia = distancias[cidade1 - 1, cidade2 - 1];
        Console.WriteLine($"A distância entre {cidades[cidade1 - 1]} e {cidades[cidade2 - 1]} é de {distancia} km.");
    }
}

