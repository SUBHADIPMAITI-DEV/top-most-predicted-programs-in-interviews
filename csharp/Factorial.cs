using System;

class Factorial {
    static void Main(string[] args) {
        int n = 5;
        Console.WriteLine(Factorial(n));
    }

    static int Factorial(int n) {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
