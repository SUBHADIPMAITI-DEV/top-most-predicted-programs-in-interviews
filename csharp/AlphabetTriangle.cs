using System;

class AlphabetTriangle {
    static void Main(string[] args) {
        int n = 5;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++) {
                Console.Write(alphabet[j]);
            }
            Console.WriteLine();
        }
    }
}
