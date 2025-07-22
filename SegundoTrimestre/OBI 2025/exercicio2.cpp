#include <iostream>
using namespace std;

// gato
// 100%

int main() {
    int M, N, P, G, C;
    int totalP = 0, totalG = 0, totalC = 0, totalCal = 0,  podeComer = 0;

    cin >> N >> M;

    if (N >= 1 && N <= 30 &&  M >= 1 && M <= 300000) {
        for (int i = 0; i < N; i++) {
            cin >> P >> G >> C;
            totalP += P*4;
            totalG += G*9;
            totalC += C*4;

            totalCal = totalP + totalG + totalC;
        }

        if (M > totalCal) {
            podeComer = M - totalCal;
            cout << podeComer;
        } else {
            cout << podeComer;
        }

    }
}