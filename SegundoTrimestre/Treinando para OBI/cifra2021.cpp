#include <iostream>
#include <string>
#include <vector>
#include <cstdlib>

using namespace std;

vector<char> vogais = {'a', 'e', 'i', 'o', 'u'};
vector<char> consoantes = {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'};
vector<char> alfabeto = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

int main() {
    string palavra, cifra = "";
    cin >> palavra;
    int tamanhoPalavra = palavra.size();

    if (tamanhoPalavra > 1 && tamanhoPalavra <= 30) {
        for (int i = 0; i < palavra.size(); i++) {
            char c = palavra[i];
            bool ehVogal = false;

            // Verifica se é vogal
            for (int j = 0; j < vogais.size(); j++) {
                if (c == vogais[j]) {
                    ehVogal = true;
                    break;
                }
            }

            if (ehVogal) {
                cifra += c; // Se for vogal, só adiciona
            } else {
                cifra += c; // Adiciona a consoante original

                int pos = 0;
                for (int j = 0; j < alfabeto.size(); j++) {
                    if (alfabeto[j] == c) {
                        pos = j;
                        break;
                    }
                }

                // encontra a vogal mais próxima
                int distEsq = 100, distDir = 100;
                char vogalEsq = 'a', vogalDir = 'a';
                for (int j = pos; j >= 0; j--) {
                    if (alfabeto[j] == 'a' || alfabeto[j] == 'e' || alfabeto[j] == 'i' || alfabeto[j] == 'o' || alfabeto[j] == 'u') {
                        distEsq = pos - j;
                        vogalEsq = alfabeto[j];
                        break;
                    }
                }
                for (int j = pos; j < alfabeto.size(); j++) {
                    if (alfabeto[j] == 'a' || alfabeto[j] == 'e' || alfabeto[j] == 'i' || alfabeto[j] == 'o' || alfabeto[j] == 'u') {
                        distDir = j - pos;
                        vogalDir = alfabeto[j];
                        break;
                    }
                }
                if (distEsq <= distDir)
                    cifra += vogalEsq;
                else
                    cifra += vogalDir;

                // adiciona a próxima consoante
                int idx = 0;
                for (int j = 0; j < consoantes.size(); j++) {
                    if (c == consoantes[j]) {
                        idx = j;
                        break;
                    }
                }
                if (idx + 1 < consoantes.size())
                    cifra += consoantes[idx + 1];
                else
                    cifra += c; // se for 'z'
            }
        }
        cout << cifra << endl;
    }
    return 0;
}