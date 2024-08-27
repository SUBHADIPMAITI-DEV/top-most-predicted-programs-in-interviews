using System;

class Palindrome {
    static void Main(string[] args) {
        string s = "radar";
        Console.WriteLine(IsPalindrome(s));
    }

    static bool IsPalindrome(string s) {
        int len = s.Length;
        for (int i = 0; i < len / 2; i++) {
            if (s[i] != s[len - i - 1]) {
                return false;
            }
        }
        return true;
    }
}
