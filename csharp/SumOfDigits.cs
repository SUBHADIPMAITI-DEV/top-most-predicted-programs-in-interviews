using System;

class SumOfDigits {
    static void Main(string[] args) {
        int num = 12345;
        Console.WriteLine(SumOfDigits(num));
    }

    static int SumOfDigits(int num) {
        int sum = 0;
        while (num != 0) {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
