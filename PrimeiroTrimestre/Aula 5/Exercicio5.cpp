#include <iostream>
using namespace std;

int main() {
    string nomeTreinador, nomeJedi;
    double horasDiarias, horasMensais, horasSemanais, diasNec, semanasNec, mesesNec;

    cout << "Oi!" << endl;
    cout << "Este codigo foi classificado como especialista em auxiliar humanos a treinarem seus Jedis." << endl;
    cout << "Para isso, ele organiza para o treinador o plano semanal, mensal e anual de treinamento." << endl;
    cout << " " << endl;
    cout << "Para continuarmos, qual o seu nome e o do seu Jedi, respectivamente?" << endl;
    cout << "Por favor, digite sem virgulas e outras palavras. Preciso apenas de dois nomes! :)" << endl;
    cout << " " << endl;

    cin >> nomeTreinador >> nomeJedi;

    cout << " " << endl;
    cout << "Seja bem-vindo(a), " << nomeTreinador << "! Vamos iniciar o treinamento de " << nomeJedi << "." << endl;
    cout << "Qual a media de tempo, em horas, que ele (a) treina diariamente?" << endl;
    cout << " " << endl;

    cin >> horasDiarias;
    horasSemanais = horasDiarias * 5;
    horasMensais = horasSemanais * 4.5;

    cout << " " << endl;
    cout << "Humm, ok. Estou avaliando." << endl;
    cout << "Um Jedi deve ter uma carga de treinamento de 1000 horas para alcancar a excelencia." << endl;
    cout << " " << endl;

    diasNec = 1000 / horasDiarias;
    semanasNec = 1000 / horasSemanais;
    mesesNec = 1000 / horasMensais;

    cout << "De acordo com meus calculos, para que " << nomeJedi << " se torne um Jedi excelente, ele(a) precisara de:" << endl;
    cout << diasNec << " dias de treinamento, ou seja, " << semanasNec << " semanas, ou ainda " << mesesNec << " meses." << endl;
    cout << " " << endl;
    cout << "Espero que tenha gostado do meu trabalho, " << nomeTreinador << "! Que a Forca esteja com voce e " << nomeJedi << "!" << endl;
    return 0;
}