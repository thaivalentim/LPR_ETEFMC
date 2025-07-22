int[] vetor = new int[10]; //:) 
int[] pares = new int[10];
int[] impares = new int[10];
int contadorPares = 0;
int contadorImpares = 0;

Console.WriteLine("Insira no prompt 10 números inteiros de sua preferência:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write($"Número {i + 1}: ");
    vetor[i] = int.Parse(Console.ReadLine());

    if (vetor[i] % 2 == 0)
    {
        pares[contadorPares] = vetor[i];
        contadorPares++;
    }
    else
    {
        impares[contadorImpares] = vetor[i];
        contadorImpares++;
    }
}

Console.WriteLine("Foram digitados " + contadorPares + " números pares, sendo eles:");
for (int i = 0; i < contadorPares; i++)
{
    Console.Write(pares[i] + " ");
}

Console.WriteLine("\nDe mesmo modo, foram digitados " + contadorImpares + " números ímpares, sendo eles:");
for (int i = 0; i < contadorImpares; i++)
{
    Console.Write(impares[i] + " ");
}