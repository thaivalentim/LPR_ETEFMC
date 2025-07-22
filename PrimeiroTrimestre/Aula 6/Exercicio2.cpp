#include <iostream>
#include <chrono>
#include <thread>
using namespace std;

// FUNCAO 1) Por meio do laço while, calcula a 
// media aritmetica de um conjunto de numeros pares fornecidos pelo usuario.
// O usuario deve fornecer primeiro a quantidade de numeros que 
// serao digitados, e em seguida, os numeros considerados na media.
// O usuario pode digitar numeros impares, porem, eles serao ignorados.

double CalcularMediaDeNumerosPares(int quantidadeNumeros) {
    int soma = 0;
    int contadorPares = 0;
    int i = 0;

    while (i < quantidadeNumeros) {
        int numero;

        cout << "Digite o numero " << i + 1 << ": ";
        cin >> numero;

        if (numero % 2 == 0) { 
            soma += numero;
            contadorPares++;
        }

        i++;
    }

    if (contadorPares == 0) {
        cout << " " << endl;
        cout << "Nenhum numero par foi digitado." << endl;
        return 0; 
    }

    return static_cast<double>(soma) / contadorPares; 
}

void f1prompt() {
    int quantidadeNumeros;

    cout << " " << endl;
    cout << "Essa funcao calcula a media aritmetica de numeros pares inseridos por voce no terminal." << endl;
    cout << "Digite a quantidade de numeros que compoem o conjunto: ";
    cin >> quantidadeNumeros;

    double media = CalcularMediaDeNumerosPares(quantidadeNumeros);

    if (media != 0) {
        cout << " " << endl;
        cout << "A media aritmetica dos numeros pares equivale a: " << media << endl;
    }
}

// FUNCAO 2) Calcula a soma de todos os numeros impares 
// multiplos de 3 que se encontrem no conjunto dos numeros de 50 a 500.

int CalcularSomaImparesMultiplosDeTres() {
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) { 
            soma += i;
        }
    }

    return soma;
}

void f2prompt() {
    int soma = CalcularSomaImparesMultiplosDeTres();

    cout << " " << endl;
    cout << "Essa funcao calcula a soma de todos os numeros impares multiplos de 3 entre [50,500]." << endl;
    std::this_thread::sleep_for(std::chrono::seconds(1));
    cout << "Ela equivale a: " << soma << "." << endl;
}

// FUNCAO 3) Calcula a soma dos algarismos do quadrado de um número inteiro 
// fornecido pelo usuário.

int SomaAlgarismosDoQuadrado(int numero) {
    int quadrado = numero * numero; 
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10; 
        quadrado /= 10; 
    }

    return soma;
}

void f3prompt() {
      
    cout << " " << endl;
    cout << "Essa funcao calcula a soma dos algarismos do quadrado de um determinado valor." << endl;
    std::this_thread::sleep_for(std::chrono::seconds(1));
    cout << "Para isso, insira um numero inteiro: ";
    std::this_thread::sleep_for(std::chrono::seconds(1));

    int numero;
    cin >> numero;

    cout << "Calculando..." << endl;
    std::this_thread::sleep_for(std::chrono::seconds(2));

    int soma = SomaAlgarismosDoQuadrado(numero);

    cout << "A soma dos algarismos do quadrado de " << numero << " equivale a: " << soma << "." << endl;

}

int main() {
    cout << "Bem-vindo! Voce pode acessar tres programas desenvolvidos por mim mesma, sendo eles:" << endl;
    std::this_thread::sleep_for(std::chrono::seconds(1));
    cout << " " << endl;
    cout << "1. Media Aritmetica de Numeros Pares;" << endl;
    std::this_thread::sleep_for(std::chrono::seconds(1));
    cout << "2. Soma de Numeros Impares Multiplos de 3;" << endl;
    std::this_thread::sleep_for(std::chrono::seconds(1));
    cout << "3. Soma dos Algarismos do Quadrado de Determinado Numero." << endl;
    std::this_thread::sleep_for(std::chrono::seconds(1));
    cout << " " << endl;
    cout << "Digite o numero associado a algum deles que te interesse para acessa-lo: ";
    
    int opcao;
    cin >> opcao;

    if (opcao == 1) {
        f1prompt();
    } else if (opcao == 2) {
        f2prompt();
    } else if (opcao == 3) {
        f3prompt();
    } else {
        cout << "Opcao invalida. Por favor, reinicie o programa e tente novamente." << endl;
    }

    return 0;
}