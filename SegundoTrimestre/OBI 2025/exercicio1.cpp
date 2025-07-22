#include <iostream>
using namespace std;

// luisa
// 100%

int main() {
    int E, S, L, diF, diferencaES, diferencaSL, diferencaEL, diferencaLS, diferencaSE;

    cin >> E >> S >> L;
    
    if (E != S && E != L && S != L) {
        if (0 <= E && E <= 1000 && 0 <= S && S <= 1000 && 0 <= L && L <= 1000) { 
            if (E > S && E > L ) {
                if (S > L) {
                    diferencaES = E - S;
                    diferencaSL = S - L;
                    diF = diferencaES + diferencaSL;
                    cout << diF*2 << endl;
                } else {
                    diferencaEL = E - L;
                    diferencaLS = L - S;
                    diF = diferencaEL + diferencaLS;
                    cout << diF*2 << endl;
                }
            } else if (S > E && S > L) {
                if (E > L) {
                    diferencaSE = S - E;
                    diferencaEL = E - L;
                    diF = diferencaSE + diferencaEL;
                    cout << diF*2 << endl;
                } else {
                    diferencaSL = S - L;
                    diferencaLS = L - E;
                    diF = diferencaSL + diferencaLS;
                    cout << diF*2 << endl;
                }
            } else if (L > E && L > S) {
                if (E > S) {
                    diferencaEL = L - E;
                    diferencaSE = E - S;
                    diF = diferencaEL + diferencaSE;
                    cout << diF*2 << endl;
                } else {
                    diferencaLS = L - S;
                    diferencaSL = S - E;
                    diF = diferencaLS + diferencaSL;
                    cout << diF*2 << endl;
                }
            }
        }
    }
}