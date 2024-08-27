#include <iostream>
#include <vector>
using namespace std;

void zigzag(vector<int>& arr) {
    bool flag = true;  // true means "<" expected, else ">" expected
    for (int i = 0; i < arr.size() - 1; i++) {
        if (flag) {
            if (arr[i] > arr[i + 1]) {
                swap(arr[i], arr[i + 1]);
            }
        } else {
            if (arr[i] < arr[i + 1]) {
                swap(arr[i], arr[i + 1]);
            }
        }
        flag = !flag;
    }
}

int main() {
    vector<int> arr = {4, 3, 7, 8, 6, 2, 1};
    zigzag(arr);
    for (int i : arr) {
        cout << i << " ";
    }
    return 0;
}
