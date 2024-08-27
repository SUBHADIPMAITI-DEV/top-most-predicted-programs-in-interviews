using System;

class BubbleSort {
    static void Main(string[] args) {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSortArray(arr);
        foreach (int i in arr) {
            Console.Write(i + " ");
        }
    }

    static void BubbleSortArray(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
