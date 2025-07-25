#include <iostream>
#include <map>
#include <string>
#include <thread>
#include <chrono>
#include <cfloat> 
#include <cmath>  
using namespace std;

int main() {
    int qtdCidades;
    double maisPopulosa = 0;
    double menosPopulosa = DBL_MAX; // lógica semelhante a usada no exercício 3
    double valorY;
    double somaPopulacao = 0;
    double mediaPopulacional;
    char resposta;
    string cidadeMaisPopulosa, cidadeMenosPopulosa;
    map<string, double> cidades;

    cout << endl;
    cout << "Oi, bem-vindo(a) ao sistema de cadastro de cidades e populacoes via dicionarios da turma 34DS!" << endl;
    this_thread::sleep_for(chrono::milliseconds(1200));

    cout << "\nPor favor, informe a quantidade de cidades que deseja cadastrar: ";
    cin >> qtdCidades;
    cin.ignore();

    cout << "\nObrigada! Vamos continuar..." << endl;
    this_thread::sleep_for(chrono::milliseconds(900));
    cout << "Abaixo, voce deve informar o nome de cada cidade e a sua respectiva populacao." << endl;
    cout << "Atencao: indique a populacao em milhao(oes) de pessoas!" << endl << endl;
    this_thread::sleep_for(chrono::milliseconds(900));

    for (int i = 0; i < qtdCidades; i++) {
        string nomeCidade;
        double populacao;

        cout << "Nome da " << (i + 1) << "a cidade: ";
        getline(cin, nomeCidade);
        cout << "Populacao de " << nomeCidade << " (em milhao(oes)): ";
        cin >> populacao;
        cin.ignore();
        cout << endl;

        cidades[nomeCidade] = populacao;
    }

    cout << "Cidades cadastradas com sucesso!\n" << endl;
    this_thread::sleep_for(chrono::milliseconds(900));

    cout << "Deseja acessar o conteudo do dicionario? (s/n): ";
    cin >> resposta;
    cin.ignore();
    cout << endl;

    if (resposta == 's' || resposta == 'S') {
        cout << "Conteudo do dicionario:" << endl;
        for (const auto& cidade : cidades) {
            cout << "Cidade: " << cidade.first << ", populacao: " << cidade.second << " milhao(oes) de habitantes." << endl;
        }
    } else {
        cout << "Tudo bem! Vamos continuar." << endl;
    }

    cout << "\nPressione qualquer tecla para continuar..." << endl;
    cin.get();

    cout << "\nAgora, vamos calcular a media populacional das cidades cadastradas por voce previamente." << endl;
    this_thread::sleep_for(chrono::milliseconds(900));
    cout << endl;

    for (const auto& cidade : cidades) {
        somaPopulacao += cidade.second;
    }

    mediaPopulacional = somaPopulacao / cidades.size();

    cout << "A media populacional das cidades cadastradas equivale a " << mediaPopulacional << " milhao(oes)." << endl;
    cout << "\nAs cidades cadastradas com populacao superior a media populacional sao:" << endl;
    this_thread::sleep_for(chrono::milliseconds(900));

    for (const auto& cidade : cidades) {
        if (cidade.second > mediaPopulacional) {
            cout << cidade.first << ", com populacao equivalente a " << cidade.second << " milhao(oes) de habitantes." << endl;
        }
    }

    cout << "\nPressione qualquer tecla para continuar..." << endl;
    cin.get();

    cout << "\nAgora, vamos encontrar a cidade mais populosa e a menos populosa." << endl;
    this_thread::sleep_for(chrono::milliseconds(900));
    cout << endl;

    for (const auto& cidade : cidades) {
        if (cidade.second > maisPopulosa) {
            maisPopulosa = cidade.second;
            cidadeMaisPopulosa = cidade.first;
        }
        if (cidade.second < menosPopulosa) {
            menosPopulosa = cidade.second;
            cidadeMenosPopulosa = cidade.first;
        }
    }

    cout << "A cidade mais populosa eh " << cidadeMaisPopulosa << ", com populacao de " << maisPopulosa << " milhao(oes) de habitantes." << endl;
    cout << "A cidade menos populosa eh " << cidadeMenosPopulosa << ", com populacao de " << menosPopulosa << " milhao(oes) de habitantes." << endl;

    cout << "\nPressione qualquer tecla para continuar..." << endl;
    cin.get();

    cout << "\nBeleza! Agora, todas as cidades com populacao igual a um valor Y fornecido por voce serao deletadas permanentemente do dicionario." << endl;
    this_thread::sleep_for(chrono::milliseconds(900));

    cout << "Por favor, informe o valor Y (em milhao(oes)): ";
    cin >> valorY;
    cin.ignore();
    cout << endl;

    for (const auto& cidade : cidades) {
        if (cidade.second == valorY) {
            cout << "A cidade " << cidade.first << " sera deletada, conforme estabelecido acima." << endl;
            cidades.erase(cidade.first);
        }
    }

    cout << "\nProntinho, cidades deletadas!" << endl;
    this_thread::sleep_for(chrono::milliseconds(900));

    cout << "Deseja saber quais ainda estao cadastradas? (s/n): ";
    cin >> resposta;
    cin.ignore();
    cout << endl;

    if (resposta == 's' || resposta == 'S') {
        cout << "Cidades restantes no dicionario:" << endl;
        for (const auto& cidade : cidades) {
            cout << "Cidade: " << cidade.first << ", populacao: " << cidade.second << " milhao(oes) de habitantes." << endl;
        }
    } else {
        cout << "Tudo bem!" << endl;
    }

    cout << "\nObrigado por utilizar o sistema de cadastro de cidades e populacoes via dicionarios da turma 34DS!" << endl;
    cout << "Ate mais!" << endl;

    cout << "\nEncerrando o programa em 3 segundos..." << endl;
    this_thread::sleep_for(chrono::seconds(3));

    return 0;
}