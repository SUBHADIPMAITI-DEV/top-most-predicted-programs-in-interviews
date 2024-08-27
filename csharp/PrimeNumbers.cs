using System;

class PrimeNumbers {
    static void Main(string[] args) {
        for (int i = 2; i <= 100; i++) {
            if (IsPrime(i)) {
                Console.Write(i + " ");
            }
        }
    }

    static bool IsPrime(int num) {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) return false;
        }
        return true;
    }
}
