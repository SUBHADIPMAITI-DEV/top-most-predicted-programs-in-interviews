using System;

class ZigZagPattern {
    static void Main(string[] args) {
        int[] arr = { 4, 3, 7, 8, 6, 2, 1 };
        Zigzag(arr);
        Console.WriteLine(string.Join(" ", arr));
    }

    static void Zigzag(int[] arr) {
        bool flag = true;  // true means "<" expected, else ">" expected
        for (int i = 0; i < arr.Length - 1; i++) {
            if (flag) {
                if (arr[i] > arr[i + 1]) {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            } else {
                if (arr[i] < arr[i + 1]) {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            flag = !flag;
        }
    }
}
