#include <iostream>
#include <list>
#include <random>
#include <unordered_map>
#include <thread>
#include <chrono>

using namespace std;

int main() {
    list<int> numeros;

    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> distrib(1, 100);

    for (int i = 0; i < 100; ++i) {
        numeros.push_back(distrib(gen));
    }

    cout << "Valores aleatorios (1 a 100) armazenados na lista, segundo a ordem do random_device:" << endl;
    for (auto n : numeros) {
        cout << n << " ";
    }
    cout << endl << " " << endl;
    this_thread::sleep_for(chrono::seconds(1));

    numeros.sort();

    cout << "Agora, os valores da lista estao em ordem crescente:" << endl;
    for (auto n : numeros) {
        cout << n << " ";
    }
    cout << endl << " " << endl;
    this_thread::sleep_for(chrono::seconds(1));

    cout << "Agora, removeremos todos os valores pares da lista." << endl << " " << endl;

    for (auto it = numeros.begin(); it != numeros.end(); ) {
        if (*it % 2 == 0) {
            it = numeros.erase(it);
        } else {
            ++it;
        }
    }
    this_thread::sleep_for(chrono::seconds(1));

    cout << "Apos a remocao dos valores pares, a lista fica assim:" << endl;
    for (auto n : numeros) {
        cout << n << " ";
    }
    cout << endl << " " << endl;
    this_thread::sleep_for(chrono::seconds(1));

    cout << "Agora, vamos contar quantas vezes cada valor repetido aparece na lista. Vamos tambem imprimi-los." << endl;
    cout << "Funfact: a probabilidade de uma lista com 100 valores nao possuir nenhuma repeticao e extremamente baixa!" << endl;
    cout << "Matematicamente, isso e denominado 'problema do aniversario'." << endl << " " << endl;

    unordered_map<int, int> contagem;
    for (auto n : numeros) {
        contagem[n]++;
    }

    cout << "Valores repetidos e suas quantidades:" << endl;
    for (auto& par : contagem) {
        if (par.second > 1) {
            cout << "Valor " << par.first << " aparece " << par.second << " vezes." << endl;
        }
    }
    cout << " " << endl;
    this_thread::sleep_for(chrono::seconds(1));

    cout << "Obrigada pela atencao! :D" << endl;
    cout << "Aula 9, exercicio 2." << endl;
    cout << "Pressione enter para sair!" << endl;
    cin.ignore();
    cin.get();

    return 0;
}