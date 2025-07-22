#include <iostream>
#include <vector>
using namespace std;

int main() {
    int N, x;
    
    cin >> N;

    vector<int> pilha;
    for (int i = 0; i < N; i++) {
        cin >> x;
        if (x == 0 && !pilha.empty()) {
            pilha.pop_back(); // remove o último número
        } else if (x != 0) {
            pilha.push_back(x); // adiciona o número
        }
    } 
    
    int soma = 0;
    for (int i = 0; i < pilha.size(); i++) {
        soma += pilha[i];
    }

    cout << soma << endl;
    return 0;
}