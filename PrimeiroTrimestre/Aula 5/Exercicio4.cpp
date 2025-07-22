#include <iostream>
using namespace std;

int main() {
    int numero, quadrado;

    cout << "Oi!" << endl;
    cout << "Este codigo calcula a soma dos algarismos que compoem o quadrado \n de qualquer numero inteiro inserido por voce no prompt." << endl;
    cout << " " << endl;
    cout << "Vamos comecar? Digite um numero inteiro: ";
    cin >> numero;

    quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10; 
        quadrado /= 10;
    }

    quadrado = numero * numero; 

    cout << " " << endl;
    cout << "A soma dos algarismos do quadrado de " << numero << ", igual a " << quadrado << ", equivale a " << soma << "." << endl;
    cout << " " << endl;
    cout << "Obrigada por usar este programa!" << endl;
    cout << "Pressione enter para sair." << endl;
    cin.ignore();
    cin.get();
    return 0;
}