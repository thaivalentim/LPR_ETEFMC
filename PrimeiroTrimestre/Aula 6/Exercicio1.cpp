#include <iostream>
using namespace std;

int reverso(int numero) {
    int reverso = 0;

    while (numero > 0) {
        reverso = reverso * 10 + numero % 10; 
        // a multiplicação por 10 tem como objetivo deslocar os algarismos à esquerda, isto é, levá-los a uma nova ordem de grandeza no sistema de contagem decimal. 
        //A soma da divisão do número de entrada por 10 tem como objetivo pegar o último algarismo do número original e colocá-lo na nova ordem de grandeza.
        numero /= 10; 
    }
    
    return reverso;
}

int main() {
    int numero;

    cout << "Oi! Esse codigo tem como objetivo mostrar o reverso de um numero inteiro qualquer." << std::endl;
    cout << "Isso significa que os primeiros algarismos virao primeiro na nova ordem, e vice-versa." << endl;
    cout << "Para isso, insira um numero de sua preferencia: " << endl;
    cin >> numero;

    int resultado = reverso(numero);

    cout << "O reverso do numero " << numero << ", inserido por voce na entrada do terminal, equivale a " << resultado << "." << std::endl;

    return 0;
}
