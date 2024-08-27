#include <iostream>
using namespace std;

void alphabetTriangle(int n) {
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            cout << " ";
        }
        for (int j = 0; j <= i; j++) {
            cout << alphabet[j];
        }
        cout << endl;
    }
}

int main() {
    int n = 5;
    alphabetTriangle(n);
    return 0;
}
