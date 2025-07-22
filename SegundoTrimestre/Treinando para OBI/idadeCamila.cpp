#include <iostream>
using namespace std;

int main() {
    int idade1, idade2, idade3;

    cout << "Digite as idades: " << endl;
    cin >> idade1 >> idade2 >> idade3;

    if (idade1 > 5 && idade1 <= 100 && idade2 > 5 && idade2 <= 100 && idade3 > 5 && idade3 <= 100) {
        if ((idade1 >= idade2 && idade1 <= idade3) || (idade1 <= idade2 && idade1 >= idade3)) {
            cout << idade1 << endl;
        } else if ((idade2 >= idade1 && idade2 <= idade3) || (idade2 <= idade1 && idade2 >= idade3)) {
            cout << idade2 << endl;
        } else {
            cout << idade3 << endl;
        }
    }
    return 0;
}