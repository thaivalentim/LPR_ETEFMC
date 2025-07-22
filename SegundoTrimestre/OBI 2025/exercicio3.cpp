#include <iostream>
using namespace std;

// café
// :o

int main() {
    int A, B, C, D;
    int mlDosesmin = 0, mlDosesmax = 0;
    char S = 'S';
    char N = 'N';

    cin >> A >> B >> C >> D;
    if (A >= 0 && A <= B && A < C && C >= 100 && C <= 500 && D >= 10 && D <= 100) {
        mlDosesmin = C - A;
        mlDosesmax = C - B;

        if (mlDosesmin % D == 0 || mlDosesmax % D == 0) {
            cout << S << endl; 
        } else {
            for (int i = mlDosesmin; i <= mlDosesmax; i++) {
                if (i % D == 0) {
                    cout << S << endl;
                } else {
                    cout << N << endl;
                }
            }
        }
    }
}