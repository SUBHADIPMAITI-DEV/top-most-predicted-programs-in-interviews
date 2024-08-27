#include <iostream>
using namespace std;

void fibonacci(int n) {
    int fib[n];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < n; i++) {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    for (int i = 0; i < n; i++) {
        cout << fib[i] << " ";
    }
}

int main() {
    int n = 10;
    fibonacci(n);
    return 0;
}
