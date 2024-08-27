#include <iostream>
#include <string>
using namespace std;

bool isPalindrome(string s) {
    int len = s.length();
    for (int i = 0; i < len / 2; i++) {
        if (s[i] != s[len - i - 1]) {
            return false;
        }
    }
    return true;
}

int main() {
    string s = "radar";
    cout << isPalindrome(s);
    return 0;
}
