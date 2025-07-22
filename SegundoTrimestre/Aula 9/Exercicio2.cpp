#include <iostream>
#include <list>
#include <random>

using namespace std;

int main() {
    list<int> numeros;

    random_device rd;
    mt19937 gen(rd());
    uniform_int_distribution<> distrib(0, 100); 

    for (int i = 0; i < 100; ++i) {
        numeros.push_back(distrib(gen));
    }

    cout << "Valores aleatorios armazenados na lista:" << endl;
    for (auto n : numeros) {
        cout << n << " ";
    }
    cout << endl;

    return 0;
}