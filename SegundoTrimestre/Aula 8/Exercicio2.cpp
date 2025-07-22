#include <iostream>
#include <string>
#include <chrono>
#include <thread>
using namespace std;

struct Livro {
    string Autor;
    string Titulo;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main() {
    cout << "Ola! Bem-vindo a Livraria da Turma 34DS!\n";
    this_thread::sleep_for(chrono::milliseconds(1500));
    cout << "Estamos, juntamente aos professores de literatura, gramatica e ingles, organizando uma feira de livros\n";
    this_thread::sleep_for(chrono::milliseconds(1500));
    cout << "Tudo isso para arrecadar fundos para a nossa festa de formatura do Terceirao de 2025!\n";
    this_thread::sleep_for(chrono::milliseconds(1500));
    cout << "Pode nos ajudar? Precisamos de livros para vender!\n";
    this_thread::sleep_for(chrono::milliseconds(1500));
    cout << "Faltam apenas 3 para termos, enfim, a quantidade minima necessaria.\n";
    this_thread::sleep_for(chrono::milliseconds(1500));

    cout << "Para isso, comece inserindo os dados de cada um deles:\n";
    Livro livros[3];

    for(int i = 0; i < 3; i++) {
        cout << "Livro " << (i + 1) << ": " << endl;
        cout << "Autor: ";
        if(i == 0) cin.ignore(); 
        getline(cin, livros[i].Autor);
        cout << "Titulo: ";
        getline(cin, livros[i].Titulo);
        cout << "Ano em que foi publicado: ";
        cin >> livros[i].AnoPublicacao;
        cout << "Numero de paginas: ";
        cin >> livros[i].NumeroPaginas;
        cout << "Valor: ";
        cin >> livros[i].Preco;
        cin.ignore(); 
        cout << endl;
    }

    this_thread::sleep_for(chrono::milliseconds(500));
    cout << "Obrigada pela ajuda! Agora, vamos calcular o preco total dos livros e a media de paginas\n";
    this_thread::sleep_for(chrono::milliseconds(1000));

    double precoTotal = 0;
    int totalPaginas = 0;
    for (int i = 0; i < 3; i++) {
        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    cout << "O preco total dos livros equivale a R$" << precoTotal << endl;
    this_thread::sleep_for(chrono::milliseconds(1000));

    double mediaPaginas = totalPaginas / 3.0;
    cout << "A media de paginas dos livros equivale a " << mediaPaginas << endl;
    this_thread::sleep_for(chrono::milliseconds(1000));
    cout << "Obrigada por ajudar a nossa formatura incentivando a leitura! :)\n";
    return 0;
}