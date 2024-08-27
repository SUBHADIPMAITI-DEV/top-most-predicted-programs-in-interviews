using System;

class ArmstrongNumbers {
    static void Main(string[] args) {
        for (int i = 1; i < 1000; i++) {
            if (IsArmstrong(i)) {
                Console.Write(i + " ");
            }
        }
    }

    static bool IsArmstrong(int num) {
        int sum = 0, temp = num, n = 0;
        while (temp != 0) {
            temp /= 10;
            n++;
        }
        temp = num;
        while (temp != 0) {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, n);
            temp /= 10;
        }
        return num == sum;
    }
}
