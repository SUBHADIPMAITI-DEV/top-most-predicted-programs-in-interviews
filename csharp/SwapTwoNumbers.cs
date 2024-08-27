using System;

class SwapTwoNumbers {
    static void Main(string[] args) {
        int a = 5, b = 10;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a + ", b = " + b);
    }
}
