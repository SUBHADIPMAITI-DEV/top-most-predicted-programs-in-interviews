using System;

class Fibonacci {
    static void Main(string[] args) {
        int n = 10;
        int[] fib = new int[n];
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 2; i < n; i++) {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        foreach (int num in fib) {
            Console.Write(num + " ");
        }
    }
}
