#include <iostream>
using namespace std;

void modifyPointer(int* p) {
    *p = 100;
}

int main() {
    int a = 10;
    int* p = &a;
    modifyPointer(p);
    cout << a;
    return 0;
}
